namespace Kan_Bankasi
{
    partial class frm_DonorIslemNumarasıKontrol
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
            this.dtg_Kanlar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DonorNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Kanlar
            // 
            this.dtg_Kanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Kanlar.Location = new System.Drawing.Point(12, 78);
            this.dtg_Kanlar.Name = "dtg_Kanlar";
            this.dtg_Kanlar.Size = new System.Drawing.Size(614, 172);
            this.dtg_Kanlar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Donör No";
            // 
            // txt_DonorNo
            // 
            this.txt_DonorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DonorNo.ForeColor = System.Drawing.Color.Black;
            this.txt_DonorNo.Location = new System.Drawing.Point(158, 12);
            this.txt_DonorNo.Name = "txt_DonorNo";
            this.txt_DonorNo.Size = new System.Drawing.Size(154, 20);
            this.txt_DonorNo.TabIndex = 1;
            this.txt_DonorNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DonorNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonorNo_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "KAN GİRİŞİ YAPILMAMIŞ DONÖR KAYITLARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Bul
            // 
            this.btn_Bul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Bul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Bul.Location = new System.Drawing.Point(333, 4);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(130, 30);
            this.btn_Bul.TabIndex = 2;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = false;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Geri.Location = new System.Drawing.Point(12, 256);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(614, 33);
            this.btn_Geri.TabIndex = 3;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_DonorIslemNumarasıKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 301);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DonorNo);
            this.Controls.Add(this.dtg_Kanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_DonorIslemNumarasıKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONÖR İŞLEM NUMARASI KONTROL";
            this.Load += new System.EventHandler(this.frm_DonorIslemNumarasıKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Kanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Kanlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DonorNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Button btn_Geri;
    }
}