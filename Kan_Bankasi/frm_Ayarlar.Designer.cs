namespace Kan_Bankasi
{
    partial class frm_Ayarlar
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
            this.btn_KanGrubuTanimla = new System.Windows.Forms.Button();
            this.btn_DonorSoruTanimlama = new System.Windows.Forms.Button();
            this.btn_KullaniciKayit = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_KanGrubuTanimla
            // 
            this.btn_KanGrubuTanimla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KanGrubuTanimla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KanGrubuTanimla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KanGrubuTanimla.ForeColor = System.Drawing.Color.White;
            this.btn_KanGrubuTanimla.Location = new System.Drawing.Point(12, 91);
            this.btn_KanGrubuTanimla.Name = "btn_KanGrubuTanimla";
            this.btn_KanGrubuTanimla.Size = new System.Drawing.Size(238, 45);
            this.btn_KanGrubuTanimla.TabIndex = 3;
            this.btn_KanGrubuTanimla.Text = "KAN GRUBU İSMİ TANIMLA";
            this.btn_KanGrubuTanimla.UseVisualStyleBackColor = false;
            this.btn_KanGrubuTanimla.Click += new System.EventHandler(this.btn_KanGrubuTanimla_Click);
            // 
            // btn_DonorSoruTanimlama
            // 
            this.btn_DonorSoruTanimlama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DonorSoruTanimlama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DonorSoruTanimlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DonorSoruTanimlama.ForeColor = System.Drawing.Color.White;
            this.btn_DonorSoruTanimlama.Location = new System.Drawing.Point(280, 24);
            this.btn_DonorSoruTanimlama.Name = "btn_DonorSoruTanimlama";
            this.btn_DonorSoruTanimlama.Size = new System.Drawing.Size(238, 45);
            this.btn_DonorSoruTanimlama.TabIndex = 4;
            this.btn_DonorSoruTanimlama.Text = "DONÖR SORU TANIMLAMA";
            this.btn_DonorSoruTanimlama.UseVisualStyleBackColor = false;
            this.btn_DonorSoruTanimlama.Click += new System.EventHandler(this.btn_DonorSoruTanimlama_Click);
            // 
            // btn_KullaniciKayit
            // 
            this.btn_KullaniciKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KullaniciKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KullaniciKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KullaniciKayit.ForeColor = System.Drawing.Color.White;
            this.btn_KullaniciKayit.Location = new System.Drawing.Point(12, 24);
            this.btn_KullaniciKayit.Name = "btn_KullaniciKayit";
            this.btn_KullaniciKayit.Size = new System.Drawing.Size(238, 45);
            this.btn_KullaniciKayit.TabIndex = 5;
            this.btn_KullaniciKayit.Text = "KULLANICI KAYIT";
            this.btn_KullaniciKayit.UseVisualStyleBackColor = false;
            this.btn_KullaniciKayit.Click += new System.EventHandler(this.btn_KullaniciKayit_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Chocolate;
            this.btn_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(12, 262);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(506, 38);
            this.btn_Geri.TabIndex = 6;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Geri;
            this.ClientSize = new System.Drawing.Size(542, 312);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_KullaniciKayit);
            this.Controls.Add(this.btn_DonorSoruTanimlama);
            this.Controls.Add(this.btn_KanGrubuTanimla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Ayarlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KanGrubuTanimla;
        private System.Windows.Forms.Button btn_DonorSoruTanimlama;
        private System.Windows.Forms.Button btn_KullaniciKayit;
        private System.Windows.Forms.Button btn_Geri;
    }
}