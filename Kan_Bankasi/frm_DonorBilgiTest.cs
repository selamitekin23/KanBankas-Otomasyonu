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
    public partial class frm_DonorBilgiTest : Form
    {
        public frm_DonorBilgiTest()
        {
            InitializeComponent();
        }
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        cls_Testler testler_sinifi = new cls_Testler();
        string mesaj;
        DateTime zaman;
        private void frm_Donor_bilgi_formu_Load(object sender, EventArgs e)
        {
            frm_DonorKayitGirisi donor_giris_formu = (frm_DonorKayitGirisi)Application.OpenForms["frm_DonorKayitGirisi"];
            testler_sinifi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            timer_bilgi.Enabled = true;
            testler_sinifi.tc_no_kontrol(Convert.ToDouble(donor_giris_formu.tc_no));
            txt_DonorNo.Text = Convert.ToString(testler_sinifi.donor_numarasi);
            txt_ad.Text = testler_sinifi.ad;
            txt_soyad.Text = testler_sinifi.soyad;
            mesaj = testler_sinifi.donor_islem_no_olustur("DonorBilgiTest");
            if (mesaj == "")
            {
                txt_DonorIslemNO.Text = Convert.ToString(testler_sinifi.donor_islem_numarasi);
                txt_KayitYapan.Text = testler_sinifi.KullaniciBul(kullanici_giris_formu.kullanici_adi);
            }
            else
            {
                MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                donor_giris_formu.Show();
                this.Close();
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_DonorKayitGirisi donor_giris_formu = (frm_DonorKayitGirisi)Application.OpenForms["frm_DonorKayitGirisi"];
            donor_giris_formu.Show();
            this.Hide();
        }

        private void btn_TesteBasla_Click(object sender, EventArgs e)
        {
            frm_DonorSoruCevapla SoruCevaplama = new frm_DonorSoruCevapla();
            SoruCevaplama.donorno = Convert.ToDouble(txt_DonorNo.Text);
            SoruCevaplama.donorislemno = Convert.ToDouble(txt_DonorIslemNO.Text);
            this.Hide();
            SoruCevaplama.Show();
        }

        private void timer_bilgi_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            txt_tarih.Text = String.Format("{0:d}", zaman);
            txt_saat.Text = String.Format("{0:t}", zaman);
        }
    }
}
