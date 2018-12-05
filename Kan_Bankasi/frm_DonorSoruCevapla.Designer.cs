namespace Kan_Bankasi
{
    partial class frm_DonorSoruCevapla
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
            this.lbl_soru_no = new System.Windows.Forms.Label();
            this.lbl_soru = new System.Windows.Forms.Label();
            this.btn_Hayir = new System.Windows.Forms.Button();
            this.btn_Evet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_soru_no
            // 
            this.lbl_soru_no.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_soru_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soru_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru_no.Location = new System.Drawing.Point(12, 19);
            this.lbl_soru_no.Name = "lbl_soru_no";
            this.lbl_soru_no.Size = new System.Drawing.Size(80, 83);
            this.lbl_soru_no.TabIndex = 8;
            this.lbl_soru_no.Text = "SORU:";
            this.lbl_soru_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_soru
            // 
            this.lbl_soru.BackColor = System.Drawing.Color.White;
            this.lbl_soru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru.Location = new System.Drawing.Point(98, 19);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(625, 83);
            this.lbl_soru.TabIndex = 9;
            // 
            // btn_Hayir
            // 
            this.btn_Hayir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hayir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hayir.Image = global::Kan_Bankasi.Properties.Resources.hayir;
            this.btn_Hayir.Location = new System.Drawing.Point(542, 147);
            this.btn_Hayir.Name = "btn_Hayir";
            this.btn_Hayir.Size = new System.Drawing.Size(181, 185);
            this.btn_Hayir.TabIndex = 2;
            this.btn_Hayir.UseVisualStyleBackColor = true;
            this.btn_Hayir.Click += new System.EventHandler(this.btn_Hayir_Click);
            // 
            // btn_Evet
            // 
            this.btn_Evet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Evet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Evet.Image = global::Kan_Bankasi.Properties.Resources.evet;
            this.btn_Evet.Location = new System.Drawing.Point(98, 147);
            this.btn_Evet.Name = "btn_Evet";
            this.btn_Evet.Size = new System.Drawing.Size(181, 185);
            this.btn_Evet.TabIndex = 1;
            this.btn_Evet.UseVisualStyleBackColor = true;
            this.btn_Evet.Click += new System.EventHandler(this.btn_Evet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Kan_Bankasi.Properties.Resources.evet_hayir1;
            this.pictureBox1.Location = new System.Drawing.Point(354, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 278);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DonorSoruCevapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Hayir);
            this.Controls.Add(this.btn_Evet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_soru);
            this.Controls.Add(this.lbl_soru_no);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DonorSoruCevapla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORU CEVAPLAMA";
            this.Load += new System.EventHandler(this.frm_DonorSoruCevapla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_soru_no;
        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Evet;
        private System.Windows.Forms.Button btn_Hayir;

    }
}