using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kan_Bankasi
{
    public partial class frm_AnaKontrol : Form
    {
        public frm_AnaKontrol()
        {
            InitializeComponent();
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            frm_Ayarlar Ayarlar = new frm_Ayarlar();
            this.Hide();
            Ayarlar.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programı Kapatmak İstediğinizden Eminmisiniz ?", "ÇIKIŞ İŞLEMİ", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btn_Donorİslem_Click(object sender, EventArgs e)
        {
            frm_DonorKayitGirisi DonorKayitGirisi = new frm_DonorKayitGirisi();
            this.Hide();
            DonorKayitGirisi.Show();
        }

        private void btn_Donorİslem_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_DonorIslem.BackColor = Color.OrangeRed;
        }

        private void frm_AnaKontrol_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_DonorIslem.BackColor = Color.WhiteSmoke;
            lbl_KanGirisi.BackColor = Color.WhiteSmoke;
            lbl_HastaIslemleri.BackColor = Color.WhiteSmoke;
            lbl_Ayarlar.BackColor = Color.WhiteSmoke;
            lbl_Cikis.BackColor = Color.WhiteSmoke;
            lbl_Sorgulama.BackColor = Color.WhiteSmoke;
        }

        private void btn_KanGirisi_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_KanGirisi.BackColor = Color.OrangeRed;
        }

        private void btn_HastaIslemleri_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_HastaIslemleri.BackColor = Color.OrangeRed;
        }

        private void btn_Ayarlar_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Ayarlar.BackColor = Color.OrangeRed;
        }

        private void btn_Cikis_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Cikis.BackColor = Color.OrangeRed;
        }

        private void btn_KanGirisi_Click(object sender, EventArgs e)
        {
            frm_KanGirisFormu KanGiris = new frm_KanGirisFormu();
            this.Hide();
            KanGiris.Show();
        }

        private void btn_HastaIslemleri_Click(object sender, EventArgs e)
        {
            frm_HastaIslemleri HastaIslemleri = new frm_HastaIslemleri();
            this.Hide();
            HastaIslemleri.Show();
        }

        private void btn_Sorgulama_Click(object sender, EventArgs e)
        {
            frm_Sorgulamalar Sorgu = new frm_Sorgulamalar();
            this.Hide();
            Sorgu.Show();
        }

        private void btn_Sorgulama_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_Sorgulama.BackColor = Color.OrangeRed;
        }     
    }
}
