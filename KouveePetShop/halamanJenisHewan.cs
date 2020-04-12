using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KouveePetShop
{
    public partial class halamanJenisHewan : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=kouveepetshop;username=root;password=");

        public halamanJenisHewan()
        {
            InitializeComponent();
        }

        public void fillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.jenishewan WHERE CONCAT(id_jenis_hewan, jenis_hewan) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;
        }


        private void halamanJenisHewan_Load(object sender, EventArgs e)
        {
            fillDGV("");
        }
        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {

            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show(myMsg);

            }
            else
            {

                MessageBox.Show("Query Not Executed");

            }

            connection.Close();

            fillDGV("");
        }

        public void ClearFields()
        {
            txtJenis.Text = "";
            txtID.Text = "";
        }


        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            txtJenis.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO jenishewan(id_jenis_hewan,jenis_hewan,dibuat_pada,diubah_pada,dihapus_pada,pengubah_jenis_hewan) VALUES ('',@jenis,NOW(),NULL,NULL,'Owner')", connection);

            command.Parameters.Add("@jenis", MySqlDbType.VarChar).Value = txtJenis.Text;

            if (txtJenis.Text == "")
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                ExecMyQuery(command, "Data Inserted");
                ClearFields();
            }

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE jenishewan SET jenis_hewan=@jenis, diubah_pada =NOW() WHERE id_jenis_hewan=@id", connection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = txtID.Text;
            command.Parameters.Add("@jenis", MySqlDbType.VarChar).Value = txtJenis.Text;

            if (txtJenis.Text == "")
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                ExecMyQuery(command, "Data Updated");
                ClearFields();
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM jenishewan WHERE jenis_hewan = @jenis", connection);

            command.Parameters.Add("@jenis", MySqlDbType.VarChar).Value = txtJenis.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillDGV(txtSearch.Text);
        }
    }
}
