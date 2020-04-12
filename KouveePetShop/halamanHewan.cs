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
    public partial class halamanHewan : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=kouveepetshop;username=root;password=");

        public halamanHewan()
        {
            InitializeComponent();
        }

        private void halamanHewan_Load(object sender, EventArgs e)
        {
            fillDGV("");

            string selectQuery = "SELECT * FROM kouveepetshop.jenishewan";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("id_jenis_hewan"));

            }
            connection.Close();

        }

        public void fillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.hewan WHERE CONCAT(id_hewan, nama_hewan) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fillDGV(textBox1.Text);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtHewan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCatatan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        public Boolean checkTextBoxesValues()
        {
            String fname = txtHewan.Text;
            String lname = comboBox1.Text;
            String email = txtCatatan.Text;



            if (fname.Equals("") || lname.Equals("") ||
                email.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ClearFields()
        {

            txtHewan.Text = "";
            txtCatatan.Text = "";
            comboBox1.Text = "";
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

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO hewan(id_hewan,id_jenis_hewan,nama_hewan,tgl_lahir,catatan_hewan,dibuat_pada,diubah_pada,dihapus_pada,pengubah_hewan) VALUES ('',@jenis,@hewan,@tl,@ct,NOW(),NULL,NULL,'Owner')", connection);

            command.Parameters.Add("@hewan", MySqlDbType.VarChar).Value = txtHewan.Text;
            command.Parameters.Add("@jenis", MySqlDbType.Int32).Value = comboBox1.SelectedItem;
            command.Parameters.Add("@tl", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = txtCatatan.Text;


            if (!checkTextBoxesValues())
            {
                ExecMyQuery(command, "Data Inserted");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE hewan SET nama_hewan=@nm, id_jenis_hewan=@id_jh, tgl_lahir=@tl,catatan_hewan=@ct, diubah_pada = NOW()  WHERE nama_hewan = @nm", connection);

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtHewan.Text;
            command.Parameters.Add("@id_jh", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@tl", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = txtCatatan.Text;

            if (!checkTextBoxesValues())
            {
                ExecMyQuery(command, "Data Updated");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM hewan WHERE nama_hewan = @hewan", connection);

            command.Parameters.Add("@hewan", MySqlDbType.VarChar).Value = txtHewan.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }
    }
}
