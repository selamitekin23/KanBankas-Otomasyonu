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
    public partial class frm_DonorSoruCevapla : Form
    {
        public frm_DonorSoruCevapla()
        {
            InitializeComponent();
        }
        cls_Testler TestDonorBilgi = new cls_Testler();
        DataTable tum_sorular = new DataTable();
        DataRow soru;
        int i = 0,uzunluk=0;
        public double donorno,donorislemno;
        frm_Kullanici_girisi kullanici_giris_formu = new frm_Kullanici_girisi();
        string[,] soru_dizisi;
        string [,]yanlis_sorular;
        int numara = 0;
        frm_DonorBilgiTest BilgiTestFormu = (frm_DonorBilgiTest)Application.OpenForms["frm_DonorBilgiTest"];
        private void frm_DonorSoruCevapla_Load(object sender, EventArgs e)
        {
            TestDonorBilgi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            tum_sorular = TestDonorBilgi.SorulariAl();
            uzunluk = tum_sorular.Rows.Count;
            soru_dizisi = new string[uzunluk, 2];
            SoruDegistir();
            
        }

        public void SoruDegistir() {
        
            if(uzunluk>i){
                numara = (i + 1);
                lbl_soru_no.Text = "SORU " + numara + " :"; 
                soru = tum_sorular.Rows[i];
                lbl_soru.Text = soru[1].ToString();
                soru_dizisi[i, 0] = soru[1].ToString();
            }
            if (i == uzunluk) {
                TestDonorBilgi.BilgiSorularininCevaplarini_Kaydet(donorno, donorislemno, soru_dizisi,uzunluk,BilgiTestFormu.txt_KayitYapan.Text,BilgiTestFormu.txt_tarih.Text,BilgiTestFormu.txt_saat.Text);
                YanlisSorulariBul();
                frm_SoruKontrol SoruKontrolFormu = new frm_SoruKontrol();
                SoruKontrolFormu.sorular = yanlis_sorular;
                SoruKontrolFormu.donorno = donorno;
                SoruKontrolFormu.donorislemno = donorislemno;
                SoruKontrolFormu.Show();
                this.Hide();
            }
            
        }

        private void btn_Evet_Click(object sender, EventArgs e)
        {
            
            if (uzunluk > i)
            {
                soru_dizisi[i, 1] = "EVET ";
                i++;
                SoruDegistir();
            
            }
        }

        private void btn_Hayir_Click(object sender, EventArgs e)
        {
            if (uzunluk > i)
            {

                soru_dizisi[i, 1] = "HAYIR";
                i++;
                SoruDegistir();
            }
        }

        public void YanlisSorulariBul() {
            int sayac = 0,k=0; 
            for (int j = 0; uzunluk > j; j++) {
                soru = tum_sorular.Rows[j];
                if (soru_dizisi[j, 1] != soru[2].ToString()) {
                    sayac++;
                }           
            }

            if (sayac != 0)
            {
                yanlis_sorular = new string[sayac, 2];
                for (int j = 0; uzunluk > j; j++)
                {
                    soru = tum_sorular.Rows[j];
                    if (soru_dizisi[j, 1] != soru[2].ToString())
                    {
                        yanlis_sorular[k, 0] = soru_dizisi[j, 0];
                        yanlis_sorular[k, 1] = soru_dizisi[j, 1];
                        k++;
                    }
                }
            }
        
        }
    }
}
