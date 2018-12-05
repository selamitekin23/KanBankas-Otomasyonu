namespace Kan_Bankasi
{
    partial class frm_Kullanici_girisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kullanici_girisi));
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_kullanici_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici_adi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_kullanici_adi.Location = new System.Drawing.Point(136, 79);
            this.txt_kullanici_adi.Multiline = true;
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(277, 34);
            this.txt_kullanici_adi.TabIndex = 7;
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sifre.Location = new System.Drawing.Point(136, 130);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(277, 34);
            this.txt_sifre.TabIndex = 8;
            this.txt_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sifre_KeyPress);
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Giris.Location = new System.Drawing.Point(172, 173);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(113, 40);
            this.btn_Giris.TabIndex = 9;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Cikis.Location = new System.Drawing.Point(301, 173);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(113, 40);
            this.btn_Cikis.TabIndex = 10;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kan_Bankasi.Properties.Resources.Kullanici_Giris_Ekranlari1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 290);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Kullanici_girisi
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btn_Cikis;
            this.ClientSize = new System.Drawing.Size(422, 287);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Kullanici_girisi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAN BANKASI OTOMASYON SİSTEMİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_kullanici_adi;
        public System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_Cikis;
    }
}

