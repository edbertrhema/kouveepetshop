using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KouveePetShop
{
    public partial class halamanPegawai : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=kouveepetshop;port=3306;username=root;password=");
        public halamanPegawai()
        {
            InitializeComponent();
        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {

            // add a new user
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `pegawai`(`id_pegawai`, `nama_pegawai`, `alamat`, `tgl_lahir`, `no_telp`,`kata_sandi`,`jabatan`,`dibuat_pada`,`diubah_pada`,`dihapus_pada`,`pengubah_pegawai`) VALUES ('',@nm, @al, @tl,@nt, @ks, @jb,NOW(),NULL,NULL,'Owner')", db.getConnection());

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtNama.Text;
            command.Parameters.Add("@al", MySqlDbType.VarChar).Value = txtAlamat.Text;
            command.Parameters.Add("@nt", MySqlDbType.VarChar).Value = txtTelp.Text;
            command.Parameters.Add("@tl", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@ks", MySqlDbType.VarChar).Value = txtSandi.Text;
            command.Parameters.Add("@jb", MySqlDbType.VarChar).Value = txtJabatan.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if (txtSandi.Text.Equals(txtSandi2.Text))
                {
                    // check if this username already exists
/*                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
*/                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillDGV("");
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
 //                   }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            // close the connection
            db.closeConnection();

        }







        // check if the username already exists
        /*         public Boolean checkUsername()
               {
                 DB db = new DB();

                   String username = textBoxUsername.Text;

                   DataTable table = new DataTable();

                   MySqlDataAdapter adapter = new MySqlDataAdapter();

                   MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

                   command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

                   adapter.SelectCommand = command;

                   adapter.Fill(table);

                   // check if this username already exists in the database
                   if (table.Rows.Count > 0)
                   {
                       return true;
                   }
                   else
                   {
                       return false;
                   }
      
    } */

        // check if the textboxes contains the default values
            public Boolean checkTextBoxesValues()
                {
                    String fname = txtNama.Text;
                    String lname = txtAlamat.Text;
                    String email = txtTelp.Text;
                    String uname = txtJabatan.Text;
                    String pass = txtSandi.Text;
       

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

        // fill the datagrid with the table
        private void tambahPegawai_Load(object sender, EventArgs e)
        {
            fillDGV("");
        }

        // command to fill
        public void fillDGV(string valueToSearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.pegawai WHERE CONCAT(id_pegawai, nama_pegawai) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAlamat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSandi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtJabatan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM pegawai WHERE nama_pegawai = @nama", connection);

            command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNama.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }

        public void ClearFields()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelp.Text = "";
            txtSandi.Text = "";
            txtSandi2.Text = "";
            txtJabatan.Text = "";
            dateTimePicker1.Text = "";

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



        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {

            MySqlCommand command = new MySqlCommand("UPDATE pegawai SET nama_pegawai=@nm, alamat=@al, tgl_lahir=@tl, no_telp=@nt, kata_sandi=@ks, jabatan=@jb  WHERE nama_pegawai = @nm", connection);

            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = txtNama.Text;
            command.Parameters.Add("@al", MySqlDbType.VarChar).Value = txtAlamat.Text;
            command.Parameters.Add("@nt", MySqlDbType.VarChar).Value = txtTelp.Text;
            command.Parameters.Add("@tl", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@ks", MySqlDbType.VarChar).Value = txtSandi.Text;
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

        // button for cleaning the textfield
        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelp.Text = "";
            txtSandi.Text = "";
            txtSandi2.Text = "";
            txtJabatan.Text = "";
            dateTimePicker1.Text = "";
        }

        // get input from search field
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillDGV(txtSearch.Text);
        }
    }
}
