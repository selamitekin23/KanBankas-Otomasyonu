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
    public partial class frm_DonorIslemNumarasıKontrol : Form
    {
        public frm_DonorIslemNumarasıKontrol()
        {
            InitializeComponent();
        }
        cls_Testler Testler = new cls_Testler(); 
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_KanGirisFormu KanGiris = new frm_KanGirisFormu();
            this.Close();
            KanGiris.Show();
        }

        private void frm_DonorIslemNumarasıKontrol_Load(object sender, EventArgs e)
        {
            try
            {
                Testler.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
                dtg_Kanlar.DataSource = Testler.BeklemedekiKanGirisleri();
            }
            catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            if (txt_DonorNo.Text == "")
            {
                dtg_Kanlar.DataSource = Testler.BeklemedekiKanGirisleri();
            }
            else
            {
                try
                {
                    dtg_Kanlar.DataSource = Testler.DonorNoKanGirisOlumluBul(Convert.ToDouble(txt_DonorNo.Text));
                }
                catch (FormatException) { MessageBox.Show("Donör İşlem Numarası Sayılardan Oluşur."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : "+hata); }
            }
        }

        private void txt_DonorNo_KeyPress(object sender, KeyPressEventArgs e)
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
