namespace Kan_Bankasi
{
    partial class frm_Sorgulamalar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_hasta = new System.Windows.Forms.TabPage();
            this.btn_HkangrubuAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Hkangrubu = new System.Windows.Forms.ComboBox();
            this.btn_HtumKayitlar = new System.Windows.Forms.Button();
            this.btn_HtcnoAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Htcno = new System.Windows.Forms.TextBox();
            this.dtg_hasta = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DkanGrubu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_DkanGrubu = new System.Windows.Forms.ComboBox();
            this.btn_DtumKayitlar = new System.Windows.Forms.Button();
            this.btn_Dara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DtcNo = new System.Windows.Forms.TextBox();
            this.dtg_Donor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnKanARAcmb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKkanGrubu = new System.Windows.Forms.ComboBox();
            this.btn_KanTumKayit = new System.Windows.Forms.Button();
            this.btnKanAraDonorNo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KdonorNo = new System.Windows.Forms.TextBox();
            this.dtg_Kan = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_StokCikisKangrubuAra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_StokCikisKanGrubu = new System.Windows.Forms.ComboBox();
            this.btn_StokCikisTumKayitlar = new System.Windows.Forms.Button();
            this.btn_StokCikisAraTc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_StokCikisTC = new System.Windows.Forms.TextBox();
            this.dtg_StokCikis = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TumKullanıcılar = new System.Windows.Forms.Button();
            this.btn_KullaniciBul = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_KullaniciTCno = new System.Windows.Forms.TextBox();
            this.dtg_Kullanicilar = new System.Windows.Forms.DataGridView();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_hasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hasta)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Donor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kan)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_StokCikis)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_hasta);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 436);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_hasta
            // 
            this.tab_hasta.Controls.Add(this.btn_HkangrubuAra);
            this.tab_hasta.Controls.Add(this.label1);
            this.tab_hasta.Controls.Add(this.cmb_Hkangrubu);
            this.tab_hasta.Controls.Add(this.btn_HtumKayitlar);
            this.tab_hasta.Controls.Add(this.btn_HtcnoAra);
            this.tab_hasta.Controls.Add(this.label2);
            this.tab_hasta.Controls.Add(this.txt_Htcno);
            this.tab_hasta.Controls.Add(this.dtg_hasta);
            this.tab_hasta.Location = new System.Drawing.Point(4, 22);
            this.tab_hasta.Name = "tab_hasta";
            this.tab_hasta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hasta.Size = new System.Drawing.Size(736, 410);
            this.tab_hasta.TabIndex = 0;
            this.tab_hasta.Text = "HASTA BİLGİLERİ";
            this.tab_hasta.UseVisualStyleBackColor = true;
            this.tab_hasta.Click += new System.EventHandler(this.tab_hasta_Click);
            this.tab_hasta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_hasta_MouseClick);
            // 
            // btn_HkangrubuAra
            // 
            this.btn_HkangrubuAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HkangrubuAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HkangrubuAra.ForeColor = System.Drawing.Color.White;
            this.btn_HkangrubuAra.Location = new System.Drawing.Point(331, 47);
            this.btn_HkangrubuAra.Name = "btn_HkangrubuAra";
            this.btn_HkangrubuAra.Size = new System.Drawing.Size(148, 31);
            this.btn_HkangrubuAra.TabIndex = 96;
            this.btn_HkangrubuAra.Text = "ARA";
            this.btn_HkangrubuAra.UseVisualStyleBackColor = false;
            this.btn_HkangrubuAra.Click += new System.EventHandler(this.btn_HkangrubuAra_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Kan Grubu";
            // 
            // cmb_Hkangrubu
            // 
            this.cmb_Hkangrubu.FormattingEnabled = true;
            this.cmb_Hkangrubu.Location = new System.Drawing.Point(185, 52);
            this.cmb_Hkangrubu.Name = "cmb_Hkangrubu";
            this.cmb_Hkangrubu.Size = new System.Drawing.Size(140, 21);
            this.cmb_Hkangrubu.TabIndex = 94;
            // 
            // btn_HtumKayitlar
            // 
            this.btn_HtumKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HtumKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HtumKayitlar.ForeColor = System.Drawing.Color.White;
            this.btn_HtumKayitlar.Location = new System.Drawing.Point(485, 10);
            this.btn_HtumKayitlar.Name = "btn_HtumKayitlar";
            this.btn_HtumKayitlar.Size = new System.Drawing.Size(148, 31);
            this.btn_HtumKayitlar.TabIndex = 93;
            this.btn_HtumKayitlar.Text = "TÜM KAYITLAR";
            this.btn_HtumKayitlar.UseVisualStyleBackColor = false;
            this.btn_HtumKayitlar.Click += new System.EventHandler(this.btn_HtumKayitlar_Click);
            // 
            // btn_HtcnoAra
            // 
            this.btn_HtcnoAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HtcnoAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HtcnoAra.ForeColor = System.Drawing.Color.White;
            this.btn_HtcnoAra.Location = new System.Drawing.Point(331, 10);
            this.btn_HtcnoAra.Name = "btn_HtcnoAra";
            this.btn_HtcnoAra.Size = new System.Drawing.Size(148, 31);
            this.btn_HtcnoAra.TabIndex = 92;
            this.btn_HtcnoAra.Text = "ARA";
            this.btn_HtcnoAra.UseVisualStyleBackColor = false;
            this.btn_HtcnoAra.Click += new System.EventHandler(this.btn_HtcnoAra_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tc Numarası";
            // 
            // txt_Htcno
            // 
            this.txt_Htcno.Location = new System.Drawing.Point(185, 17);
            this.txt_Htcno.Name = "txt_Htcno";
            this.txt_Htcno.Size = new System.Drawing.Size(140, 20);
            this.txt_Htcno.TabIndex = 90;
            this.txt_Htcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Htcno_KeyPress);
            // 
            // dtg_hasta
            // 
            this.dtg_hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hasta.Location = new System.Drawing.Point(6, 123);
            this.dtg_hasta.Name = "dtg_hasta";
            this.dtg_hasta.Size = new System.Drawing.Size(724, 259);
            this.dtg_hasta.TabIndex = 89;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_DkanGrubu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmb_DkanGrubu);
            this.tabPage2.Controls.Add(this.btn_DtumKayitlar);
            this.tabPage2.Controls.Add(this.btn_Dara);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_DtcNo);
            this.tabPage2.Controls.Add(this.dtg_Donor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DONÖR BİLGİLERİ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DkanGrubu
            // 
            this.btn_DkanGrubu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DkanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DkanGrubu.ForeColor = System.Drawing.Color.White;
            this.btn_DkanGrubu.Location = new System.Drawing.Point(331, 47);
            this.btn_DkanGrubu.Name = "btn_DkanGrubu";
            this.btn_DkanGrubu.Size = new System.Drawing.Size(148, 31);
            this.btn_DkanGrubu.TabIndex = 88;
            this.btn_DkanGrubu.Text = "ARA";
            this.btn_DkanGrubu.UseVisualStyleBackColor = false;
            this.btn_DkanGrubu.Click += new System.EventHandler(this.btn_DkanGrubu_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Kan Grubu";
            // 
            // cmb_DkanGrubu
            // 
            this.cmb_DkanGrubu.FormattingEnabled = true;
            this.cmb_DkanGrubu.Location = new System.Drawing.Point(185, 52);
            this.cmb_DkanGrubu.Name = "cmb_DkanGrubu";
            this.cmb_DkanGrubu.Size = new System.Drawing.Size(140, 21);
            this.cmb_DkanGrubu.TabIndex = 86;
            // 
            // btn_DtumKayitlar
            // 
            this.btn_DtumKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DtumKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DtumKayitlar.ForeColor = System.Drawing.Color.White;
            this.btn_DtumKayitlar.Location = new System.Drawing.Point(485, 10);
            this.btn_DtumKayitlar.Name = "btn_DtumKayitlar";
            this.btn_DtumKayitlar.Size = new System.Drawing.Size(148, 31);
            this.btn_DtumKayitlar.TabIndex = 85;
            this.btn_DtumKayitlar.Text = "TÜM KAYITLAR";
            this.btn_DtumKayitlar.UseVisualStyleBackColor = false;
            this.btn_DtumKayitlar.Click += new System.EventHandler(this.btn_DtumKayitlar_Click);
            // 
            // btn_Dara
            // 
            this.btn_Dara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Dara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dara.ForeColor = System.Drawing.Color.White;
            this.btn_Dara.Location = new System.Drawing.Point(331, 10);
            this.btn_Dara.Name = "btn_Dara";
            this.btn_Dara.Size = new System.Drawing.Size(148, 31);
            this.btn_Dara.TabIndex = 84;
            this.btn_Dara.Text = "ARA";
            this.btn_Dara.UseVisualStyleBackColor = false;
            this.btn_Dara.Click += new System.EventHandler(this.btn_Dara_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "Tc Numarası";
            // 
            // txt_DtcNo
            // 
            this.txt_DtcNo.Location = new System.Drawing.Point(185, 17);
            this.txt_DtcNo.Name = "txt_DtcNo";
            this.txt_DtcNo.Size = new System.Drawing.Size(140, 20);
            this.txt_DtcNo.TabIndex = 82;
            this.txt_DtcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DtcNo_KeyPress);
            // 
            // dtg_Donor
            // 
            this.dtg_Donor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Donor.Location = new System.Drawing.Point(6, 123);
            this.dtg_Donor.Name = "dtg_Donor";
            this.dtg_Donor.Size = new System.Drawing.Size(724, 259);
            this.dtg_Donor.TabIndex = 81;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnKanARAcmb);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbKkanGrubu);
            this.tabPage3.Controls.Add(this.btn_KanTumKayit);
            this.tabPage3.Controls.Add(this.btnKanAraDonorNo);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txt_KdonorNo);
            this.tabPage3.Controls.Add(this.dtg_Kan);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(736, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "KAN STOK";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnKanARAcmb
            // 
            this.btnKanARAcmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKanARAcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKanARAcmb.ForeColor = System.Drawing.Color.White;
            this.btnKanARAcmb.Location = new System.Drawing.Point(331, 47);
            this.btnKanARAcmb.Name = "btnKanARAcmb";
            this.btnKanARAcmb.Size = new System.Drawing.Size(148, 31);
            this.btnKanARAcmb.TabIndex = 97;
            this.btnKanARAcmb.Text = "ARA";
            this.btnKanARAcmb.UseVisualStyleBackColor = false;
            this.btnKanARAcmb.Click += new System.EventHandler(this.btnKanARAcmb_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Kan Grubu";
            // 
            // cmbKkanGrubu
            // 
            this.cmbKkanGrubu.FormattingEnabled = true;
            this.cmbKkanGrubu.Location = new System.Drawing.Point(185, 52);
            this.cmbKkanGrubu.Name = "cmbKkanGrubu";
            this.cmbKkanGrubu.Size = new System.Drawing.Size(140, 21);
            this.cmbKkanGrubu.TabIndex = 95;
            // 
            // btn_KanTumKayit
            // 
            this.btn_KanTumKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KanTumKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KanTumKayit.ForeColor = System.Drawing.Color.White;
            this.btn_KanTumKayit.Location = new System.Drawing.Point(485, 10);
            this.btn_KanTumKayit.Name = "btn_KanTumKayit";
            this.btn_KanTumKayit.Size = new System.Drawing.Size(148, 31);
            this.btn_KanTumKayit.TabIndex = 94;
            this.btn_KanTumKayit.Text = "TÜM KAYITLAR";
            this.btn_KanTumKayit.UseVisualStyleBackColor = false;
            this.btn_KanTumKayit.Click += new System.EventHandler(this.btn_KanTumKayit_Click);
            // 
            // btnKanAraDonorNo
            // 
            this.btnKanAraDonorNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKanAraDonorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKanAraDonorNo.ForeColor = System.Drawing.Color.White;
            this.btnKanAraDonorNo.Location = new System.Drawing.Point(331, 10);
            this.btnKanAraDonorNo.Name = "btnKanAraDonorNo";
            this.btnKanAraDonorNo.Size = new System.Drawing.Size(148, 31);
            this.btnKanAraDonorNo.TabIndex = 93;
            this.btnKanAraDonorNo.Text = "ARA";
            this.btnKanAraDonorNo.UseVisualStyleBackColor = false;
            this.btnKanAraDonorNo.Click += new System.EventHandler(this.btnKanAraDonorNo_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Donör No";
            // 
            // txt_KdonorNo
            // 
            this.txt_KdonorNo.Location = new System.Drawing.Point(185, 17);
            this.txt_KdonorNo.Name = "txt_KdonorNo";
            this.txt_KdonorNo.Size = new System.Drawing.Size(140, 20);
            this.txt_KdonorNo.TabIndex = 91;
            this.txt_KdonorNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KdonorNo_KeyPress);
            // 
            // dtg_Kan
            // 
            this.dtg_Kan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Kan.Location = new System.Drawing.Point(6, 123);
            this.dtg_Kan.Name = "dtg_Kan";
            this.dtg_Kan.Size = new System.Drawing.Size(724, 259);
            this.dtg_Kan.TabIndex = 90;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_StokCikisKangrubuAra);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmb_StokCikisKanGrubu);
            this.tabPage1.Controls.Add(this.btn_StokCikisTumKayitlar);
            this.tabPage1.Controls.Add(this.btn_StokCikisAraTc);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_StokCikisTC);
            this.tabPage1.Controls.Add(this.dtg_StokCikis);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 410);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "STOK ÇIKIŞ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_StokCikisKangrubuAra
            // 
            this.btn_StokCikisKangrubuAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StokCikisKangrubuAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_StokCikisKangrubuAra.ForeColor = System.Drawing.Color.White;
            this.btn_StokCikisKangrubuAra.Location = new System.Drawing.Point(331, 47);
            this.btn_StokCikisKangrubuAra.Name = "btn_StokCikisKangrubuAra";
            this.btn_StokCikisKangrubuAra.Size = new System.Drawing.Size(148, 31);
            this.btn_StokCikisKangrubuAra.TabIndex = 105;
            this.btn_StokCikisKangrubuAra.Text = "ARA";
            this.btn_StokCikisKangrubuAra.UseVisualStyleBackColor = false;
            this.btn_StokCikisKangrubuAra.Click += new System.EventHandler(this.btn_StokCikisKangrubuAra_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "Kan Grubu";
            // 
            // cmb_StokCikisKanGrubu
            // 
            this.cmb_StokCikisKanGrubu.FormattingEnabled = true;
            this.cmb_StokCikisKanGrubu.Location = new System.Drawing.Point(185, 52);
            this.cmb_StokCikisKanGrubu.Name = "cmb_StokCikisKanGrubu";
            this.cmb_StokCikisKanGrubu.Size = new System.Drawing.Size(140, 21);
            this.cmb_StokCikisKanGrubu.TabIndex = 103;
            // 
            // btn_StokCikisTumKayitlar
            // 
            this.btn_StokCikisTumKayitlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StokCikisTumKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_StokCikisTumKayitlar.ForeColor = System.Drawing.Color.White;
            this.btn_StokCikisTumKayitlar.Location = new System.Drawing.Point(485, 10);
            this.btn_StokCikisTumKayitlar.Name = "btn_StokCikisTumKayitlar";
            this.btn_StokCikisTumKayitlar.Size = new System.Drawing.Size(148, 31);
            this.btn_StokCikisTumKayitlar.TabIndex = 102;
            this.btn_StokCikisTumKayitlar.Text = "TÜM KAYITLAR";
            this.btn_StokCikisTumKayitlar.UseVisualStyleBackColor = false;
            this.btn_StokCikisTumKayitlar.Click += new System.EventHandler(this.btn_StokCikisTumKayitlar_Click);
            // 
            // btn_StokCikisAraTc
            // 
            this.btn_StokCikisAraTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StokCikisAraTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_StokCikisAraTc.ForeColor = System.Drawing.Color.White;
            this.btn_StokCikisAraTc.Location = new System.Drawing.Point(331, 10);
            this.btn_StokCikisAraTc.Name = "btn_StokCikisAraTc";
            this.btn_StokCikisAraTc.Size = new System.Drawing.Size(148, 31);
            this.btn_StokCikisAraTc.TabIndex = 101;
            this.btn_StokCikisAraTc.Text = "ARA";
            this.btn_StokCikisAraTc.UseVisualStyleBackColor = false;
            this.btn_StokCikisAraTc.Click += new System.EventHandler(this.btn_StokCikisAraTc_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 100;
            this.label8.Text = "Hasta Tc No";
            // 
            // txt_StokCikisTC
            // 
            this.txt_StokCikisTC.Location = new System.Drawing.Point(185, 17);
            this.txt_StokCikisTC.Name = "txt_StokCikisTC";
            this.txt_StokCikisTC.Size = new System.Drawing.Size(140, 20);
            this.txt_StokCikisTC.TabIndex = 99;
            this.txt_StokCikisTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StokCikisTC_KeyPress);
            // 
            // dtg_StokCikis
            // 
            this.dtg_StokCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_StokCikis.Location = new System.Drawing.Point(6, 123);
            this.dtg_StokCikis.Name = "dtg_StokCikis";
            this.dtg_StokCikis.Size = new System.Drawing.Size(724, 259);
            this.dtg_StokCikis.TabIndex = 98;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.btn_TumKullanıcılar);
            this.tabPage4.Controls.Add(this.btn_KullaniciBul);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txt_KullaniciTCno);
            this.tabPage4.Controls.Add(this.dtg_Kullanicilar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(736, 410);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "KULLANICI KAYITLARI";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(724, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "KULLANICI KAYITLARI";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TumKullanıcılar
            // 
            this.btn_TumKullanıcılar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TumKullanıcılar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TumKullanıcılar.ForeColor = System.Drawing.Color.White;
            this.btn_TumKullanıcılar.Location = new System.Drawing.Point(484, 13);
            this.btn_TumKullanıcılar.Name = "btn_TumKullanıcılar";
            this.btn_TumKullanıcılar.Size = new System.Drawing.Size(148, 31);
            this.btn_TumKullanıcılar.TabIndex = 110;
            this.btn_TumKullanıcılar.Text = "TÜM KAYITLAR";
            this.btn_TumKullanıcılar.UseVisualStyleBackColor = false;
            this.btn_TumKullanıcılar.Click += new System.EventHandler(this.btn_TumKullanıcılar_Click);
            // 
            // btn_KullaniciBul
            // 
            this.btn_KullaniciBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KullaniciBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KullaniciBul.ForeColor = System.Drawing.Color.White;
            this.btn_KullaniciBul.Location = new System.Drawing.Point(330, 13);
            this.btn_KullaniciBul.Name = "btn_KullaniciBul";
            this.btn_KullaniciBul.Size = new System.Drawing.Size(148, 31);
            this.btn_KullaniciBul.TabIndex = 109;
            this.btn_KullaniciBul.Text = "ARA";
            this.btn_KullaniciBul.UseVisualStyleBackColor = false;
            this.btn_KullaniciBul.Click += new System.EventHandler(this.btn_KullaniciBul_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "Tc No";
            // 
            // txt_KullaniciTCno
            // 
            this.txt_KullaniciTCno.Location = new System.Drawing.Point(184, 20);
            this.txt_KullaniciTCno.Name = "txt_KullaniciTCno";
            this.txt_KullaniciTCno.Size = new System.Drawing.Size(140, 20);
            this.txt_KullaniciTCno.TabIndex = 107;
            this.txt_KullaniciTCno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KullaniciTCno_KeyPress);
            // 
            // dtg_Kullanicilar
            // 
            this.dtg_Kullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Kullanicilar.Location = new System.Drawing.Point(6, 82);
            this.dtg_Kullanicilar.Name = "dtg_Kullanicilar";
            this.dtg_Kullanicilar.Size = new System.Drawing.Size(724, 259);
            this.dtg_Kullanicilar.TabIndex = 106;
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(5, 438);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(733, 40);
            this.btn_Geri.TabIndex = 81;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_Sorgulamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Sorgulamalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORGULAMA";
            this.Load += new System.EventHandler(this.frm_Sorgulamalar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_hasta.ResumeLayout(false);
            this.tab_hasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hasta)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Donor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kan)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_StokCikis)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_hasta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_DkanGrubu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_DkanGrubu;
        private System.Windows.Forms.Button btn_DtumKayitlar;
        private System.Windows.Forms.Button btn_Dara;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_DtcNo;
        private System.Windows.Forms.DataGridView dtg_Donor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnKanARAcmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKkanGrubu;
        private System.Windows.Forms.Button btn_KanTumKayit;
        private System.Windows.Forms.Button btnKanAraDonorNo;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_KdonorNo;
        private System.Windows.Forms.DataGridView dtg_Kan;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_HkangrubuAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Hkangrubu;
        private System.Windows.Forms.Button btn_HtumKayitlar;
        private System.Windows.Forms.Button btn_HtcnoAra;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Htcno;
        private System.Windows.Forms.DataGridView dtg_hasta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_StokCikisKangrubuAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_StokCikisKanGrubu;
        private System.Windows.Forms.Button btn_StokCikisTumKayitlar;
        private System.Windows.Forms.Button btn_StokCikisAraTc;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_StokCikisTC;
        private System.Windows.Forms.DataGridView dtg_StokCikis;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_TumKullanıcılar;
        private System.Windows.Forms.Button btn_KullaniciBul;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_KullaniciTCno;
        private System.Windows.Forms.DataGridView dtg_Kullanicilar;
    }
}