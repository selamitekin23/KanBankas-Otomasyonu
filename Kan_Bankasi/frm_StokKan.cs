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
    public partial class frm_StokKan : Form
    {
        public frm_StokKan()
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

        private void frm_StokKan_Load(object sender, EventArgs e)
        {
            try
            {
                Testler.baglan_adrese(kullanici_giris_formu.baglanti_adresi);
                dtg_kan.DataSource = Testler.StokKan();
            }
            catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata,"HATA OLUŞTU", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
