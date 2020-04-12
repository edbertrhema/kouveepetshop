using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KouveePetShop
{
    public partial class halamanOwner : Form
    {
        public halamanOwner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            halamanPegawai add = new halamanPegawai();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            halamanProduk add = new halamanProduk();
            add.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
              halamanUkuranHewan add = new halamanUkuranHewan();
              add.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            halamanJenisHewan add = new halamanJenisHewan();
            add.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            halamanLayanan add = new halamanLayanan();
            add.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            halamanHewan add = new halamanHewan();
            add.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            halamanCustomer add = new halamanCustomer();
            add.Show();

        }
    }
}
