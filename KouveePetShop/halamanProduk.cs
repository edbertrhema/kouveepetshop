using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KouveePetShop
{
    public partial class halamanProduk : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=kouveepetshop;username=root;password=");
        public halamanProduk()
        {
            InitializeComponent();
        }


        public void fillDGV(string valueToSearch)
        {
            //            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.produk", connection);
            MySqlCommand command = new MySqlCommand("SELECT * FROM kouveepetshop.produk WHERE CONCAT(id_produk, nama_produk) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            //          dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[2];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void halamanProduk_Load(object sender, EventArgs e)
        {

            fillDGV("");

        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[2].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtHarga.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMinimal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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
            txtHarga.Text = "";
            txtStok.Text = "";
            txtMinimal.Text = "";

            pictureBox1.Image = null;

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Enter picture First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand command = new MySqlCommand("UPDATE produk SET nama_produk=@nama, gambar=@gambar, harga=@harga, stok=@stok, jumlah_minimal=@jumlahmin  WHERE nama_produk = @nama", connection);

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNama.Text;
                command.Parameters.Add("@gambar", MySqlDbType.Blob).Value = img;
                command.Parameters.Add("@harga", MySqlDbType.Double).Value = txtHarga.Text;
                command.Parameters.Add("@stok", MySqlDbType.Int32).Value = txtStok.Text; ;
                command.Parameters.Add("@jumlahmin", MySqlDbType.Int32).Value = txtMinimal.Text;

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
        }



        private void button5_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        public Boolean checkTextBoxesValues()
        {
            String fname = txtNama.Text;
            String lname = txtHarga.Text;
            String email = txtStok.Text;
            String uname = txtMinimal.Text;


            if (fname.Equals("") || lname.Equals("") ||
                email.Equals("") || uname.Equals("")
                )
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
            MySqlCommand command = new MySqlCommand("DELETE FROM produk WHERE nama_produk = @nama", connection);

            command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNama.Text;

            ExecMyQuery(command, "Data Deleted");

            ClearFields();
        }

        private void BTN_INSERT_click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Enter picture First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                MySqlCommand command = new MySqlCommand("INSERT INTO produk(id_produk,nama_produk,gambar,harga,stok,jumlah_minimal,dibuat_pada,diubah_pada,dihapus_pada,pengubah_produk) VALUES ('',@nama,@gambar,@harga,@stok,@jumlahmin,NOW(),NULL,NULL,'Owner')", connection);

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = txtNama.Text;
                command.Parameters.Add("@gambar", MySqlDbType.Blob).Value = img;
                command.Parameters.Add("@harga", MySqlDbType.Double).Value = txtHarga.Text;
                command.Parameters.Add("@stok", MySqlDbType.Int32).Value = txtStok.Text; ;
                command.Parameters.Add("@jumlahmin", MySqlDbType.Int32).Value = txtMinimal.Text;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillDGV(txtSearch.Text);
        }

        private void BTN_IMAGE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image (*.JPG;*.PNG;*.GIF) |*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}

