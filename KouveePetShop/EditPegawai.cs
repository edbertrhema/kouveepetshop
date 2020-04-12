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
    public partial class EditPegawai : Form
    {
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public EditPegawai()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string searchQuery = "SELECT nama_pegawai,alamat_pegawai,tgl_lahir_pegawai,no_telp_pegawai,password,pegawai_jabatan FROM kouveepetshop.pegawai WHERE nama_pegawai ='" + inputNama.Text + "'";

            command = new MySqlCommand(searchQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                txtEditNama.Text = mdr.GetString("nama_pegawai");
                txtEditAlamat.Text = mdr.GetString("alamat_pegawai");
                txtEditTglLahir.Text = mdr.GetString("tgl_lahir_pegawai");
                txtEditNoHP.Text = mdr.GetString("no_telp_pegawai");
                txtEditPassword.Text = mdr.GetString("password");
                txtEditJabatan.Text = mdr.GetString("pegawai_jabatan");

            }
            else
            {
                txtEditNama.Text = "";
                txtEditAlamat.Text = "";
                txtEditTglLahir.Text = "";
                txtEditNoHP.Text = "";
                txtEditPassword.Text = "";
                txtEditJabatan.Text = "";
                MessageBox.Show("No Data For This Id");
            }
            connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM kouveepetshop.pegawai WHERE nama_pegawai='" + txtEditNama.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Berhasil Dihapus !");
                }
                else
                {
                    MessageBox.Show("Data Tidak Dapat Dihapus !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE kouveepetshop.pegawai SET nama_pegawai = '" + txtEditNama.Text + "', alamat_pegawai = '" + txtEditAlamat.Text + "', tgl_lahir_pegawai = '" + txtEditTglLahir.Text + "', no_telp_pegawai = '" + txtEditNoHP.Text + "', password = '" + txtEditPassword.Text + "', pegawai_jabatan = '" + txtEditJabatan.Text + "' WHERE nama_pegawai='" + txtEditNama.Text + "'";

            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Berhasil Diubah !");
                }
                else
                {
                    MessageBox.Show("Data Tidak Berhasil Diubah !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void txtEditNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
