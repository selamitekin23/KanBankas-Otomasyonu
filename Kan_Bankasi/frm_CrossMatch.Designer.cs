namespace Kan_Bankasi
{
    partial class frm_CrossMatch
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
            this.dtg_kanlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KanArama = new System.Windows.Forms.Button();
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Saat = new System.Windows.Forms.TextBox();
            this.txt_Tarih = new System.Windows.Forms.TextBox();
            this.txt_KayitYapan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_DonorKanGrubu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DonorIslemNo = new System.Windows.Forms.TextBox();
            this.txt_Dad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Dsoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_HastaKanGrubu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_doktor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_polikilinik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_hastaislemno = new System.Windows.Forms.TextBox();
            this.txt_Had = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Hsoyad = new System.Windows.Forms.TextBox();
            this.timer_bilgi = new System.Windows.Forms.Timer(this.components);
            this.btn_TumKanlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_kanlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_kanlar
            // 
            this.dtg_kanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_kanlar.Location = new System.Drawing.Point(1, 233);
            this.dtg_kanlar.Name = "dtg_kanlar";
            this.dtg_kanlar.Size = new System.Drawing.Size(717, 150);
            this.dtg_kanlar.TabIndex = 125;
            this.dtg_kanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_kanlar_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "STOK\'TA BULUNAN UYGUN KANLAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_KanArama
            // 
            this.btn_KanArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KanArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KanArama.ForeColor = System.Drawing.Color.White;
            this.btn_KanArama.Location = new System.Drawing.Point(12, 175);
            this.btn_KanArama.Name = "btn_KanArama";
            this.btn_KanArama.Size = new System.Drawing.Size(330, 35);
            this.btn_KanArama.TabIndex = 7;
            this.btn_KanArama.Text = "UYGUN KAN ARAMA";
            this.btn_KanArama.UseVisualStyleBackColor = false;
            this.btn_KanArama.Click += new System.EventHandler(this.btn_KanArama_Click);
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Onayla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Onayla.Location = new System.Drawing.Point(4, 530);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(338, 40);
            this.btn_Onayla.TabIndex = 13;
            this.btn_Onayla.Text = "ONAYLA";
            this.btn_Onayla.UseVisualStyleBackColor = false;
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Geri.Location = new System.Drawing.Point(368, 529);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(344, 43);
            this.btn_Geri.TabIndex = 14;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.MidnightBlue;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(530, 590);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(188, 17);
            this.label22.TabIndex = 156;
            this.label22.Text = "Saat";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.MidnightBlue;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(300, 590);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(231, 17);
            this.label20.TabIndex = 155;
            this.label20.Text = "Tarih";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.MidnightBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Location = new System.Drawing.Point(1, 590);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(302, 17);
            this.label25.TabIndex = 153;
            this.label25.Text = "Kayıt Yapan";
            // 
            // txt_Saat
            // 
            this.txt_Saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Saat.Location = new System.Drawing.Point(530, 607);
            this.txt_Saat.Name = "txt_Saat";
            this.txt_Saat.Size = new System.Drawing.Size(188, 20);
            this.txt_Saat.TabIndex = 154;
            // 
            // txt_Tarih
            // 
            this.txt_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Tarih.Location = new System.Drawing.Point(300, 607);
            this.txt_Tarih.Name = "txt_Tarih";
            this.txt_Tarih.Size = new System.Drawing.Size(231, 20);
            this.txt_Tarih.TabIndex = 151;
            // 
            // txt_KayitYapan
            // 
            this.txt_KayitYapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KayitYapan.Location = new System.Drawing.Point(1, 607);
            this.txt_KayitYapan.Name = "txt_KayitYapan";
            this.txt_KayitYapan.Size = new System.Drawing.Size(302, 20);
            this.txt_KayitYapan.TabIndex = 152;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_DonorKanGrubu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_DonorIslemNo);
            this.groupBox1.Controls.Add(this.txt_Dad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_Dsoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(4, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 125);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEÇİLEN KAN";
            // 
            // lbl_DonorKanGrubu
            // 
            this.lbl_DonorKanGrubu.BackColor = System.Drawing.Color.White;
            this.lbl_DonorKanGrubu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DonorKanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DonorKanGrubu.ForeColor = System.Drawing.Color.Red;
            this.lbl_DonorKanGrubu.Location = new System.Drawing.Point(437, 48);
            this.lbl_DonorKanGrubu.Name = "lbl_DonorKanGrubu";
            this.lbl_DonorKanGrubu.Size = new System.Drawing.Size(260, 70);
            this.lbl_DonorKanGrubu.TabIndex = 12;
            this.lbl_DonorKanGrubu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 114;
            this.label5.Text = "Donör İşlem Numarası";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(437, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 23);
            this.label6.TabIndex = 121;
            this.label6.Text = "Kan Grubu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DonorIslemNo
            // 
            this.txt_DonorIslemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonorIslemNo.Enabled = false;
            this.txt_DonorIslemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DonorIslemNo.Location = new System.Drawing.Point(171, 29);
            this.txt_DonorIslemNo.Name = "txt_DonorIslemNo";
            this.txt_DonorIslemNo.Size = new System.Drawing.Size(110, 20);
            this.txt_DonorIslemNo.TabIndex = 9;
            // 
            // txt_Dad
            // 
            this.txt_Dad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dad.Enabled = false;
            this.txt_Dad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Dad.Location = new System.Drawing.Point(171, 59);
            this.txt_Dad.Name = "txt_Dad";
            this.txt_Dad.Size = new System.Drawing.Size(249, 20);
            this.txt_Dad.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(9, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 119;
            this.label12.Text = "Soyad";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(9, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 20);
            this.label13.TabIndex = 117;
            this.label13.Text = "Ad";
            // 
            // txt_Dsoyad
            // 
            this.txt_Dsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dsoyad.Enabled = false;
            this.txt_Dsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Dsoyad.Location = new System.Drawing.Point(171, 85);
            this.txt_Dsoyad.Name = "txt_Dsoyad";
            this.txt_Dsoyad.Size = new System.Drawing.Size(249, 20);
            this.txt_Dsoyad.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_HastaKanGrubu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_doktor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_polikilinik);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_hastaislemno);
            this.groupBox2.Controls.Add(this.txt_Had);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Hsoyad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 166);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HASTA BİLGİLERİ";
            // 
            // lbl_HastaKanGrubu
            // 
            this.lbl_HastaKanGrubu.BackColor = System.Drawing.Color.White;
            this.lbl_HastaKanGrubu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_HastaKanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HastaKanGrubu.ForeColor = System.Drawing.Color.Red;
            this.lbl_HastaKanGrubu.Location = new System.Drawing.Point(428, 79);
            this.lbl_HastaKanGrubu.Name = "lbl_HastaKanGrubu";
            this.lbl_HastaKanGrubu.Size = new System.Drawing.Size(260, 70);
            this.lbl_HastaKanGrubu.TabIndex = 6;
            this.lbl_HastaKanGrubu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 128;
            this.label11.Text = "Doktor";
            // 
            // txt_doktor
            // 
            this.txt_doktor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_doktor.Location = new System.Drawing.Point(170, 129);
            this.txt_doktor.Name = "txt_doktor";
            this.txt_doktor.Size = new System.Drawing.Size(249, 20);
            this.txt_doktor.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 20);
            this.label10.TabIndex = 126;
            this.label10.Text = "Polikilinik";
            // 
            // txt_polikilinik
            // 
            this.txt_polikilinik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_polikilinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_polikilinik.Location = new System.Drawing.Point(170, 103);
            this.txt_polikilinik.Name = "txt_polikilinik";
            this.txt_polikilinik.Size = new System.Drawing.Size(249, 20);
            this.txt_polikilinik.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 118;
            this.label8.Text = "Hasta İşlem Numarası";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(428, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 29);
            this.label9.TabIndex = 125;
            this.label9.Text = "Hasta Kan Grubu";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_hastaislemno
            // 
            this.txt_hastaislemno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hastaislemno.Enabled = false;
            this.txt_hastaislemno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hastaislemno.Location = new System.Drawing.Point(170, 20);
            this.txt_hastaislemno.Name = "txt_hastaislemno";
            this.txt_hastaislemno.Size = new System.Drawing.Size(110, 20);
            this.txt_hastaislemno.TabIndex = 1;
            // 
            // txt_Had
            // 
            this.txt_Had.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Had.Enabled = false;
            this.txt_Had.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Had.Location = new System.Drawing.Point(170, 47);
            this.txt_Had.Name = "txt_Had";
            this.txt_Had.Size = new System.Drawing.Size(249, 20);
            this.txt_Had.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "Soyad";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 121;
            this.label7.Text = "Ad";
            // 
            // txt_Hsoyad
            // 
            this.txt_Hsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Hsoyad.Enabled = false;
            this.txt_Hsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Hsoyad.Location = new System.Drawing.Point(170, 73);
            this.txt_Hsoyad.Name = "txt_Hsoyad";
            this.txt_Hsoyad.Size = new System.Drawing.Size(249, 20);
            this.txt_Hsoyad.TabIndex = 3;
            // 
            // timer_bilgi
            // 
            this.timer_bilgi.Tick += new System.EventHandler(this.timer_bilgi_Tick);
            // 
            // btn_TumKanlar
            // 
            this.btn_TumKanlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TumKanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TumKanlar.ForeColor = System.Drawing.Color.White;
            this.btn_TumKanlar.Location = new System.Drawing.Point(371, 175);
            this.btn_TumKanlar.Name = "btn_TumKanlar";
            this.btn_TumKanlar.Size = new System.Drawing.Size(330, 35);
            this.btn_TumKanlar.TabIndex = 8;
            this.btn_TumKanlar.Text = "TÜM KANLAR";
            this.btn_TumKanlar.UseVisualStyleBackColor = false;
            this.btn_TumKanlar.Click += new System.EventHandler(this.btn_TumKanlar_Click);
            // 
            // frm_CrossMatch
            // 
            this.AcceptButton = this.btn_KanArama;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Geri;
            this.ClientSize = new System.Drawing.Size(719, 624);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TumKanlar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt_Saat);
            this.Controls.Add(this.txt_Tarih);
            this.Controls.Add(this.txt_KayitYapan);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_KanArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_kanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_CrossMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAN ARAMA";
            this.Load += new System.EventHandler(this.frm_CrossMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_kanlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_kanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KanArama;
        private System.Windows.Forms.Button btn_Onayla;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_Saat;
        private System.Windows.Forms.TextBox txt_Tarih;
        private System.Windows.Forms.TextBox txt_KayitYapan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DonorIslemNo;
        private System.Windows.Forms.TextBox txt_Dad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Dsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_doktor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_polikilinik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_hastaislemno;
        public System.Windows.Forms.TextBox txt_Had;
        public System.Windows.Forms.TextBox txt_Hsoyad;
        private System.Windows.Forms.Timer timer_bilgi;
        public System.Windows.Forms.Label lbl_HastaKanGrubu;
        public System.Windows.Forms.Label lbl_DonorKanGrubu;
        private System.Windows.Forms.Button btn_TumKanlar;
    }
}