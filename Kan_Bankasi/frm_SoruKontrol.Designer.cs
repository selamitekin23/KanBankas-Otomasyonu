namespace Kan_Bankasi
{
    partial class frm_SoruKontrol
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
            this.lst_yanlis_sorular = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Olumlu = new System.Windows.Forms.Button();
            this.btn_olumsuz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_yanlis_sorular
            // 
            this.lst_yanlis_sorular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_yanlis_sorular.FormattingEnabled = true;
            this.lst_yanlis_sorular.HorizontalScrollbar = true;
            this.lst_yanlis_sorular.ItemHeight = 15;
            this.lst_yanlis_sorular.Location = new System.Drawing.Point(12, 37);
            this.lst_yanlis_sorular.Name = "lst_yanlis_sorular";
            this.lst_yanlis_sorular.ScrollAlwaysVisible = true;
            this.lst_yanlis_sorular.Size = new System.Drawing.Size(789, 169);
            this.lst_yanlis_sorular.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 27);
            this.label2.TabIndex = 69;
            this.label2.Text = "DONÖR TARAFINDAN CEVAPLANIP SONUÇLARI KONTROL EDİLMESİ GEREKEN SORULAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Olumlu
            // 
            this.btn_Olumlu.BackColor = System.Drawing.Color.Green;
            this.btn_Olumlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Olumlu.ForeColor = System.Drawing.Color.White;
            this.btn_Olumlu.Location = new System.Drawing.Point(12, 216);
            this.btn_Olumlu.Name = "btn_Olumlu";
            this.btn_Olumlu.Size = new System.Drawing.Size(789, 35);
            this.btn_Olumlu.TabIndex = 1;
            this.btn_Olumlu.Text = "OLUMLU (+)";
            this.btn_Olumlu.UseVisualStyleBackColor = false;
            this.btn_Olumlu.Click += new System.EventHandler(this.btn_Olumlu_Click);
            // 
            // btn_olumsuz
            // 
            this.btn_olumsuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_olumsuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_olumsuz.ForeColor = System.Drawing.Color.White;
            this.btn_olumsuz.Location = new System.Drawing.Point(12, 267);
            this.btn_olumsuz.Name = "btn_olumsuz";
            this.btn_olumsuz.Size = new System.Drawing.Size(789, 35);
            this.btn_olumsuz.TabIndex = 2;
            this.btn_olumsuz.Text = "OLUMSUZ (-)";
            this.btn_olumsuz.UseVisualStyleBackColor = false;
            this.btn_olumsuz.Click += new System.EventHandler(this.btn_olumsuz_Click);
            // 
            // frm_SoruKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 314);
            this.ControlBox = false;
            this.Controls.Add(this.btn_olumsuz);
            this.Controls.Add(this.btn_Olumlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_yanlis_sorular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_SoruKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORU KONTROL";
            this.Load += new System.EventHandler(this.frm_SoruKontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_yanlis_sorular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Olumlu;
        private System.Windows.Forms.Button btn_olumsuz;
    }
}