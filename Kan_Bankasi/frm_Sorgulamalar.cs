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
    public partial class frm_Sorgulamalar : Form
    {
        public frm_Sorgulamalar()
        {
            InitializeComponent();
        }
        cls_Sorgulama Sorgulamalar = new cls_Sorgulama();
        frm_Kullanici_girisi KullaniciGirisi = new frm_Kullanici_girisi();
        private void tab_hasta_Click(object sender, EventArgs e)
        {
           
        }

        private void tab_hasta_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Sorgulamalar.baglan(KullaniciGirisi.baglanti_adresi);
                dtg_hasta.DataSource = Sorgulamalar.HastaKayitlari();
                dtg_Donor.DataSource = Sorgulamalar.DonorKayitlari();
                dtg_Kan.DataSource = Sorgulamalar.KanKayitlari();
                dtg_StokCikis.DataSource = Sorgulamalar.StokCikisKayitlari();
                dtg_Kullanicilar.DataSource = Sorgulamalar.Kullanicilar();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void frm_Sorgulamalar_Load(object sender, EventArgs e)
        {
            try
            {
                Sorgulamalar.baglan(KullaniciGirisi.baglanti_adresi);
                kan_gruplarini_yaz();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            frm_AnaKontrol AnaKontrol = new frm_AnaKontrol();
            this.Hide();
            AnaKontrol.Show();
        }

        private void btn_HtumKayitlar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_hasta.DataSource = Sorgulamalar.HastaKayitlari();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void btn_DtumKayitlar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Donor.DataSource = Sorgulamalar.DonorKayitlari();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void btn_KanTumKayit_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Kan.DataSource = Sorgulamalar.KanKayitlari();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void btn_HtcnoAra_Click(object sender, EventArgs e)
        {
            if (txt_Htcno.Text == "")
            {
                MessageBox.Show("TC Numarasını Giriniz.");
            }
            else
            {
                try
                {
                    dtg_hasta.DataSource = Sorgulamalar.H_TcNoAra(Convert.ToDouble(txt_Htcno.Text));
                    if (Sorgulamalar.deger == false) { MessageBox.Show(txt_Htcno.Text + " TC Numarasına Ait Sistemde Kayıt Bulunmamaktadır."); }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : "+hata); }
            }
        }

        private void kan_gruplarini_yaz()
        {
            //sistem veritabanında kayıtlı olan kan gruparını comboboxa aktarma
            try
            {
                DataTable kan = Sorgulamalar.kan_gruplarini_getir();
                DataRow al;
                for (int i = 0; kan.Rows.Count > i; i++)
                {
                    al = kan.Rows[i];
                    cmb_DkanGrubu.Items.Add(al[0]);
                    cmb_Hkangrubu.Items.Add(al[0]);
                    cmbKkanGrubu.Items.Add(al[0]);
                    cmb_StokCikisKanGrubu.Items.Add(al[0]);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kan Gruplarını yazarken hata oluştu.Hata:" + hata);
            }
        }

        private void btn_HkangrubuAra_Click(object sender, EventArgs e)
        {
            if (cmb_Hkangrubu.SelectedIndex == -1)
            {
                MessageBox.Show("Kan Grubu Seçiniz.");
            }
            else
            {
                try{
                dtg_hasta.DataSource = Sorgulamalar.H_KanGrubuAra(cmb_Hkangrubu.Text);
                if (Sorgulamalar.deger == false) { MessageBox.Show(cmb_Hkangrubu.Text + " Kan Grubuna Ait Sistemde Kayıt Bulunmamaktadır.");
                }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btn_Dara_Click(object sender, EventArgs e)
        {
            if (txt_DtcNo.Text == "")
            {
                MessageBox.Show("TC Numarasını Giriniz.");
            }
            else
            {
                try
                {
                    dtg_Donor.DataSource = Sorgulamalar.D_TcNoAra(Convert.ToDouble(txt_DtcNo.Text));
                    if (Sorgulamalar.deger == false) { MessageBox.Show(txt_DtcNo.Text + " TC Numarasına Ait Sistemde Kayıt Bulunmamaktadır."); }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btn_DkanGrubu_Click(object sender, EventArgs e)
        {
            if (cmb_DkanGrubu.SelectedIndex == -1)
            {

                MessageBox.Show("Kan Grubu Seçiniz.");
            }
            else
            {
                try
                {
                    dtg_Donor.DataSource = Sorgulamalar.D_KanGrubuAra(cmb_DkanGrubu.Text);
                    if (Sorgulamalar.deger == false) { MessageBox.Show(cmb_DkanGrubu.Text + " Kan Grubuna Ait Sistemde Kayıt Bulunmamaktadır."); }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btnKanAraDonorNo_Click(object sender, EventArgs e)
        {
            if (txt_KdonorNo.Text == "") {

                MessageBox.Show("Donor Numarasını Giriniz");
            }else{
                try
                {
                    dtg_Kan.DataSource = Sorgulamalar.K_DonorNoAra(Convert.ToDouble(txt_KdonorNo.Text));
                    if (Sorgulamalar.deger == false)
                    {
                        MessageBox.Show(txt_KdonorNo.Text + " Donor Numarasına Ait Sistemde Kayıt Bulunmamaktadır.");
                    }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btnKanARAcmb_Click(object sender, EventArgs e)
        {
            if (cmbKkanGrubu.SelectedIndex == -1)
            {
                MessageBox.Show("Kan Grubu Seçiniz.");
            }
            else
            {
                try
                {
                    dtg_Kan.DataSource = Sorgulamalar.K_KanGrubuAra(cmbKkanGrubu.Text);
                    if (Sorgulamalar.deger == false) { MessageBox.Show(cmbKkanGrubu.Text + " Kan Grubuna Ait Sistemde Kayıt Bulunmamaktadır."); }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btn_StokCikisTumKayitlar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_StokCikis.DataSource = Sorgulamalar.StokCikisKayitlari();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void btn_StokCikisAraTc_Click(object sender, EventArgs e)
        {
            if (txt_StokCikisTC.Text == "")
            {
                MessageBox.Show("TC Numarasını Giriniz.");
            }
            else
            {
                try
                {
                    dtg_StokCikis.DataSource = Sorgulamalar.StokCikis_TcNoAra(Convert.ToDouble(txt_StokCikisTC.Text));
                    if (Sorgulamalar.deger == false)
                    {
                        MessageBox.Show(txt_KdonorNo.Text + " Numarasına Ait Sistemde Kayıt Bulunmamaktadır.");
                    }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btn_StokCikisKangrubuAra_Click(object sender, EventArgs e)
        {
            if (cmb_StokCikisKanGrubu.Text == "")
            {
                MessageBox.Show("Kan Grubu Seçiniz.");
            }
            else
            {
                try
                {
                    dtg_StokCikis.DataSource = Sorgulamalar.StokCikis_KanGrubuAra(cmb_StokCikisKanGrubu.Text);
                    if (Sorgulamalar.deger == false)
                    {
                        MessageBox.Show(cmbKkanGrubu.Text + " Kan Grubuna Ait Sistemde Kayıt Bulunmamaktadır.");
                    }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btn_KullaniciBul_Click(object sender, EventArgs e)
        {
            if (txt_KullaniciTCno.Text == "")
            {
                MessageBox.Show("Tc Numarasını Giriniz.");
            }
            else
            {
                try
                {
                    dtg_Kullanicilar.DataSource = Sorgulamalar.KullaniciTcnoAra(Convert.ToDouble(txt_KullaniciTCno.Text));
                    if (Sorgulamalar.deger == false)
                    {
                        MessageBox.Show(cmbKkanGrubu.Text + " Tc Numarasına Ait Sistemde Kayıtlı Kullanıcı Kaydı Bulunmamaktadır.");
                    }
                }
                catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
            }
        }

        private void btn_TumKullanıcılar_Click(object sender, EventArgs e)
        {
            try
            {
                dtg_Kullanicilar.DataSource = Sorgulamalar.Kullanicilar();
            }
            catch (Exception hata) { MessageBox.Show("İstanmiyen Bir Hata Oluştu. Hatanın İçeriği : " + hata); }
        }

        private void txt_Htcno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_DtcNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_KdonorNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_StokCikisTC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_KullaniciTCno_KeyPress(object sender, KeyPressEventArgs e)
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
