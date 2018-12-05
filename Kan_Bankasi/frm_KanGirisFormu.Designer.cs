namespace Kan_Bankasi
{
    partial class frm_KanGirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KanGirisFormu));
            this.txt_DonorIslemNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DonorNo = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.txt_KayitYapan = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_KanGrubu = new System.Windows.Forms.Label();
            this.txt_KanGrubu = new System.Windows.Forms.TextBox();
            this.lbl_Itarih = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.lbl_DonorİslemNo = new System.Windows.Forms.Label();
            this.btn_Yazdir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_Skt = new System.Windows.Forms.Label();
            this.txt_Skt = new System.Windows.Forms.TextBox();
            this.lbl_Barkod = new System.Windows.Forms.Label();
            this.lbl_BarkodNumarasi = new System.Windows.Forms.Label();
            this.btn_ikontrol = new System.Windows.Forms.Button();
            this.btn_BilgileriGetir = new System.Windows.Forms.Button();
            this.date_Itarih = new System.Windows.Forms.DateTimePicker();
            this.lbl_Saat = new System.Windows.Forms.Label();
            this.date_Saat = new System.Windows.Forms.DateTimePicker();
            this.timer_bilgi = new System.Windows.Forms.Timer(this.components);
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Stok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_DonorIslemNo
            // 
            this.txt_DonorIslemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonorIslemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DonorIslemNo.ForeColor = System.Drawing.Color.Black;
            this.txt_DonorIslemNo.Location = new System.Drawing.Point(161, 12);
            this.txt_DonorIslemNo.MaxLength = 11;
            this.txt_DonorIslemNo.Name = "txt_DonorIslemNo";
            this.txt_DonorIslemNo.Size = new System.Drawing.Size(154, 20);
            this.txt_DonorIslemNo.TabIndex = 1;
            this.txt_DonorIslemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DonorIslemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonorIslemNo_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Donör No";
            // 
            // txt_DonorNo
            // 
            this.txt_DonorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonorNo.Enabled = false;
            this.txt_DonorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DonorNo.ForeColor = System.Drawing.Color.Black;
            this.txt_DonorNo.Location = new System.Drawing.Point(161, 37);
            this.txt_DonorNo.Name = "txt_DonorNo";
            this.txt_DonorNo.Size = new System.Drawing.Size(154, 20);
            this.txt_DonorNo.TabIndex = 2;
            this.txt_DonorNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Soyad.Location = new System.Drawing.Point(13, 90);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(143, 20);
            this.lbl_Soyad.TabIndex = 13;
            this.lbl_Soyad.Text = "Soyad";
            // 
            // txt_soyad
            // 
            this.txt_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyad.Enabled = false;
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.ForeColor = System.Drawing.Color.Black;
            this.txt_soyad.Location = new System.Drawing.Point(161, 90);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(154, 20);
            this.txt_soyad.TabIndex = 4;
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Ad.Location = new System.Drawing.Point(13, 64);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(143, 20);
            this.lbl_Ad.TabIndex = 15;
            this.lbl_Ad.Text = "Ad";
            // 
            // txt_ad
            // 
            this.txt_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ad.Enabled = false;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.ForeColor = System.Drawing.Color.Black;
            this.txt_ad.Location = new System.Drawing.Point(161, 63);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(154, 20);
            this.txt_ad.TabIndex = 3;
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_saat
            // 
            this.txt_saat.Enabled = false;
            this.txt_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_saat.Location = new System.Drawing.Point(422, 511);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(170, 20);
            this.txt_saat.TabIndex = 112;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Enabled = false;
            this.txt_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarih.Location = new System.Drawing.Point(226, 511);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(205, 20);
            this.txt_tarih.TabIndex = 111;
            // 
            // txt_KayitYapan
            // 
            this.txt_KayitYapan.Enabled = false;
            this.txt_KayitYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KayitYapan.Location = new System.Drawing.Point(2, 511);
            this.txt_KayitYapan.Name = "txt_KayitYapan";
            this.txt_KayitYapan.Size = new System.Drawing.Size(225, 20);
            this.txt_KayitYapan.TabIndex = 110;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.MidnightBlue;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(422, 494);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 17);
            this.label22.TabIndex = 109;
            this.label22.Text = "Saat";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.MidnightBlue;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(226, 494);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(205, 17);
            this.label20.TabIndex = 108;
            this.label20.Text = "Tarih";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.MidnightBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Location = new System.Drawing.Point(2, 494);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(225, 17);
            this.label25.TabIndex = 107;
            this.label25.Text = "Kayıt Yapan";
            // 
            // lbl_KanGrubu
            // 
            this.lbl_KanGrubu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_KanGrubu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KanGrubu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_KanGrubu.Location = new System.Drawing.Point(13, 202);
            this.lbl_KanGrubu.Name = "lbl_KanGrubu";
            this.lbl_KanGrubu.Size = new System.Drawing.Size(302, 20);
            this.lbl_KanGrubu.TabIndex = 114;
            this.lbl_KanGrubu.Text = "Kan Grubu";
            // 
            // txt_KanGrubu
            // 
            this.txt_KanGrubu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KanGrubu.Enabled = false;
            this.txt_KanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KanGrubu.ForeColor = System.Drawing.Color.Red;
            this.txt_KanGrubu.Location = new System.Drawing.Point(13, 222);
            this.txt_KanGrubu.Multiline = true;
            this.txt_KanGrubu.Name = "txt_KanGrubu";
            this.txt_KanGrubu.Size = new System.Drawing.Size(302, 54);
            this.txt_KanGrubu.TabIndex = 8;
            this.txt_KanGrubu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Itarih
            // 
            this.lbl_Itarih.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Itarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Itarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Itarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Itarih.Location = new System.Drawing.Point(13, 122);
            this.lbl_Itarih.Name = "lbl_Itarih";
            this.lbl_Itarih.Size = new System.Drawing.Size(143, 20);
            this.lbl_Itarih.TabIndex = 116;
            this.lbl_Itarih.Text = "İşlem Tarihi";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Kaydet.Location = new System.Drawing.Point(26, 400);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(130, 42);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "KAYDET";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Geri.Location = new System.Drawing.Point(13, 449);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(554, 31);
            this.btn_Geri.TabIndex = 13;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // lbl_DonorİslemNo
            // 
            this.lbl_DonorİslemNo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_DonorİslemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DonorİslemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DonorİslemNo.ForeColor = System.Drawing.Color.Black;
            this.lbl_DonorİslemNo.Location = new System.Drawing.Point(13, 13);
            this.lbl_DonorİslemNo.Name = "lbl_DonorİslemNo";
            this.lbl_DonorİslemNo.Size = new System.Drawing.Size(143, 20);
            this.lbl_DonorİslemNo.TabIndex = 124;
            this.lbl_DonorİslemNo.Text = "Donör İşlem No";
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Yazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yazdir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Yazdir.Location = new System.Drawing.Point(226, 400);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(130, 42);
            this.btn_Yazdir.TabIndex = 11;
            this.btn_Yazdir.Text = "YAZDIR";
            this.btn_Yazdir.UseVisualStyleBackColor = false;
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbl_Skt
            // 
            this.lbl_Skt.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Skt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Skt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Skt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Skt.Location = new System.Drawing.Point(13, 174);
            this.lbl_Skt.Name = "lbl_Skt";
            this.lbl_Skt.Size = new System.Drawing.Size(143, 20);
            this.lbl_Skt.TabIndex = 127;
            this.lbl_Skt.Text = "Son Kullanma Tarihi";
            // 
            // txt_Skt
            // 
            this.txt_Skt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Skt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Skt.ForeColor = System.Drawing.Color.Black;
            this.txt_Skt.Location = new System.Drawing.Point(161, 174);
            this.txt_Skt.Name = "txt_Skt";
            this.txt_Skt.Size = new System.Drawing.Size(154, 20);
            this.txt_Skt.TabIndex = 7;
            this.txt_Skt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Barkod
            // 
            this.lbl_Barkod.AllowDrop = true;
            this.lbl_Barkod.BackColor = System.Drawing.Color.White;
            this.lbl_Barkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Barkod.Enabled = false;
            this.lbl_Barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Barkod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Barkod.Location = new System.Drawing.Point(13, 299);
            this.lbl_Barkod.Name = "lbl_Barkod";
            this.lbl_Barkod.Size = new System.Drawing.Size(302, 80);
            this.lbl_Barkod.TabIndex = 9;
            // 
            // lbl_BarkodNumarasi
            // 
            this.lbl_BarkodNumarasi.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_BarkodNumarasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_BarkodNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BarkodNumarasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_BarkodNumarasi.Location = new System.Drawing.Point(13, 279);
            this.lbl_BarkodNumarasi.Name = "lbl_BarkodNumarasi";
            this.lbl_BarkodNumarasi.Size = new System.Drawing.Size(302, 20);
            this.lbl_BarkodNumarasi.TabIndex = 122;
            this.lbl_BarkodNumarasi.Text = "BARKOD NUMARASI";
            // 
            // btn_ikontrol
            // 
            this.btn_ikontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ikontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ikontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ikontrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ikontrol.Location = new System.Drawing.Point(334, 54);
            this.btn_ikontrol.Name = "btn_ikontrol";
            this.btn_ikontrol.Size = new System.Drawing.Size(246, 36);
            this.btn_ikontrol.TabIndex = 15;
            this.btn_ikontrol.Text = "Donör İşlem Numarası Yardım";
            this.btn_ikontrol.UseVisualStyleBackColor = false;
            this.btn_ikontrol.Click += new System.EventHandler(this.btn_ikontrol_Click);
            // 
            // btn_BilgileriGetir
            // 
            this.btn_BilgileriGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_BilgileriGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BilgileriGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BilgileriGetir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BilgileriGetir.Location = new System.Drawing.Point(334, 9);
            this.btn_BilgileriGetir.Name = "btn_BilgileriGetir";
            this.btn_BilgileriGetir.Size = new System.Drawing.Size(246, 36);
            this.btn_BilgileriGetir.TabIndex = 14;
            this.btn_BilgileriGetir.Text = "Bilgileri Getir";
            this.btn_BilgileriGetir.UseVisualStyleBackColor = false;
            this.btn_BilgileriGetir.Click += new System.EventHandler(this.btn_BilgileriGetir_Click);
            // 
            // date_Itarih
            // 
            this.date_Itarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_Itarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Itarih.Location = new System.Drawing.Point(162, 122);
            this.date_Itarih.Name = "date_Itarih";
            this.date_Itarih.Size = new System.Drawing.Size(153, 21);
            this.date_Itarih.TabIndex = 5;
            this.date_Itarih.ValueChanged += new System.EventHandler(this.date_Itarih_ValueChanged);
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Saat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Saat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Saat.Location = new System.Drawing.Point(13, 149);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(143, 20);
            this.lbl_Saat.TabIndex = 118;
            this.lbl_Saat.Text = "Saat";
            // 
            // date_Saat
            // 
            this.date_Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_Saat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date_Saat.Location = new System.Drawing.Point(162, 148);
            this.date_Saat.Name = "date_Saat";
            this.date_Saat.Size = new System.Drawing.Size(153, 21);
            this.date_Saat.TabIndex = 6;
            // 
            // timer_bilgi
            // 
            this.timer_bilgi.Tick += new System.EventHandler(this.timer_bilgi_Tick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sil.Location = new System.Drawing.Point(422, 401);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(130, 42);
            this.btn_Sil.TabIndex = 12;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Stok
            // 
            this.btn_Stok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Stok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Stok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Stok.Location = new System.Drawing.Point(334, 106);
            this.btn_Stok.Name = "btn_Stok";
            this.btn_Stok.Size = new System.Drawing.Size(246, 36);
            this.btn_Stok.TabIndex = 16;
            this.btn_Stok.Text = "Stokta Bulunan Kanlar";
            this.btn_Stok.UseVisualStyleBackColor = false;
            this.btn_Stok.Click += new System.EventHandler(this.btn_Stok_Click);
            // 
            // frm_KanGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Stok);
            this.Controls.Add(this.btn_BilgileriGetir);
            this.Controls.Add(this.btn_ikontrol);
            this.Controls.Add(this.lbl_Skt);
            this.Controls.Add(this.txt_Skt);
            this.Controls.Add(this.btn_Yazdir);
            this.Controls.Add(this.lbl_DonorİslemNo);
            this.Controls.Add(this.lbl_BarkodNumarasi);
            this.Controls.Add(this.date_Saat);
            this.Controls.Add(this.date_Itarih);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_Saat);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.lbl_Itarih);
            this.Controls.Add(this.lbl_KanGrubu);
            this.Controls.Add(this.txt_KanGrubu);
            this.Controls.Add(this.txt_saat);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.txt_KayitYapan);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_Barkod);
            this.Controls.Add(this.txt_DonorIslemNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DonorNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_KanGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAN GİRİŞ";
            this.Load += new System.EventHandler(this.frm_KanGirisFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DonorIslemNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DonorNo;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.TextBox txt_ad;
        public System.Windows.Forms.TextBox txt_saat;
        public System.Windows.Forms.TextBox txt_tarih;
        public System.Windows.Forms.TextBox txt_KayitYapan;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_KanGrubu;
        private System.Windows.Forms.TextBox txt_KanGrubu;
        private System.Windows.Forms.Label lbl_Itarih;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Label lbl_DonorİslemNo;
        private System.Windows.Forms.Button btn_Yazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_Skt;
        private System.Windows.Forms.TextBox txt_Skt;
        private System.Windows.Forms.Label lbl_Barkod;
        private System.Windows.Forms.Label lbl_BarkodNumarasi;
        private System.Windows.Forms.Button btn_ikontrol;
        private System.Windows.Forms.Button btn_BilgileriGetir;
        private System.Windows.Forms.DateTimePicker date_Itarih;
        private System.Windows.Forms.Label lbl_Saat;
        private System.Windows.Forms.DateTimePicker date_Saat;
        private System.Windows.Forms.Timer timer_bilgi;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Stok;
    }
}