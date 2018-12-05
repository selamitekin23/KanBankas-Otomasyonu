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
    public partial class frm_DonorFizikIncelemeGiris : Form
    {
        //frm_Donor_girisi donor_giris_formu = (frm_Donor_girisi)Application.OpenForms["frm_Donor_girisi"];
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        frm_DonorKayitGirisi donor_giris_formu = (frm_DonorKayitGirisi)Application.OpenForms["frm_DonorKayitGirisi"];
        cls_Testler testler_sinifi = new cls_Testler();
        DateTime zaman;
        public double donor_no;
        string mesaj;
        public frm_DonorFizikIncelemeGiris()
        {
            InitializeComponent();
        }

        private void frm_Donor_fizik_inceleme_Load(object sender, EventArgs e)
        {
            testler_sinifi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            timer_bilgi.Enabled = true;
            testler_sinifi.tc_no_kontrol(Convert.ToDouble(donor_giris_formu.tc_no));
            txt_DonorNo.Text = Convert.ToString(testler_sinifi.donor_numarasi);
            txt_ad.Text = testler_sinifi.ad;
            txt_soyad.Text = testler_sinifi.soyad;
            mesaj = testler_sinifi.donor_islem_no_olustur("DonörFizikİnceleme");
            if (mesaj == "")
            {
                txt_donorislemno.Text = Convert.ToString(testler_sinifi.donor_islem_numarasi);
                txt_KayitYapan.Text = testler_sinifi.KullaniciBul(kullanici_giris_formu.kullanici_adi);
            }
            else {
                MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                donor_giris_formu.Show();
                this.Close();
            }
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_DonorKayitGirisi donor_giris_formu = (frm_DonorKayitGirisi)Application.OpenForms["frm_DonorKayitGirisi"];
            donor_giris_formu.Show();
            timer_bilgi.Enabled = false;
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_agirlik.Text == "" || txt_ates.Text == "" || txt_boy.Text == "" || txt_hct.Text == "" || txt_hgb.Text == "" || txt_nabiz.Text == "" || txt_plt.Text == "" || txt_TansiyonBuyuk.Text == "" || txt_TansiyonKucuk.Text == "" || txt_wbc.Text == "")
            {
                MessageBox.Show("Tüm bilgileri doldurunuz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    btn_kaydet.Enabled = false;
                    txt_sonuc.Visible = true;
                    if (kan_verme_sonuc() == true)
                    {
                        txt_sonuc.Text = "OLUMLU(+)"; txt_sonuc.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        txt_sonuc.Text = "OLUMSUZ(-)"; txt_sonuc.BackColor = Color.Red;
                    }
                    testler_sinifi.fizik_inceleme_kaydet(Convert.ToDouble(txt_DonorNo.Text), Convert.ToDouble(txt_donorislemno.Text), txt_ad.Text, txt_soyad.Text, Convert.ToDouble(txt_ates.Text), Convert.ToInt32(txt_nabiz.Text), Convert.ToDouble(txt_agirlik.Text), Convert.ToInt32(txt_boy.Text), Convert.ToInt32(txt_TansiyonBuyuk.Text), Convert.ToInt32(txt_TansiyonKucuk.Text), Convert.ToDouble(txt_hct.Text), Convert.ToDouble(txt_hgb.Text), Convert.ToInt32(txt_wbc.Text), Convert.ToInt32(txt_plt.Text), txt_aciklama.Text, txt_sonuc.Text, txt_KayitYapan.Text, txt_tarih.Text, txt_saat.Text);
                    MessageBox.Show("Fizik İnceleme Bilgileri Kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen bilgileri doğru giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception hata) {
                    MessageBox.Show("İstenmiyen bir hata oluştu.Hata:" + hata);
                }
            }
        
        }
        //timer nesne ile saati güncel tutuyoz
        private void timer_bilgi_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            txt_tarih.Text=String.Format("{0:d}", zaman);
            txt_saat.Text=String.Format("{0:t}",zaman);
        }
        public bool kan_verme_sonuc()
        {
            //bu metodun amacı donörden alınan bilgilerle donörün kan verip veremeyeceği kontrol ediliyo
            bool sonuc = true;
            if (Convert.ToInt32(txt_nabiz.Text) < 60 || Convert.ToInt32(txt_nabiz.Text) > 100) //sağlıklı bir insanda nabız 60 ila 100 arasıdır
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_nabiz, "Dakikada 50 – 100 olmalıdır. Bu değerlerin altında veya üstünde ise kan bağışı alınamaz. Ayrıca nabız normal ritimde olmalıdır.");
                
            }
            if (Convert.ToDouble(txt_ates.Text) < 36 || Convert.ToDouble(txt_ates.Text) > 37.8)//sağlıklı bir insanda ateş 36 - 37.8 arasındadır
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_ates, "36 - 37.8 C0 den fazla vücut ısısı olanlar kan bağışlayamaz.");
            }
            if (Convert.ToDouble(txt_agirlik.Text) <= 50)
            {//50 kg altındaki insanlar kan bağışında bulunamaz
                epr_hatagosterme.SetError(txt_agirlik, "50 kg altında olanlar kan bağışı yapamazlar. Ayrıca boyuna göre olması gereken ağırlıktan çok düşük olan kişiler kan bağışında bulunamazlar.");
                sonuc = false;
            }
            if (Convert.ToInt32(txt_TansiyonBuyuk.Text) < 90 || Convert.ToInt32(txt_TansiyonBuyuk.Text) > 180)//Sistolik (büyük) tansiyon 90 – 180 mmHg arasında 
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_TansiyonBuyuk, "Sistolik (büyük) tansiyon 90 – 180 mmHg arasında olmalıdır. ");
            }
            if (Convert.ToInt32(txt_TansiyonKucuk.Text) < 50 || Convert.ToInt32(txt_TansiyonKucuk.Text) > 100)//Diyastolik (küçük) tansiyon 50 – 100 mmHg arasında olmalıdır. 
            {
                epr_hatagosterme.SetError(txt_TansiyonKucuk, "Diyastolik (küçük) tansiyon 50 – 100 mmHg arasında olmalıdır.  ");
            }
            if (Convert.ToDouble(txt_hct.Text) < 40 || Convert.ToDouble(txt_hct.Text) > 54)//sağlıklı bir insanda hct testi 40-54 olmalı
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_hct, "HCT 40-54 Arası olmalı ");
            }
            if (Convert.ToDouble(txt_hgb.Text) < 13.5 || Convert.ToDouble(txt_hgb.Text) > 18)//hgb 13,5-18 olmalı
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_hgb, "HGB 13,5-18 Arası olmalı ");
            }
            if (Convert.ToInt32(txt_wbc.Text) < 4000 || Convert.ToInt32(txt_wbc.Text) > 12000)//wbc 4000-12000 olmalı
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_wbc, "WBC 4000-12000 Arası olmalı ");
            }
            if (Convert.ToInt32(txt_plt.Text) < 150000 || Convert.ToInt32(txt_plt.Text) > 450000)//150000-450000
            {
                sonuc = false;
                epr_hatagosterme.SetError(txt_plt, "PLT 150000-450000 Arası olmalı ");
            }
            return sonuc;
        }

        private void btn_oncekibilgiler_Click(object sender, EventArgs e)
        {
            donor_no = Convert.ToDouble(txt_DonorNo.Text);
            frm_FizikIncelemeKayitlari fizikkayitlari = new frm_FizikIncelemeKayitlari();
            fizikkayitlari.donorno =Convert.ToDouble(txt_DonorNo.Text);
            this.Hide();
            fizikkayitlari.Show();
        }
    }
}
