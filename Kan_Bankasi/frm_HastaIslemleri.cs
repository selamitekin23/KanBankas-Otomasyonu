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
    public partial class frm_HastaIslemleri : Form
    {
        public frm_HastaIslemleri()
        {
            InitializeComponent();
        }
        cls_HastaIslemleri HastaIslemleri = new cls_HastaIslemleri();
        DateTime zaman;
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        cls_Testler TestSinifi = new cls_Testler();
        string mesaj;
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_adres.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_soyad.Text == "" || txt_TcNo.Text == "" || cmb_Cinsiyet.SelectedIndex == -1 || cmb_KanGrubu.SelectedIndex == -1)
            {

                MessageBox.Show("Tüm Bilgiler Girilmeden Hasta Kaydı Yapılmaz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                try
                {
                    mesaj = HastaIslemleri.HastaKaydet(Convert.ToDouble(txt_TcNo.Text), txt_ad.Text.ToUpper(), txt_soyad.Text.ToUpper(), cmb_Cinsiyet.Text, mtxt_ceptel.Text, txt_adres.Text.ToUpper(), txt_il.Text.ToUpper(), txt_ilce.Text.ToUpper(), cmb_KanGrubu.Text, txt_KayitYapan.Text, txt_Tarih.Text, txt_Saat.Text);
                    MessageBox.Show(mesaj, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontrol Ediniz", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
           
        }

        private void frm_HastaIslemleri_Load(object sender, EventArgs e)
        {
            try {
                timer_bilgi.Enabled = true;
                HastaIslemleri.AdreseBaglan(kullanici_giris_formu.baglanti_adresi);
                txt_KayitYapan.Text = HastaIslemleri.KullaniciBul(kullanici_giris_formu.kullanici_adi);
                kan_gruplarini_yaz();
            }
            catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
           
        }

        private void timer_bilgi_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            txt_Tarih.Text = String.Format("{0:d}", zaman);
            txt_Saat.Text = String.Format("{0:t}", zaman);
        }
        private void kan_gruplarini_yaz()
        {
            //sistem veritabanında kayıtlı olan kan gruparını comboboxa aktarma
            try
            {
                DataTable kan = HastaIslemleri.kan_gruplarini_getir();
                DataRow al;
                for (int i = 0; kan.Rows.Count > i; i++)
                {
                    al = kan.Rows[i];
                    cmb_KanGrubu.Items.Add(al[0]);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kan Gruplarını yazarken hata oluştu.Hata:" + hata, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {
            if (txt_TcNo.Text == "")
            {
                MessageBox.Show("Tc Numarasını Giriniz", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                try
                {
                    bool deger;
                    deger = HastaIslemleri.HastaKontrol(Convert.ToDouble(txt_TcNo.Text));
                    if (deger == true)
                    {
                        txt_ad.Text = HastaIslemleri.bulunan_veri["Ad"].ToString();
                        txt_soyad.Text = HastaIslemleri.bulunan_veri["Soyad"].ToString();
                        cmb_Cinsiyet.Text = HastaIslemleri.bulunan_veri["Cinsiyet"].ToString();
                        mtxt_ceptel.Text = HastaIslemleri.bulunan_veri["CepTel"].ToString();
                        txt_adres.Text = HastaIslemleri.bulunan_veri["Adres"].ToString();
                        txt_il.Text = HastaIslemleri.bulunan_veri["Il"].ToString();
                        txt_ilce.Text = HastaIslemleri.bulunan_veri["Ilce"].ToString();
                        cmb_KanGrubu.Text = HastaIslemleri.bulunan_veri["KanGrubu"].ToString();
                        AktifEt(true);
                        MessageBox.Show("Hasta Girişi Daha Önceden Yapılmıştır. Bilgilerde Değişiklik Varsa Güncelleyiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        temizle();
                        AktifEt(true);

                    }
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontrol Ediniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : "+hata); }
            }
       
        }
        private void AktifEt(bool deger) {
            txt_ad.Enabled = deger;
            txt_adres.Enabled = deger;
            txt_il.Enabled = deger;
            txt_ilce.Enabled = deger;
            txt_soyad.Enabled = deger;
            mtxt_ceptel.Enabled = deger;
            cmb_Cinsiyet.Enabled = deger;
            cmb_KanGrubu.Enabled = deger;                        
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaKontrol AnaKontrol = new frm_AnaKontrol();
            this.Close(); 
            timer_bilgi.Enabled = false;
            AnaKontrol.Show();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_adres.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_soyad.Text == "" || txt_TcNo.Text == "" || cmb_Cinsiyet.SelectedIndex == -1 || cmb_KanGrubu.SelectedIndex == -1)
            {

                MessageBox.Show("Tüm Bilgiler Girilmeden Hasta Güncellemesi Yapılmaz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    mesaj = HastaIslemleri.HastaGuncelle(Convert.ToDouble(txt_TcNo.Text), txt_ad.Text.ToUpper(), txt_soyad.Text.ToUpper(), cmb_Cinsiyet.Text, mtxt_ceptel.Text, txt_adres.Text.ToUpper(), txt_il.Text.ToUpper(), txt_ilce.Text.ToUpper(), cmb_KanGrubu.Text, txt_KayitYapan.Text, txt_Tarih.Text, txt_Saat.Text);
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontrol Ediniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (txt_TcNo.Text == "")
            {
                MessageBox.Show("TC Numrasını Giriniz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                try
                {
                    mesaj = HastaIslemleri.HastaSil(Convert.ToDouble(txt_TcNo.Text));
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        
                }
                catch (FormatException) { MessageBox.Show("TC Numarası Sadece Sayılardan Oluşur."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
            
        }
        private void temizle() {
            txt_ad.Clear(); txt_adres.Clear();
            txt_il.Clear(); txt_ilce.Clear();
            txt_soyad.Clear();
            cmb_Cinsiyet.SelectedIndex = -1;
            cmb_KanGrubu.SelectedIndex = -1;
        
        
        }

        private void btn_Cross_Click(object sender, EventArgs e)
        {
            if (txt_TcNo.Text == "")
            {
                MessageBox.Show("Tc Numarasını Girirmeden CrossMatch İşlemi Yapılamaz.Tc Numarasını Giriniz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    bool deger;
                    deger = HastaIslemleri.HastaKontrol(Convert.ToDouble(txt_TcNo.Text));
                    if (deger == true)
                    {
                        txt_ad.Text = HastaIslemleri.bulunan_veri["Ad"].ToString();
                        txt_soyad.Text = HastaIslemleri.bulunan_veri["Soyad"].ToString();
                        cmb_Cinsiyet.Text = HastaIslemleri.bulunan_veri["Cinsiyet"].ToString();
                        mtxt_ceptel.Text = HastaIslemleri.bulunan_veri["CepTel"].ToString();
                        txt_adres.Text = HastaIslemleri.bulunan_veri["Adres"].ToString();
                        txt_il.Text = HastaIslemleri.bulunan_veri["Il"].ToString();
                        txt_ilce.Text = HastaIslemleri.bulunan_veri["Ilce"].ToString();
                        cmb_KanGrubu.Text = HastaIslemleri.bulunan_veri["KanGrubu"].ToString();
                        AktifEt(true);
                        frm_CrossMatch CrossMatch = new frm_CrossMatch();
                        CrossMatch.txt_Had.Text = txt_ad.Text;
                        CrossMatch.txt_Hsoyad.Text = txt_soyad.Text;
                        CrossMatch.TcNo = Convert.ToDouble(txt_TcNo.Text);
                        CrossMatch.lbl_HastaKanGrubu.Text = cmb_KanGrubu.Text;
                        this.Hide();
                        CrossMatch.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cross Match İşleminin Yapılabilmesi İçin Tc Kimlik Numrasının Kayıtlı Bir Hastaya Ait Olması Gerekir.Hastanın Kaydını Yaptıktan Sonra Cross Match İşlemini Gerçekleştiriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontrol Ediniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
         
        }

        private void txt_TcNo_KeyPress(object sender, KeyPressEventArgs e)
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
