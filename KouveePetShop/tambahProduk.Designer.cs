namespace KouveePetShop
{
    partial class tambahProduk
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
            this.txtHargaProduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaProduk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHargaProduk
            // 
            this.txtHargaProduk.Location = new System.Drawing.Point(376, 175);
            this.txtHargaProduk.Name = "txtHargaProduk";
            this.txtHargaProduk.Size = new System.Drawing.Size(141, 22);
            this.txtHargaProduk.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Harga ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNamaProduk
            // 
            this.txtNamaProduk.Location = new System.Drawing.Point(376, 147);
            this.txtNamaProduk.Name = "txtNamaProduk";
            this.txtNamaProduk.Size = new System.Drawing.Size(141, 22);
            this.txtNamaProduk.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama Produk";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tambahProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHargaProduk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaProduk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "tambahProduk";
            this.Text = "tambahProduk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHargaProduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaProduk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}