namespace Kan_Bankasi
{
    partial class frm_HastaIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.cmb_KanGrubu = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TcNo = new System.Windows.Forms.TextBox();
            this.btn_Kontrol = new System.Windows.Forms.Button();
            this.btn_Cross = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Saat = new System.Windows.Forms.TextBox();
            this.txt_Tarih = new System.Windows.Forms.TextBox();
            this.txt_KayitYapan = new System.Windows.Forms.TextBox();
            this.timer_bilgi = new System.Windows.Forms.Timer(this.components);
            this.mtxt_ceptel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmb_KanGrubu
            // 
            this.cmb_KanGrubu.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_KanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KanGrubu.Enabled = false;
            this.cmb_KanGrubu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_KanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_KanGrubu.ForeColor = System.Drawing.Color.Red;
            this.cmb_KanGrubu.FormattingEnabled = true;
            this.cmb_KanGrubu.Location = new System.Drawing.Point(167, 262);
            this.cmb_KanGrubu.Name = "cmb_KanGrubu";
            this.cmb_KanGrubu.Size = new System.Drawing.Size(262, 24);
            this.cmb_KanGrubu.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.Control;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(18, 262);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 24);
            this.label21.TabIndex = 147;
            this.label21.Text = "Kan Grubu";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sil.Location = new System.Drawing.Point(300, 327);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(129, 50);
            this.btn_Sil.TabIndex = 12;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Kaydet.Location = new System.Drawing.Point(18, 327);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(129, 50);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Geri.Location = new System.Drawing.Point(18, 380);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(411, 50);
            this.btn_Geri.TabIndex = 13;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guncelle.Location = new System.Drawing.Point(161, 327);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(129, 50);
            this.btn_Guncelle.TabIndex = 11;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 123;
            this.label6.Text = "Cinsiyet";
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cinsiyet.Enabled = false;
            this.cmb_Cinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Cinsiyet.ForeColor = System.Drawing.Color.Black;
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(161, 91);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(265, 21);
            this.cmb_Cinsiyet.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(18, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 142;
            this.label13.Text = "Cep Telefonu";
            // 
            // txt_ilce
            // 
            this.txt_ilce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ilce.Enabled = false;
            this.txt_ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ilce.Location = new System.Drawing.Point(251, 226);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(178, 20);
            this.txt_ilce.TabIndex = 8;
            // 
            // txt_il
            // 
            this.txt_il.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_il.Enabled = false;
            this.txt_il.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_il.Location = new System.Drawing.Point(65, 226);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(139, 20);
            this.txt_il.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(18, 226);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 20);
            this.label18.TabIndex = 136;
            this.label18.Text = "İl";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(204, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(188, 20);
            this.label19.TabIndex = 138;
            this.label19.Text = "İlçe";
            // 
            // txt_adres
            // 
            this.txt_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adres.Enabled = false;
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.ForeColor = System.Drawing.Color.Black;
            this.txt_adres.Location = new System.Drawing.Point(18, 176);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(411, 44);
            this.txt_adres.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(18, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(411, 22);
            this.label16.TabIndex = 134;
            this.label16.Text = "İletişim Adresi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "Soyad";
            // 
            // txt_soyad
            // 
            this.txt_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyad.Enabled = false;
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(161, 63);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(265, 20);
            this.txt_soyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 130;
            this.label3.Text = "Ad";
            // 
            // txt_ad
            // 
            this.txt_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ad.Enabled = false;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(161, 37);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(129, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 127;
            this.label2.Text = "TC Numarası";
            // 
            // txt_TcNo
            // 
            this.txt_TcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TcNo.Location = new System.Drawing.Point(161, 12);
            this.txt_TcNo.MaxLength = 11;
            this.txt_TcNo.Name = "txt_TcNo";
            this.txt_TcNo.Size = new System.Drawing.Size(129, 20);
            this.txt_TcNo.TabIndex = 1;
            this.txt_TcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TcNo_KeyPress);
            // 
            // btn_Kontrol
            // 
            this.btn_Kontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Kontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kontrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Kontrol.Location = new System.Drawing.Point(300, 8);
            this.btn_Kontrol.Name = "btn_Kontrol";
            this.btn_Kontrol.Size = new System.Drawing.Size(126, 44);
            this.btn_Kontrol.TabIndex = 15;
            this.btn_Kontrol.Text = "KONTROL";
            this.btn_Kontrol.UseVisualStyleBackColor = false;
            this.btn_Kontrol.Click += new System.EventHandler(this.btn_Kontrol_Click);
            // 
            // btn_Cross
            // 
            this.btn_Cross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cross.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cross.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cross.Location = new System.Drawing.Point(18, 436);
            this.btn_Cross.Name = "btn_Cross";
            this.btn_Cross.Size = new System.Drawing.Size(408, 93);
            this.btn_Cross.TabIndex = 14;
            this.btn_Cross.Text = "CROSS MATCH";
            this.btn_Cross.UseVisualStyleBackColor = false;
            this.btn_Cross.Click += new System.EventHandler(this.btn_Cross_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.MidnightBlue;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(334, 541);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 17);
            this.label22.TabIndex = 162;
            this.label22.Text = "Saat";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.MidnightBlue;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(198, 541);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 17);
            this.label20.TabIndex = 161;
            this.label20.Text = "Tarih";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.MidnightBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Location = new System.Drawing.Point(1, 541);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(203, 17);
            this.label25.TabIndex = 159;
            this.label25.Text = "Kayıt Yapan";
            // 
            // txt_Saat
            // 
            this.txt_Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Saat.Location = new System.Drawing.Point(334, 558);
            this.txt_Saat.Name = "txt_Saat";
            this.txt_Saat.Size = new System.Drawing.Size(128, 20);
            this.txt_Saat.TabIndex = 160;
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Tarih.Location = new System.Drawing.Point(198, 558);
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Size = new System.Drawing.Size(139, 20);
            this.txt_Tarih.TabIndex = 157;
            // 
            // txt_KayitYapan
            // 
            this.txt_KayitYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KayitYapan.Location = new System.Drawing.Point(1, 558);
            this.txt_KayitYapan.Name = "txt_KayitYapan";
            this.txt_KayitYapan.Size = new System.Drawing.Size(203, 20);
            this.txt_KayitYapan.TabIndex = 158;
            // 
            // timer_bilgi
            // 
            this.timer_bilgi.Tick += new System.EventHandler(this.timer_bilgi_Tick);
            // 
            // mtxt_ceptel
            // 
            this.mtxt_ceptel.Enabled = false;
            this.mtxt_ceptel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxt_ceptel.Location = new System.Drawing.Point(161, 117);
            this.mtxt_ceptel.Mask = "(999) 000-0000";
            this.mtxt_ceptel.Name = "mtxt_ceptel";
            this.mtxt_ceptel.Size = new System.Drawing.Size(265, 21);
            this.mtxt_ceptel.TabIndex = 5;
            // 
            // frm_HastaIslemleri
            // 
            this.AcceptButton = this.btn_Kontrol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Geri;
            this.ClientSize = new System.Drawing.Size(461, 578);
            this.ControlBox = false;
            this.Controls.Add(this.mtxt_ceptel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt_Saat);
            this.Controls.Add(this.txt_Tarih);
            this.Controls.Add(this.txt_KayitYapan);
            this.Controls.Add(this.btn_Cross);
            this.Controls.Add(this.btn_Kontrol);
            this.Controls.Add(this.cmb_KanGrubu);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Cinsiyet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_ilce);
            this.Controls.Add(this.txt_il);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TcNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_HastaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frm_HastaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_KanGrubu;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_TcNo;
        private System.Windows.Forms.Button btn_Kontrol;
        private System.Windows.Forms.Button btn_Cross;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_Saat;
        private System.Windows.Forms.TextBox txt_Tarih;
        private System.Windows.Forms.TextBox txt_KayitYapan;
        private System.Windows.Forms.Timer timer_bilgi;
        private System.Windows.Forms.MaskedTextBox mtxt_ceptel;

    }
}