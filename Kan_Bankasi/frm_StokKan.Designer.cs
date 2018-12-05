namespace Kan_Bankasi
{
    partial class frm_StokKan
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
            this.dtg_kan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_kan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_kan
            // 
            this.dtg_kan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_kan.Location = new System.Drawing.Point(12, 30);
            this.dtg_kan.Name = "dtg_kan";
            this.dtg_kan.Size = new System.Drawing.Size(600, 217);
            this.dtg_kan.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "STOKTA BULUNAN KAN KAYITLARI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Geri.Location = new System.Drawing.Point(12, 253);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(600, 31);
            this.btn_Geri.TabIndex = 48;
            this.btn_Geri.Text = "GERİ";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // frm_StokKan
            // 
            this.AcceptButton = this.btn_Geri;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Geri;
            this.ClientSize = new System.Drawing.Size(634, 288);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_kan);
            this.Name = "frm_StokKan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK KAN";
            this.Load += new System.EventHandler(this.frm_StokKan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_kan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_kan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Geri;
    }
}