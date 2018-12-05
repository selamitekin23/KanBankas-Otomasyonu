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
    public partial class frm_Ayarlar : Form
    {
        public frm_Ayarlar()
        {
            InitializeComponent();
        }

        private void btn_KullaniciKayit_Click(object sender, EventArgs e)
        {
            frm_KullaniciKayitGiris KullaniciKayit = new frm_KullaniciKayitGiris();
            KullaniciKayit.Show();
            this.Hide();
        }

        private void btn_DonorSoruTanimlama_Click(object sender, EventArgs e)
        {
            frm_DonorAyarSoruTanimlama SoruTanimlama = new frm_DonorAyarSoruTanimlama();
            this.Hide();
            SoruTanimlama.Show();
        }

        private void btn_KanGrubuTanimla_Click(object sender, EventArgs e)
        {
            frm_AyarKanGrubuİsmiGiris KanGrubuTanimla = new frm_AyarKanGrubuİsmiGiris();
            this.Hide();
            KanGrubuTanimla.Show();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaKontrol AnaKontrol = new frm_AnaKontrol();
            this.Close();
            AnaKontrol.Show();
        }

 
    }
}
