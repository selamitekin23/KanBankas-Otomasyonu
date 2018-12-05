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
    public partial class frm_DonorTestGirisi : Form
    {
        public frm_DonorTestGirisi()
        {
            InitializeComponent();
        }
        cls_Testler TestlerSınıfı = new cls_Testler();
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        string mesaj;
        DateTime zaman;
        frm_DonorKayitGirisi donor_giris_formu = (frm_DonorKayitGirisi)Application.OpenForms["frm_DonorKayitGirisi"];
        private void frm_DonorTestGirisi_Load(object sender, EventArgs e)
        {
            try
            {
                TestlerSınıfı.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
                timer_bilgi.Enabled = true;
                TestlerSınıfı.tc_no_kontrol(Convert.ToDouble(donor_giris_formu.tc_no));
                txt_ad.Text = TestlerSınıfı.ad;
                txt_soyad.Text = TestlerSınıfı.soyad;
                kan_gruplarini_yaz();
                mesaj = TestlerSınıfı.donor_islem_no_olustur("DonorTestİşlemleri");
                if (mesaj == "")
                {
                    txt_DonorIslemNO.Text = Convert.ToString(TestlerSınıfı.donor_islem_numarasi);
                    txt_KayitYapan.Text = TestlerSınıfı.KullaniciBul(kullanici_giris_formu.kullanici_adi);
                }
                else
                {
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    donor_giris_formu.Show();
                    this.Close();
                }
            }catch(Exception hata){
                MessageBox.Show("İstenmiyen bir hata oluştu.Hata Çıktısı: " + hata);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            donor_giris_formu.Show();
            this.Hide();
        }

        private void timer_bilgi_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            txt_tarih.Text = String.Format("{0:d}", zaman);
            txt_saat.Text = String.Format("{0:t}", zaman);
        }
        private void kan_gruplarini_yaz()
        {
            cls_DonorGirisi DonorSinifi = new cls_DonorGirisi();
            DonorSinifi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            //sistem veritabanında kayıtlı olan kan gruparını comboboxa aktarma
            try
            {
                DataTable kan = DonorSinifi.kan_gruplarini_getir();
                DataRow al;
                for (int i = 0; kan.Rows.Count > i; i++)
                {
                    al = kan.Rows[i];
                    cmb_kangrubu.Items.Add(al[0]);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kan Gruplarını yazarken hata oluştu.Hata:" + hata);
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (cmb_aids.SelectedIndex == -1 || cmb_frengi.SelectedIndex == -1 || cmb_hepatitB.SelectedIndex == -1 || cmb_hepatitC.SelectedIndex == -1 || cmb_kangrubu.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm Testlerin Sonuçları girilmeden Kayıt Yapılamaz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    SonucBul();
                    TestlerSınıfı.DonorTestKaydet(Convert.ToDouble(txt_DonorNo.Text), Convert.ToDouble(txt_DonorIslemNO.Text), txt_ad.Text, txt_soyad.Text, cmb_hepatitB.Text, cmb_hepatitC.Text, cmb_aids.Text, cmb_frengi.Text, cmb_kangrubu.Text, txt_sonuc.Text, txt_KayitYapan.Text, txt_tarih.Text, txt_saat.Text);
                    TestlerSınıfı.TestSonucYazma(Convert.ToDouble(txt_DonorNo.Text), Convert.ToDouble(txt_DonorIslemNO.Text), txt_sonuc.Text);
                    btn_Kaydet.Enabled = false;
                    MessageBox.Show(txt_DonorNo.Text + " Donor Numarasına ait Test Sonuç Kaydı Başarıyla Gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }catch(Exception hata){
                    MessageBox.Show("İstenmiyen bir hata oluştu.Hata Çıktısı: "+hata);
                
                }
            }
        }

        public void SonucBul() {
            txt_sonuc.Visible = true;
            string test_sonuc="OLUMLU(+)";    
        if(cmb_hepatitB.Text=="POZİTİF"){
            test_sonuc = "OLUMSUZ(-)";        
        }
        if (cmb_hepatitC.Text == "POZİTİF")
        {
            test_sonuc = "OLUMSUZ(-)";
        }
        if (cmb_frengi.Text == "POZİTİF")
        {
            test_sonuc = "OLUMSUZ(-)";
        }
        if (cmb_aids.Text == "POZİTİF")
        {
            test_sonuc = "OLUMSUZ(-)";
        }
        if (test_sonuc == "OLUMLU(+)")
        {
            txt_sonuc.Text = "OLUMLU(+)";
            txt_sonuc.BackColor = Color.Chartreuse;
        }
        else {
            txt_sonuc.Text = "OLUMSUZ(-)";
            txt_sonuc.BackColor = Color.Red;
        }
        }
 
    }
}
