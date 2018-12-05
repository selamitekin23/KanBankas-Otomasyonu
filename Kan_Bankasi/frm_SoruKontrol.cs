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
    public partial class frm_SoruKontrol : Form
    {
        public frm_SoruKontrol()
        {
            InitializeComponent();
        }
        public string [,]sorular;
        public double donorno, donorislemno;
        cls_Testler BilgiTestSonuc = new cls_Testler();
        frm_Kullanici_girisi kullanici_giris_formu = new frm_Kullanici_girisi();
        frm_DonorKayitGirisi donor_giris_formu = (frm_DonorKayitGirisi)Application.OpenForms["frm_DonorKayitGirisi"];
        private void frm_SoruKontrol_Load(object sender, EventArgs e)
        {
            BilgiTestSonuc.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
            for (int i = 0; sorular.Length > i; i++) {
                lst_yanlis_sorular.Items.Add(sorular[i, 0] + "   VERİLEN CEVAP:" + sorular[i, 1]);          
            }
        }

        private void btn_Olumlu_Click(object sender, EventArgs e)
        {
            BilgiTestSonuc.BilgiSoruSonuc(donorno, donorislemno, "OLUMLU(+)");
            MessageBox.Show("Donör Bilgi Form Kaydı OLUMLU(+) Olarak Kaydı Gerçekleştirildi.","SONUÇ",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            donor_giris_formu.Show();
            this.Close();
        }

        private void btn_olumsuz_Click(object sender, EventArgs e)
        {
            BilgiTestSonuc.BilgiSoruSonuc(donorno, donorislemno, "OLUMSUZ(-)");
            MessageBox.Show("Donör Bilgi Form Kaydı OLUMSUZ(-) Olarak Kaydı Gerçekleştirildi.", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            donor_giris_formu.Show();
            this.Close();
        }
    }
}
