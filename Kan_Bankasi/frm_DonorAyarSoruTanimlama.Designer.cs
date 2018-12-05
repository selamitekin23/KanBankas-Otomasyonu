namespace Kan_Bankasi
{
    partial class frm_DonorAyarSoruTanimlama
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_cevap = new System.Windows.Forms.ComboBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.dtg_sorular = new System.Windows.Forms.DataGridView();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.txt_donor_soru_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sorular)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(25, 414);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(125, 41);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(594, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soru";
            // 
            // txt_soru
            // 
            this.txt_soru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soru.Location = new System.Drawing.Point(25, 72);
            this.txt_soru.Multiline = true;
            this.txt_soru.Name = "txt_soru";
            this.txt_soru.Size = new System.Drawing.Size(594, 56);
            this.txt_soru.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cevap";
            // 
            // cb_cevap
            // 
            this.cb_cevap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_cevap.FormattingEnabled = true;
            this.cb_cevap.Location = new System.Drawing.Point(25, 151);
            this.cb_cevap.Name = "cb_cevap";
            this.cb_cevap.Size = new System.Drawing.Size(182, 23);
            this.cb_cevap.TabIndex = 3;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(181, 414);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(125, 41);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(342, 414);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(125, 41);
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // dtg_sorular
            // 
            this.dtg_sorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sorular.Location = new System.Drawing.Point(25, 200);
            this.dtg_sorular.Name = "dtg_sorular";
            this.dtg_sorular.RowHeadersWidth = 4;
            this.dtg_sorular.Size = new System.Drawing.Size(594, 208);
            this.dtg_sorular.TabIndex = 11;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Location = new System.Drawing.Point(494, 414);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(125, 41);
            this.btn_cikis.TabIndex = 7;
            this.btn_cikis.Text = "GERİ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // txt_donor_soru_no
            // 
            this.txt_donor_soru_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_donor_soru_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_donor_soru_no.Location = new System.Drawing.Point(25, 29);
            this.txt_donor_soru_no.Name = "txt_donor_soru_no";
            this.txt_donor_soru_no.Size = new System.Drawing.Size(182, 21);
            this.txt_donor_soru_no.TabIndex = 1;
            this.txt_donor_soru_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donor_soru_no_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donör Soru No";
            // 
            // btn_Bul
            // 
            this.btn_Bul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bul.ForeColor = System.Drawing.Color.White;
            this.btn_Bul.Location = new System.Drawing.Point(218, 7);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(105, 31);
            this.btn_Bul.TabIndex = 8;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = false;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Location = new System.Drawing.Point(342, 7);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(105, 31);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "SİSTEMDE KAYITLI TÜM SORULAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_DonorAyarSoruTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 472);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.dtg_sorular);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.cb_cevap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_donor_soru_no);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_DonorAyarSoruTanimlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONÖR SORU TANIMLAMA";
            this.Load += new System.EventHandler(this.frm_Donör_soru_tanımlama_formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sorular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_cevap;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.DataGridView dtg_sorular;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox txt_donor_soru_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label2;
    }
}