namespace KouveePetShop
{
    partial class halamanUkuranHewan
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
            this.txtUkuran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUkuran
            // 
            this.txtUkuran.Location = new System.Drawing.Point(74, 37);
            this.txtUkuran.Name = "txtUkuran";
            this.txtUkuran.Size = new System.Drawing.Size(178, 22);
            this.txtUkuran.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ukuran";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.txtUkuran);
            this.panel2.Controls.Add(this.BTN_DELETE);
            this.panel2.Controls.Add(this.BTN_UPDATE);
            this.panel2.Controls.Add(this.BTN_INSERT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 108);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "id";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(74, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 22);
            this.txtID.TabIndex = 7;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(179, 74);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(75, 23);
            this.BTN_DELETE.TabIndex = 4;
            this.BTN_DELETE.Text = "Hapus";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.Location = new System.Drawing.Point(98, 74);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(75, 23);
            this.BTN_UPDATE.TabIndex = 3;
            this.BTN_UPDATE.Text = "Ubah";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Location = new System.Drawing.Point(17, 74);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(75, 23);
            this.BTN_INSERT.TabIndex = 2;
            this.BTN_INSERT.Text = "Simpan";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Masukan Ukuran";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(156, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // halamanUkuranHewan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "halamanUkuranHewan";
            this.Text = "halamanUkuranHewan";
            this.Load += new System.EventHandler(this.halamanUkuranHewan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUkuran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
    }
}