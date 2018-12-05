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
    
    public partial class frm_Kullanici_girisi : Form
    {
        public string kullanici_adi;
        public frm_Kullanici_girisi()
        {
            InitializeComponent();
        }
        public string baglanti_adresi = @"Server =.; Database = Kan_bankasi; Trusted_Connection = True;";
        cls_giris_kontrol giris_kontrolu = new cls_giris_kontrol();
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_kullanici_adi.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreyi Boş Geçemezsiniz.", "MESAJ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    bool sonuc = false;
                    kullanici_adi = txt_kullanici_adi.Text;
                    sonuc = giris_kontrolu.kullanıcı_kontrol(baglanti_adresi, kullanici_adi, Convert.ToInt32(txt_sifre.Text));
                    if (sonuc == true)
                    {
                        frm_AnaKontrol ana_menu = new frm_AnaKontrol();
                        ana_menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış.\nTest Girişi Yapmak İçin \nKullanıcı Adı : admin Şifre : 123", "KULLANICI GİRİŞ HATASI", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txt_sifre.Clear();

                    }
                }
                catch (FormatException) { MessageBox.Show("Şifre Sadece Rakamlardan Oluşur.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                catch (Exception hata) { MessageBox.Show("Bağlantı Hatası Oluştu.Hata Olma Nedenleri:\n1. Bilgisayarınızda SQL SERVER yüklü değil\n2. SQL SERVER Dosyaları Veri Tabanına Eklenmediğinden\n3. SQL SERVER Dosyalarını Eklerken WİNDOWS AUTHECTİCATİON OLARAK SERVER NAME OLARAK . KULLANINIZ " , "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
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

     
    }
}
