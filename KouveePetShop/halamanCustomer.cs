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
    public partial class halamanCustomer : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=kouveepetshop;port=3306;username=root;password=");

        public halamanCustomer()
        {
            InitializeComponent();
        }

        private void halamanCustomer_Load(object sender, EventArgs e)
        {
            fillDGV("");
        }

        public void fillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.customer WHERE CONCAT(id_customer, nama_customer) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

        }



        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customer`(`id_customer`, `nama_customer`, `alamat`, `no_telp`,`tgl_lahir`,`jabatan`,`dibuat_pada`,`diubah_pada`,`dihapus_pada`,`pengubah_customer`) VALUES ('',@nm, @al, @nt,@tl, @jb,NOW(),NULL,NULL,'Owner')", db.getConnection());

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtNama.Text;
            command.Parameters.Add("@al", MySqlDbType.VarChar).Value = txtAlamat.Text;
            command.Parameters.Add("@nt", MySqlDbType.VarChar).Value = txtTelp.Text;
            command.Parameters.Add("@tl", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@jb", MySqlDbType.VarChar).Value = txtJabatan.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDGV("");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            // close the connection
            db.closeConnection();

        }

        public Boolean checkTextBoxesValues()
        {
            String fname = txtNama.Text;
            String lname = txtAlamat.Text;
            String email = dateTimePicker1.Text;
            String uname = txtTelp.Text;
            String pass = txtJabatan.Text;


            if (fname.Equals("") || lname.Equals("") ||
                email.Equals("") || uname.Equals("")
                || pass.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE customer SET nama_customer=@nm, alamat=@al, tgl_lahir=@tl, no_telp=@nt, jabatan=@jb, diubah_pada=NOW()  WHERE nama_customer = @nm", connection);

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtNama.Text;
            command.Parameters.Add("@al", MySqlDbType.VarChar).Value = txtAlamat.Text;
            command.Parameters.Add("@nt", MySqlDbType.VarChar).Value = txtTelp.Text;
            command.Parameters.Add("@tl", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@jb", MySqlDbType.VarChar).Value = txtJabatan.Text;

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
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelp.Text = "";
            txtJabatan.Text = "";
            dateTimePicker1.Text = "";

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM customer WHERE nama_customer = @nama", connection);

            command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNama.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAlamat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtJabatan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelp.Text = "";
            txtJabatan.Text = "";
            dateTimePicker1.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillDGV(txtSearch.Text);
        }
    }
}


