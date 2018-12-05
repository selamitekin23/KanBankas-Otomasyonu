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
    public partial class frm_DonorKayitGirisi : Form
    {
        string mesaj;
        bool tc_sonuc;
        public double donor_numarasi = 0;
        public string k;
        DateTime zaman;
        public double tc_no=0;
        // frm_Kullanici_girisi kullanici = new frm_Kullanici_girisi();
        cls_DonorGirisi donor_sinifi = new cls_DonorGirisi();
        cls_Testler TestlerSinifi = new cls_Testler();
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        public frm_DonorKayitGirisi()
        {
            InitializeComponent();
        }

       
        private void frm_Donor_girisi_Load(object sender, EventArgs e)
        {
            kapat(true);
            donor_sinifi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            TestlerSinifi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            txt_Sonuc.Enabled = false; txt_Saat.Enabled = false; txt_KayitYapan.Enabled = false; txt_Tarih.Enabled = false;
            kapat(false);
            kan_gruplarini_yaz();
        }
       // frm_Kullanici_girisi aer = new frm_Kullanici_girisi();
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {          
            //sisteme giriş yapan kişinin bilgilerini gösterme
            if (txt_tc_no.Text == "" || txt_ad.Text == "" || txt_soyad.Text == "" || cmb_KanGrubu.SelectedIndex == -1 || cmb_KanVermeNedeni.SelectedIndex == -1 || cmb_Cinsiyet.SelectedIndex == -1 || cmb_MedeniHali.SelectedIndex == -1 || txt_DogumYeri.Text == "" || txt_BabaAdi.Text == "" || txt_AnneAdi.Text == "" || txt_EvTelefonu.Text == "" || txt_CepTelefonu.Text == "" || txt_Eposta.Text == "" || txt_Meslegi.Text == "" || txt_adres.Text == "" || txt_il.Text == "" || txt_ilce.Text == "")
            {
                MessageBox.Show("Tüm bilgileri doldurunuz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                try
                {
                    zaman = DateTime.Now;
                    donor_numarasi = donor_sinifi.donor_no_olustur(Convert.ToDouble(txt_tc_no.Text));
                    mesaj = donor_sinifi.donor_kaydet(Convert.ToDouble(txt_tc_no.Text), donor_numarasi, txt_ad.Text.ToUpper(), txt_soyad.Text.ToUpper(), cmb_KanGrubu.Text.ToUpper(), cmb_KanVermeNedeni.Text.ToUpper(), cmb_Cinsiyet.Text.ToUpper(), cmb_MedeniHali.Text.ToUpper(), Convert.ToDouble(txt_EvTelefonu.Text), Convert.ToDouble(txt_CepTelefonu.Text), date_DogumTarihi.Text, txt_DogumYeri.Text.ToUpper(), txt_BabaAdi.Text.ToUpper(), txt_AnneAdi.Text.ToUpper(), txt_Meslegi.Text.ToUpper(), txt_Eposta.Text, txt_adres.Text.ToUpper(), txt_il.Text.ToUpper(), txt_ilce.Text.ToUpper(), txt_aciklama.Text.ToUpper(), donor_sinifi.KullaniciBul(kullanici_giris_formu.kullanici_adi), String.Format("{0:d}", zaman), String.Format("{0:t}", zaman));
                    if (donor_sinifi.kayit_sonuc == true)
                    {
                        txt_KayitYapan.Text = donor_sinifi.KullaniciBul(kullanici_giris_formu.kullanici_adi);
                        txt_Saat.Text = String.Format("{0:t}", zaman);
                        txt_Tarih.Text = String.Format("{0:d}", zaman);
                        temizle(); 
                    }
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu:" + hata);

                }
            }
          
        }

        private void kapat(bool deger) {
            txt_ad.Enabled = deger;
            txt_soyad.Enabled = deger;
            txt_Meslegi.Enabled = deger;
            txt_ilce.Enabled = deger;
            txt_il.Enabled = deger;
            txt_EvTelefonu.Enabled = deger;
            txt_Eposta.Enabled = deger;
            txt_DogumYeri.Enabled = deger;
            txt_CepTelefonu.Enabled = deger;
            txt_BabaAdi.Enabled = deger;
            txt_AnneAdi.Enabled = deger;
            txt_adres.Enabled = deger;
            txt_aciklama.Enabled = deger;
            cmb_Cinsiyet.Enabled = deger;
            cmb_KanGrubu.Enabled = deger;
            cmb_KanVermeNedeni.Enabled = deger;
            cmb_MedeniHali.Enabled = deger;
            btn_DonorBilgi.Enabled = deger;
            btn_DonorTest.Enabled = deger;
            btn_Fizikİnceleme.Enabled = deger;
            btn_Guncelle.Enabled = deger;
            btn_Kaydet.Enabled = deger;
            btn_Sil.Enabled = deger;
            date_DogumTarihi.Enabled = deger;
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            Tc_No_Kontrol();
            if(tc_sonuc==true){
                MessageBox.Show("DONÖR daha önceden bağışta bulunmuştur.Bilgilerde değişiklik varsa güncelleyiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            }
           
        }
        public void Tc_No_Kontrol() {
            if (txt_tc_no.Text == "")
            {
                MessageBox.Show("Donör TC Numrasını giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    tc_sonuc = donor_sinifi.tc_no_kontrol(Convert.ToDouble(txt_tc_no.Text));
                    if (tc_sonuc == true)
                    {
                        //bilgileri metin kutularına aktarma
                        txt_Sonuc.Text = "SONUÇ";
                        txt_Sonuc.BackColor = Color.White;
                        txt_ad.Text = donor_sinifi.bulunan_veri[1].ToString();
                        txt_soyad.Text = donor_sinifi.bulunan_veri[2].ToString();
                        txt_DonorNo.Text = donor_sinifi.bulunan_veri[3].ToString();
                        cmb_KanGrubu.Text = donor_sinifi.bulunan_veri[4].ToString();
                        cmb_KanVermeNedeni.Text = donor_sinifi.bulunan_veri[5].ToString();
                        cmb_Cinsiyet.Text = donor_sinifi.bulunan_veri[6].ToString();
                        cmb_MedeniHali.Text = donor_sinifi.bulunan_veri[7].ToString();
                        date_DogumTarihi.Text = donor_sinifi.bulunan_veri[8].ToString();
                        txt_DogumYeri.Text = donor_sinifi.bulunan_veri[9].ToString();
                        txt_BabaAdi.Text = donor_sinifi.bulunan_veri[10].ToString();
                        txt_AnneAdi.Text = donor_sinifi.bulunan_veri[11].ToString();
                        txt_EvTelefonu.Text = donor_sinifi.bulunan_veri[12].ToString();
                        txt_CepTelefonu.Text = donor_sinifi.bulunan_veri[13].ToString();
                        txt_Meslegi.Text = donor_sinifi.bulunan_veri[14].ToString();
                        txt_Eposta.Text = donor_sinifi.bulunan_veri[15].ToString();
                        txt_adres.Text = donor_sinifi.bulunan_veri[16].ToString();
                        txt_il.Text = donor_sinifi.bulunan_veri[17].ToString();
                        txt_ilce.Text = donor_sinifi.bulunan_veri[18].ToString();
                        txt_aciklama.Text = donor_sinifi.bulunan_veri[19].ToString();
                        txt_KayitYapan.Text = donor_sinifi.bulunan_veri[20].ToString();
                        txt_Tarih.Text = donor_sinifi.bulunan_veri[21].ToString();
                        txt_Saat.Text = donor_sinifi.bulunan_veri[22].ToString();
                        
                    }
                    else
                    {
                        temizle();

                    }
                    kapat(true);
                }
                catch (FormatException)
                {
                    MessageBox.Show("TC Numrası Yanlış Girildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu: " + ex);
                }
            }
        }
        private void kan_gruplarini_yaz() {
            //sistem veritabanında kayıtlı olan kan gruparını comboboxa aktarma
            try
            {
                DataTable kan = donor_sinifi.kan_gruplarini_getir();
                DataRow al;
                for (int i = 0; kan.Rows.Count > i; i++)
                {
                    al = kan.Rows[i];
                    cmb_KanGrubu.Items.Add(al[0]);
                }
            }
            catch (Exception hata) {
                MessageBox.Show("Kan Gruplarını yazarken hata oluştu.Hata:"+hata);
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaKontrol ana_menu = new frm_AnaKontrol();
            ana_menu.Show();
            this.Close();
        }
        public void temizle() {
            txt_DonorNo.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_Meslegi.Clear();
            txt_ilce.Clear();
            txt_il.Clear();
            txt_EvTelefonu.Clear();
            txt_Eposta.Clear();
            txt_DogumYeri.Clear();
            txt_CepTelefonu.Clear();
            txt_BabaAdi.Clear();
            txt_AnneAdi.Clear();
            txt_adres.Clear();
            txt_aciklama.Clear();
            txt_KayitYapan.Clear();
            txt_Tarih.Clear();
            txt_Saat.Clear();
            cmb_Cinsiyet.SelectedIndex = -1;
            cmb_KanGrubu.SelectedIndex = -1;
            cmb_KanVermeNedeni.SelectedIndex = -1;
            cmb_MedeniHali.SelectedIndex = -1;
            txt_Sonuc.Text = "SONUÇ";
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (txt_tc_no.Text == "" || txt_ad.Text == "" || txt_soyad.Text == "" || cmb_KanGrubu.SelectedIndex == -1 || cmb_KanVermeNedeni.SelectedIndex == -1 || cmb_Cinsiyet.SelectedIndex == -1 || cmb_MedeniHali.SelectedIndex == -1 || txt_DogumYeri.Text == "" || txt_BabaAdi.Text == "" || txt_AnneAdi.Text == "" || txt_EvTelefonu.Text == "" || txt_CepTelefonu.Text == "" || txt_Eposta.Text == "" || txt_Meslegi.Text == "" || txt_adres.Text == "" || txt_il.Text == "" || txt_ilce.Text == "")
            {
                MessageBox.Show("Tüm bilgileri doldurunuz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                mesaj = donor_sinifi.donor_guncelle(Convert.ToDouble(txt_tc_no.Text), donor_numarasi, txt_ad.Text.ToUpper(), txt_soyad.Text.ToUpper(), cmb_KanGrubu.Text.ToUpper(), cmb_KanVermeNedeni.Text.ToUpper(), cmb_Cinsiyet.Text.ToUpper(), cmb_MedeniHali.Text.ToUpper(), Convert.ToDouble(txt_EvTelefonu.Text), Convert.ToDouble(txt_CepTelefonu.Text), date_DogumTarihi.Text, txt_DogumYeri.Text.ToUpper(), txt_BabaAdi.Text.ToUpper(), txt_AnneAdi.Text.ToUpper(), txt_Meslegi.Text.ToUpper(), txt_Eposta.Text, txt_adres.Text.ToUpper(), txt_il.Text.ToUpper(), txt_ilce.Text.ToUpper(), txt_aciklama.Text.ToUpper(), donor_sinifi.KullaniciBul(kullanici_giris_formu.kullanici_adi), String.Format("{0:d}", zaman), String.Format("{0:t}", zaman));
                MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                temizle();
                txt_tc_no.Clear();
            }
        
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try {
                if (txt_tc_no.Text == "")
                {
                    MessageBox.Show("TC Numrasını giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mesaj = donor_sinifi.donor_sil(Convert.ToDouble(txt_tc_no.Text));
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    temizle();
                    txt_tc_no.Clear();
                }
            }catch(FormatException ){

                MessageBox.Show("TC Numarası sadece sayılardan oluşur.");
            }
            
            
        }
        bool TestYapilsinmi;
        private void btn_Fizikİnceleme_Click(object sender, EventArgs e)
        {
         
            if (txt_tc_no.Text == "")
            {
                MessageBox.Show("Donör Fizik İncelemesinin Yapılabilmesi için TC Kimlik numarasının girilmesi gerekir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tc_No_Kontrol();
                bool sonuc = donor_sinifi.tc_no_kontrol(Convert.ToDouble(txt_tc_no.Text));
                if (sonuc == true)
                {
                    TestYapilsinmi = TestlerSinifi.GenelSonuc(Convert.ToDouble(txt_DonorNo.Text));
                    txt_DonorNo.Text = donor_sinifi.bulunan_veri[3].ToString();
                    if (TestYapilsinmi == true)
                    {
                        MessageBox.Show("Donör'e ait daha önceden yapılan testler sonucunda ALINAN KAN SİSTEM VERİTABANINA GİRİLMEDİĞİNDEN yeni bir fizik incelemesi yapılamaz.Kan Giriş Kısmından Donöre ait Alınan Kan Ünite Miktarını VeriTabanına Kaydediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt_Sonuc.Text = "KAN KAYIT NUMARASI           " + TestlerSinifi.donor_islem_numarasi;
                        txt_Sonuc.BackColor = Color.Chartreuse;
                    }
                    else
                    {

                            frm_DonorFizikIncelemeGiris fizik_inceleme_cagir = new frm_DonorFizikIncelemeGiris();
                            tc_no = Convert.ToDouble(txt_tc_no.Text);
                            this.Hide();
                            fizik_inceleme_cagir.Show();                    
                    }
                }
                else
                {
                    MessageBox.Show("Donör Fizik İncelemesinin Yapılabilmesi için TC Kimlik Numarasının Kayıtlı bir Donöre ait olması gerekir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
              
            }
        }

        private void btn_DonorBilgi_Click(object sender, EventArgs e)
        {

            if (txt_tc_no.Text == "")
            {
                MessageBox.Show("Donör Fizik İncelemesinin Yapılabilmesi için TC Kimlik numarasının girilmesi gerekir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                bool sonuc = donor_sinifi.tc_no_kontrol(Convert.ToDouble(txt_tc_no.Text));
                txt_DonorNo.Text = donor_sinifi.bulunan_veri[3].ToString();
                if (sonuc == true)
                {
                    TestYapilsinmi = TestlerSinifi.GenelSonuc(Convert.ToDouble(txt_DonorNo.Text));
                    if (TestYapilsinmi == true)
                    {
                        MessageBox.Show("Donör'e ait daha önceden yapılan testler sonucunda ALINAN KAN SİSTEM VERİTABANINA GİRİLMEDİĞİNDEN yeni bir fizik incelemesi yapılamaz.Kan Giriş Kısmından Donöre ait Alınan Kan Ünite Miktarını VeriTabanına Kaydediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt_Sonuc.Text = "KAN KAYIT NUMARASI           " + TestlerSinifi.donor_islem_numarasi;
                        txt_Sonuc.BackColor = Color.Chartreuse;
                        
                    }
                    else
                    {
                        tc_no = Convert.ToDouble(txt_tc_no.Text);
                        frm_DonorBilgiTest BilgiTestFormu = new frm_DonorBilgiTest();
                        BilgiTestFormu.txt_DonorNo.Text = txt_DonorNo.Text;
                        this.Hide();
                        BilgiTestFormu.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Donör Fizik İncelemesinin Yapılabilmesi için TC Kimlik Numarasının Kayıtlı bir Donöre ait olması gerekir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }            
            }
        }

        private void btn_DonorTest_Click(object sender, EventArgs e)
        {
            if (txt_tc_no.Text == "")
            {
                MessageBox.Show("Donör Test Kaydının Yapılabilmesi için TC Kimlik numarasının girilmesi gerekir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool sonuc = donor_sinifi.tc_no_kontrol(Convert.ToDouble(txt_tc_no.Text));
                txt_DonorNo.Text = donor_sinifi.bulunan_veri[3].ToString();
                  if (sonuc == true)
                  {
                      TestYapilsinmi = TestlerSinifi.GenelSonuc(Convert.ToDouble(txt_DonorNo.Text));
                      if (TestYapilsinmi == true)
                      {
                          MessageBox.Show("Donör'e ait daha önceden yapılan testler sonucunda ALINAN KAN SİSTEM VERİTABANINA GİRİLMEDİĞİNDEN yeni bir fizik incelemesi yapılamaz.Kan Giriş Kısmından Donöre ait Alınan Kan Ünite Miktarını VeriTabanına Kaydediniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                          txt_Sonuc.Text = "KAN KAYIT NUMARASI           " + TestlerSinifi.donor_islem_numarasi ;
                          txt_Sonuc.BackColor = Color.Chartreuse;
                      }
                      else
                      {



                          tc_no = Convert.ToDouble(txt_tc_no.Text);
                          frm_DonorTestGirisi TestFormu = new frm_DonorTestGirisi();
                          TestFormu.txt_DonorNo.Text = txt_DonorNo.Text;
                          this.Hide();
                          TestFormu.Show();

                      }

                  }
                  else
                  {
                      MessageBox.Show("Donör Fizik İncelemesinin Yapılabilmesi için TC Kimlik Numarasının Kayıtlı bir Donöre ait olması gerekir", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                  }
            }
        }

        private void txt_tc_no_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_EvTelefonu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_CepTelefonu_KeyPress(object sender, KeyPressEventArgs e)
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
