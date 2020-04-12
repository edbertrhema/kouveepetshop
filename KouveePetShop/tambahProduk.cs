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
    public partial class tambahProduk : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public tambahProduk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO kouveepetshop.produk(id_produk,id_pegawai,nama_produk,harga_produk,produk_dibuat_pada,produk_diubah_pada,produk_dihapus_pada) VALUES('','','" + txtNamaProduk.Text + "','" + txtHargaProduk.Text + "','','','')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

    }
}

