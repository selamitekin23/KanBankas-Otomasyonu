using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Kan_Bankasi
{
    public partial class frm_KanGirisFormu : Form
    {
        public frm_KanGirisFormu()
        {
            InitializeComponent();
        }
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        cls_Testler Testler = new cls_Testler();
        DateTime TarihSaat,zaman;
        string mesaj;
        private void frm_KanGirisFormu_Load(object sender, EventArgs e)
        {
            try
            {
                timer_bilgi.Enabled = true;
                Testler.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
                txt_KayitYapan.Text = Testler.KullaniciBul(kullanici_giris_formu.kullanici_adi);
            }
            catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //yazdırma arayüz tasarımı
            int tepe = 30;
            int sol = 30;
            Font fn = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            fn = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            e.Graphics.DrawString("Kan Grubu", fn, Brushes.Black, sol + 400, tepe);
            fn = new Font("Arial", 60, FontStyle.Bold);
            e.Graphics.DrawString(txt_KanGrubu.Text, fn, Brushes.Red, sol + 350, tepe+30);

          
            tepe = tepe + 2*fn.Height;
            fn = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            e.Graphics.DrawString("Kan Seri Numarası" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(txt_DonorIslemNo.Text, fn, Brushes.Black, sol + 260, tepe);
            tepe = tepe +2* fn.Height;
            e.Graphics.DrawString("Donör Numarası" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(txt_DonorNo.Text, fn, Brushes.Black, sol + 260, tepe);
            tepe = tepe + 2 * fn.Height;
            e.Graphics.DrawString("AD" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(txt_ad.Text, fn, Brushes.Black, sol + 260, tepe);
            tepe = tepe + 2 * fn.Height;
            e.Graphics.DrawString("SOYAD" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(txt_soyad.Text, fn, Brushes.Black, sol + 260, tepe);
            tepe = tepe + 2 * fn.Height;
            e.Graphics.DrawString("İşlem Tarih" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(date_Itarih.Text, fn, Brushes.Black, sol + 260, tepe);
            tepe = tepe + 2 * fn.Height;
            e.Graphics.DrawString("İşlem Saat" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(date_Saat.Text, fn, Brushes.Black, sol + 260, tepe);
            tepe = tepe + 2 * fn.Height;
            e.Graphics.DrawString("Son Kullanma Tarihi" + " :", fn, Brushes.Black, sol, tepe);
            e.Graphics.DrawString(txt_Skt.Text, fn, Brushes.Black, sol + 260, tepe);
            
            tepe = tepe + 2 * fn.Height;
            e.Graphics.DrawString("Barkod Numarası" + " :", fn, Brushes.Black, sol, tepe);
            tepe = tepe + 2 * fn.Height; fn = new Font("3 of 9 Barcode", 50, FontStyle.Regular);
            e.Graphics.DrawString(lbl_Barkod.Text, fn, Brushes.Black, sol + 260, tepe);
        }

      

        private void btn_BilgileriGetir_Click(object sender, EventArgs e)
        {
            if (txt_DonorIslemNo.Text == "")
            {
                MessageBox.Show("Donör İşlem Numarasını Giriniz.");
            }
            else
            {
                bool dogrula = Kontrol();
            }        
        }

        private void date_Itarih_ValueChanged(object sender, EventArgs e)
        {
            //tarij seçildiği zaman kan alındıktan sonraki ömrü bir yıl olduğunda 1 yıl fazlasının alıp kullanıcıya gösteriyoz isterse kullanıcı bu tarihi kendide değiştirebilir
            TarihSaat =Convert.ToDateTime( date_Itarih.Text);
            TarihSaat = TarihSaat.AddDays(365);
            txt_Skt.Text = String.Format("{0:d}", TarihSaat);
        }

        private void timer_bilgi_Tick(object sender, EventArgs e)
        {
            //saat bilgileri
            zaman = DateTime.Now;
            txt_tarih.Text = String.Format("{0:d}", zaman);
            txt_saat.Text = String.Format("{0:t}", zaman);
        }

        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            //yazdırma
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        public void temizle() {
            txt_ad.Clear(); txt_DonorNo.Clear();
            txt_KanGrubu.Clear(); txt_Skt.Clear();
            txt_soyad.Clear(); lbl_Barkod.Text = "";
        
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaKontrol AnaKontrol = new frm_AnaKontrol();
            this.Close();
            AnaKontrol.Show();
            timer_bilgi.Enabled = false;
        }

 

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_DonorIslemNo.Text == "")
            {
                MessageBox.Show("Donör İşlem Numarasını Giriniz", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                try
                {
                    bool dogrula = Kontrol();
                    if (dogrula == true)
                    {
                        mesaj = Testler.KanGirisKayit(Convert.ToDouble(txt_DonorNo.Text), Convert.ToDouble(txt_DonorIslemNo.Text), txt_ad.Text, txt_soyad.Text, date_Itarih.Text, date_Saat.Text, txt_Skt.Text, txt_KanGrubu.Text, txt_KayitYapan.Text, txt_tarih.Text, txt_saat.Text);
                        MessageBox.Show(mesaj, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontol Ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }   
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (txt_DonorIslemNo.Text == "")
            {
                MessageBox.Show("Donör İşlem Numarasını Giriniz", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    mesaj = Testler.KanGirisSil(Convert.ToDouble(txt_DonorIslemNo.Text));
                    MessageBox.Show(mesaj, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("Donör İşlem Numarası Sadece Sayılardan Oluşur.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
        }
        public bool Kontrol() {
            //dnor işlem numarasına göre ilgili kayıt bilgileri kontrol edilip gerekli yerlere dolduruluyo

            bool sonuc,dogrula=false;
            sonuc = Testler.KanGirisBilgiGetir(Convert.ToDouble(txt_DonorIslemNo.Text));
            if (sonuc == false)
            {
                MessageBox.Show("Donör İşlem Numarası Kan Vermeye Olumlu Bir Donör'e Kayıtlı Olması Gerekir. Donör İşlem Numarası Yardım Kısmından Donör İşlem Numaranızı Kontrol Ediniz.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                temizle();
                dogrula = false;
            }
            else
            {
                try
                {
                    dogrula = true;
                    txt_DonorNo.Text = Convert.ToString(Testler.donor_numarasi);
                    txt_ad.Text = Testler.ad;
                    txt_soyad.Text = Testler.soyad;
                    txt_KanGrubu.Text = Testler.KanGrubu;
                    TarihSaat = Convert.ToDateTime(date_Itarih.Text);
                    TarihSaat = TarihSaat.AddDays(365);
                    txt_Skt.Text = String.Format("{0:d}", TarihSaat);
                    try
                    {
                        lbl_Barkod.Text = txt_DonorIslemNo.Text;
                        //BARKOD YAZIMI İÇİN FONT DOSYASINDAKİ FONTLAR C:\Windows\Fonts KSIMINA KOPYALAMAMIZ GEREK
                            btn_Sil.Enabled = true; btn_Yazdir.Enabled = true;
                            lbl_Barkod.Font = new Font("Code 128", lbl_Barkod.Font.Size, FontStyle.Regular);
                    }
                    catch (Exception) { MessageBox.Show(@"Barkod Numarası Oluşturulabilmesi için Dosyamızım Debug Kısmında Bulunan Font Dosyalarını C:\Windows\Fonts Kopyalanması Gerekir."); }
                    
                    
                    TarihSaat = DateTime.Now.AddDays(365);


                }
                catch (FormatException) { MessageBox.Show("Donör İşlem Numarası Sadece Sayılardan Oluşur.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata, "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            return dogrula;
        }

        private void btn_Stok_Click(object sender, EventArgs e)
        {
            frm_StokKan Stok = new frm_StokKan();
            this.Hide();
            Stok.Show();
        }

        private void btn_ikontrol_Click(object sender, EventArgs e)
        {
            frm_DonorIslemNumarasıKontrol IslemKontrol = new frm_DonorIslemNumarasıKontrol();
            this.Hide();
            IslemKontrol.Show();
        }

        private void txt_DonorIslemNo_KeyPress(object sender, KeyPressEventArgs e)
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
