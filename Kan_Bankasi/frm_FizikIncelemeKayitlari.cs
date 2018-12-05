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
    public partial class frm_FizikIncelemeKayitlari : Form
    {
        public frm_FizikIncelemeKayitlari()
        {
            InitializeComponent();
        }
        public double donorno=0;
        cls_Testler FizikIncelemeSinifi = new cls_Testler();
        frm_Kullanici_girisi kullanici_giris_formu = new frm_Kullanici_girisi();
        private void frm_FizikIncelemeKayitlari_Load(object sender, EventArgs e)
        {
            try
            {
                FizikIncelemeSinifi.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
                dgw_FizikInceleme.DataSource = FizikIncelemeSinifi.FizikIncelemeGoster(donorno);
                dgw_FizikInceleme.Columns["DonorNo"].Visible = false;
                dgw_FizikInceleme.Columns["Aciklama"].Visible = false;
            }
            catch (Exception hata) {
                MessageBox.Show("İstenmiyen bir hata oluştu.Hata:" + hata);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_donor_islem_no.Text == "")
            {
                MessageBox.Show("Silme işleminin yapılabilmesi için silinmesi istenen kaydın donör işlem numarasını giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string mesaj = FizikIncelemeSinifi.Fizik_inceleme_sil(Convert.ToDouble(txt_donor_islem_no.Text));
                    dgw_FizikInceleme.DataSource = FizikIncelemeSinifi.FizikIncelemeGoster(donorno);
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Donör işlem numarasını kontrol ediniz(Donör işlem numarası sayılardan oluşur).", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(Exception hata) {
                    MessageBox.Show("İstenmiyen bir hata oluştu.Hata:"+hata);
                }
                
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_DonorFizikIncelemeGiris FizikIncelemeFormu = new frm_DonorFizikIncelemeGiris();
            FizikIncelemeFormu.txt_DonorNo.Text = txt_donor_islem_no.Text;
            this.Hide();
            FizikIncelemeFormu.Show();
        }

        private void txt_donor_islem_no_KeyPress(object sender, KeyPressEventArgs e)
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
