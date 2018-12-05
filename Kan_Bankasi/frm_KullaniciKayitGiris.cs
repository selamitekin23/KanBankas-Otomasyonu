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
    public partial class frm_KullaniciKayitGiris : Form
    {
        cls_kullanici_kaydi kullanici_giris = new cls_kullanici_kaydi();
        string mesaj;
        frm_Kullanici_girisi kullanici = new frm_Kullanici_girisi();
        public frm_KullaniciKayitGiris()
        {
            InitializeComponent();
        }

        private void frm_kullanici_kaydi_Load(object sender, EventArgs e)
        {
            try { kullanici_giris.baglan_adrese(kullanici.baglanti_adresi); }
            catch (Exception hata) { MessageBox.Show("Bağlantı Hatası.Hata İçeriği : " + hata, "HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_tcno.Text == "")
            {
                MessageBox.Show("Silme İşleminin Yapılabilmesi İçin TC Numarasının Girilmesi Gerekir.", "SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mesaj = kullanici_giris.kullanici_sil(Convert.ToDouble(txt_tcno.Text));
                    MessageBox.Show(mesaj, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("TC Numarası sadece rakamlardan oluşur.Tc numarasının düzeltiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen bir hata oluştu.Hata İçeriği: " + hata, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_Ayarlar Ayarlar = new frm_Ayarlar();
            this.Hide();
            Ayarlar.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_brans.Text == "" || txt_cepno.Text == "" || txt_eposta.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_iletisim_adres.Text == "" || txt_kullanici_adi.Text == "" || txt_kurum_adi.Text == "" || txt_soyad.Text == "" || txt_tcno.Text == "")
            {
                MessageBox.Show("Tüm Bilgileri Girmeden Kullanıcı Kaydı Yapılmaz.", "NULL DEĞERLER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mesaj = kullanici_giris.kullanici_guncelle(Convert.ToDouble(txt_tcno.Text), txt_ad.Text, txt_soyad.Text, txt_eposta.Text, txt_cepno.Text, txt_kurum_adi.Text, txt_brans.Text, txt_iletisim_adres.Text, txt_il.Text, txt_ilce.Text, txt_kullanici_adi.Text, Convert.ToDouble(txt_sifre.Text));
                    MessageBox.Show(mesaj, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("Giriş Değerleri Yanlış.Giriş Değerlerini Kontrol Ediniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen bir hata oluştu.Hata İçeriği: " + hata); }
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {

            //kullanici bul metotu ile bulunan veri datarow nesnesine aktarıyom datarow public tanımlayıp form üzerinden direk erişim sağlıyom
            if (txt_tcno.Text == "")
            {
                MessageBox.Show("TC Numarası girilmeden kayıt bulunamaz.TC Numarasını giriniz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool sonuc = kullanici_giris.kullanici_bul(Convert.ToDouble(txt_tcno.Text));
                    if (sonuc == true)
                    {
                        txt_ad.Text = kullanici_giris.bulunan_veri[1].ToString();
                        txt_soyad.Text = kullanici_giris.bulunan_veri[2].ToString();
                        txt_eposta.Text = kullanici_giris.bulunan_veri[3].ToString();
                        txt_cepno.Text = kullanici_giris.bulunan_veri[4].ToString();
                        txt_kurum_adi.Text = kullanici_giris.bulunan_veri[5].ToString();
                        txt_brans.Text = kullanici_giris.bulunan_veri[6].ToString();
                        txt_iletisim_adres.Text = kullanici_giris.bulunan_veri[7].ToString();
                        txt_il.Text = kullanici_giris.bulunan_veri[8].ToString();
                        txt_ilce.Text = kullanici_giris.bulunan_veri[9].ToString();
                        txt_kullanici_adi.Text = kullanici_giris.bulunan_veri[10].ToString();
                        txt_sifre.Text = kullanici_giris.bulunan_veri[11].ToString();
                        txt_sifre_tekrar.Clear();
                    }
                    else
                    {
                        MessageBox.Show(txt_tcno.Text + " TC numrasına ait kayıt sistem veritabanında kayıtlı değil.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        temizle();

                    }
                }
                catch (Exception hata) { MessageBox.Show("İstenmiyen bir hata oluştu.Hata İçeriği: " + hata, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }          
            }            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text == txt_sifre_tekrar.Text)
            {
                if (txt_ad.Text == "" || txt_brans.Text == "" || txt_cepno.Text == "" || txt_eposta.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_iletisim_adres.Text == "" || txt_kullanici_adi.Text == "" || txt_kurum_adi.Text == "" || txt_soyad.Text == "" || txt_tcno.Text == "")
                {
                    MessageBox.Show("Tüm Bilgileri Girmeden Kullanıcı Kaydı Yapılmaz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        mesaj = kullanici_giris.kullanici_kaydet(Convert.ToDouble(txt_tcno.Text), txt_ad.Text.ToUpper(), txt_soyad.Text.ToUpper(), txt_eposta.Text, txt_cepno.Text, txt_kurum_adi.Text.ToUpper(), txt_brans.Text.ToUpper(), txt_iletisim_adres.Text.ToUpper(), txt_il.Text.ToUpper(), txt_ilce.Text.ToUpper(), txt_kullanici_adi.Text, Convert.ToDouble(txt_sifre.Text));
                        MessageBox.Show(mesaj, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (FormatException) { MessageBox.Show("Bilgileri Doğru Değer Girdiğinizden Emin Olunuz.(Şifre Sadece Rakamlardan Oluşur.)"); }
                    catch (Exception hata) { MessageBox.Show("İstenmiyen bir hata oluştu.Hata İçeriği: " + hata); }
                } 
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyo Şifreyi Tekrar Giriniz..", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        void temizle() {
            txt_tcno.Clear(); txt_ad.Clear(); txt_soyad.Clear(); txt_eposta.Clear(); txt_cepno.Clear(); txt_kurum_adi.Clear();
            txt_brans.Clear(); txt_iletisim_adres.Clear(); txt_il.Clear(); txt_ilce.Clear(); txt_kullanici_adi.Clear(); txt_sifre.Clear(); txt_sifre_tekrar.Clear();
        
        }

        private void txt_tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_sifre_tekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

   
    }
}
