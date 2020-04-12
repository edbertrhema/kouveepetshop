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
    public partial class halamanLayanan : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=kouveepetshop;username=root;password=");


        public halamanLayanan()
        {
            InitializeComponent();
        }

        private void halamanLayanan_Load(object sender, EventArgs e)
        {
            fillDGV("");


            string selectQuery = "SELECT * FROM kouveepetshop.ukuranhewan";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("id_ukuran_hewan"));
                
            }
            connection.Close();

        }

        public void fillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.layanan WHERE CONCAT(id_layanan, nama_layanan) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            adapter.Fill(table);



            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fillDGV(txtSearch.Text);
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

            txtLayanan.Text = "";
            txtHarga.Text = "";
            comboBox1.Text = "";
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtLayanan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtHarga.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }



        public Boolean checkTextBoxesValues()
        {
            String fname = txtLayanan.Text;
            String lname = comboBox1.Text;
            String email = txtHarga.Text;



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

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM layanan WHERE nama_layanan = @layanan", connection);

            command.Parameters.Add("@layanan", MySqlDbType.VarChar).Value = txtLayanan.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE layanan SET nama_layanan=@nm, id_ukuran_hewan=@id_uh, harga=@hr, diubah_pada = NOW()  WHERE nama_layanan = @nm", connection);

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtLayanan.Text;
            command.Parameters.Add("@id_uh", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@hr", MySqlDbType.Double).Value = txtHarga.Text;

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

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO layanan(id_layanan,id_ukuran_hewan,nama_layanan,harga,dibuat_pada,diubah_pada,dihapus_pada,pengubah_layanan) VALUES ('',@ukuran,@layanan,@harga,NOW(),NULL,NULL,'Owner')", connection);

            command.Parameters.Add("@layanan", MySqlDbType.VarChar).Value = txtLayanan.Text;
            command.Parameters.Add("@ukuran", MySqlDbType.Int32).Value = comboBox1.SelectedItem;
            command.Parameters.Add("@harga", MySqlDbType.VarChar).Value = txtHarga.Text;

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
    }
}
