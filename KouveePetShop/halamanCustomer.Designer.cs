namespace KouveePetShop
{
    partial class halamanCustomer
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(110, 151);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(229, 22);
            this.txtTelp.TabIndex = 31;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(109, 95);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(230, 22);
            this.txtAlamat.TabIndex = 30;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(109, 68);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(230, 22);
            this.txtNama.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "No Telp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tgl Lahir";
            // 
            // txtJabatan
            // 
            this.txtJabatan.Location = new System.Drawing.Point(109, 179);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(229, 22);
            this.txtJabatan.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Jabatan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_DELETE);
            this.panel1.Controls.Add(this.BTN_UPDATE);
            this.panel1.Controls.Add(this.BTN_INSERT);
            this.panel1.Controls.Add(this.BTN_CLEAR);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtJabatan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAlamat);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 426);
            this.panel1.TabIndex = 35;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(243, 382);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(75, 23);
            this.BTN_DELETE.TabIndex = 39;
            this.BTN_DELETE.Text = "Hapus";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(159, 382);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(75, 23);
            this.BTN_UPDATE.TabIndex = 38;
            this.BTN_UPDATE.Text = "Ubah";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Location = new System.Drawing.Point(78, 382);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(75, 23);
            this.BTN_INSERT.TabIndex = 37;
            this.BTN_INSERT.Text = "Simpan";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Location = new System.Drawing.Point(199, 24);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(87, 23);
            this.BTN_CLEAR.TabIndex = 36;
            this.BTN_CLEAR.Text = "Bersihkan";
            this.BTN_CLEAR.UseVisualStyleBackColor = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Masukan Nama Customer";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(650, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 22);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(443, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 378);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // halamanCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "halamanCustomer";
            this.Text = "halamanMember";
            this.Load += new System.EventHandler(this.halamanCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJabatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_CLEAR;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}