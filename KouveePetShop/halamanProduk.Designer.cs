namespace KouveePetShop
{
    partial class halamanProduk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtMinimal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_IMAGE = new System.Windows.Forms.Button();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Minimal";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(129, 54);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(230, 22);
            this.txtNama.TabIndex = 5;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(129, 81);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(230, 22);
            this.txtHarga.TabIndex = 6;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(129, 109);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(230, 22);
            this.txtStok.TabIndex = 7;
            // 
            // txtMinimal
            // 
            this.txtMinimal.Location = new System.Drawing.Point(130, 137);
            this.txtMinimal.Name = "txtMinimal";
            this.txtMinimal.Size = new System.Drawing.Size(229, 22);
            this.txtMinimal.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(424, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 452);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(129, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_IMAGE
            // 
            this.BTN_IMAGE.Location = new System.Drawing.Point(188, 345);
            this.BTN_IMAGE.Name = "BTN_IMAGE";
            this.BTN_IMAGE.Size = new System.Drawing.Size(110, 23);
            this.BTN_IMAGE.TabIndex = 12;
            this.BTN_IMAGE.Text = "Pilih Gambar";
            this.BTN_IMAGE.UseVisualStyleBackColor = true;
            this.BTN_IMAGE.Click += new System.EventHandler(this.BTN_IMAGE_Click);
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Location = new System.Drawing.Point(17, 456);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(75, 23);
            this.BTN_INSERT.TabIndex = 13;
            this.BTN_INSERT.Text = "Simpan";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(98, 456);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(75, 23);
            this.BTN_UPDATE.TabIndex = 14;
            this.BTN_UPDATE.Text = "Ubah";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(179, 456);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(75, 23);
            this.BTN_DELETE.TabIndex = 15;
            this.BTN_DELETE.Text = "Hapus";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Location = new System.Drawing.Point(192, 15);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(87, 23);
            this.BTN_CLEAR.TabIndex = 16;
            this.BTN_CLEAR.Text = "Bersihkan";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(599, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(678, 22);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Masukan Nama Produk";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.BTN_CLEAR);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTN_DELETE);
            this.panel1.Controls.Add(this.txtMinimal);
            this.panel1.Controls.Add(this.BTN_UPDATE);
            this.panel1.Controls.Add(this.txtStok);
            this.panel1.Controls.Add(this.BTN_INSERT);
            this.panel1.Controls.Add(this.txtHarga);
            this.panel1.Controls.Add(this.BTN_IMAGE);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 493);
            this.panel1.TabIndex = 19;
            // 
            // halamanProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "halamanProduk";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.halamanProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtMinimal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_IMAGE;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}