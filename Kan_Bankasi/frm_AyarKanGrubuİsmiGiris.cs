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
    public partial class frm_AyarKanGrubuİsmiGiris : Form
    {
        public frm_AyarKanGrubuİsmiGiris()
        {
            InitializeComponent();
        }
        frm_Kullanici_girisi kullanici_girisi = new frm_Kullanici_girisi();
        cls_kan_grubu_girisi kan_grubu = new cls_kan_grubu_girisi();
        string mesaj;
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_kan_grubu.Text == "")
            {
                MessageBox.Show("Kayıt Yapmak İstediğiniz Kan Grubu İsmini Giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mesaj = kan_grubu.kan_grubu_kaydet(txt_kan_grubu.Text);
                    dg_kan_grupları.DataSource = kan_grubu.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_kan_grubu_ismi\n");
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_kan_grubu.Clear();
                }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
        }

        private void frm_kan_grubu_girisi_formu_Load(object sender, EventArgs e)
        {
            try
            {
                dg_kan_grupları.DataSource = kan_grubu.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_kan_grubu_ismi\n");
            }
            catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_kan_grubu.Text == "")
            {
                MessageBox.Show("Silmek İstediğiniz Kan Grubu İsmini Giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mesaj = kan_grubu.kan_grubu_sil(txt_kan_grubu.Text);
                    dg_kan_grupları.DataSource = kan_grubu.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_kan_grubu_ismi\n");
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_kan_grubu.Clear();
                }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            frm_Ayarlar Ayarlar = new frm_Ayarlar();
            this.Hide();
            Ayarlar.Show();
        }
    }
}
