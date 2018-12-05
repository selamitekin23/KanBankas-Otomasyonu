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
    public partial class frm_CrossMatch : Form
    {
        public frm_CrossMatch()
        {
            InitializeComponent();
        }
        public double TcNo;
        cls_HastaIslemleri HastaIslemler = new cls_HastaIslemleri();
        DateTime zaman;
        frm_Kullanici_girisi kullanici_giris_formu = (frm_Kullanici_girisi)Application.OpenForms["frm_Kullanici_girisi"];
        frm_HastaIslemleri HastaIslemlerFormu = (frm_HastaIslemleri)Application.OpenForms["frm_HastaIslemleri"];
        cls_Testler TestSinifi = new cls_Testler();
        private void btn_Geri_Click(object sender, EventArgs e)
        {
            timer_bilgi.Enabled = false;
            this.Close();
            timer_bilgi.Enabled = false;
            HastaIslemlerFormu.Show();
        }

        private void frm_CrossMatch_Load(object sender, EventArgs e)
        {
            timer_bilgi.Enabled = true;
            
            HastaIslemler.AdreseBaglan(kullanici_giris_formu.baglanti_adresi);
            txt_KayitYapan.Text = HastaIslemler.KullaniciBul(kullanici_giris_formu.kullanici_adi);
            txt_hastaislemno.Text = HastaIslemler.HastaIslemNumarasi(TcNo).ToString();
        }

        private void timer_bilgi_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            txt_Tarih.Text = String.Format("{0:d}", zaman);
            txt_Saat.Text = String.Format("{0:t}", zaman);
        }

        private void btn_KanArama_Click(object sender, EventArgs e)
        {
            if (txt_polikilinik.Text == "" || txt_doktor.Text == "")
            {

                MessageBox.Show("Poliklinik yada Doktor İsmini Giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtg_kanlar.DataSource = HastaIslemler.KanEslestirme(lbl_HastaKanGrubu.Text);
                dtg_kanlar.Columns[1].Visible = false;
                dtg_kanlar.Columns[5].Visible = false;
                dtg_kanlar.Columns[8].Visible = false;
                dtg_kanlar.Columns[9].Visible = false;
                dtg_kanlar.Columns[10].Visible = false;
            }
        }


        private void dtg_kanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satır = dtg_kanlar.CurrentRow.Index;
            txt_DonorIslemNo.Text = Convert.ToString(dtg_kanlar.Rows[satır].Cells[0].Value);
            txt_Dad.Text = Convert.ToString(dtg_kanlar.Rows[satır].Cells[2].Value);
            txt_Dsoyad.Text = Convert.ToString(dtg_kanlar.Rows[satır].Cells[3].Value);
            lbl_DonorKanGrubu.Text = Convert.ToString(dtg_kanlar.Rows[satır].Cells[7].Value);
        }

        private void btn_TumKanlar_Click(object sender, EventArgs e)
        {
            if (txt_polikilinik.Text == "" || txt_doktor.Text == "")
            {

                MessageBox.Show("Poliklinik yada Doktor İsmini Giriniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dtg_kanlar.DataSource = HastaIslemler.TumKanlar();
            }
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            if (txt_DonorIslemNo.Text == "")
            {
                MessageBox.Show("Hasta İçin Uygun Donör Kaydını Seçiniz", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (lbl_DonorKanGrubu.Text == lbl_HastaKanGrubu.Text)
                {
                    if (MessageBox.Show("Hasta için Kan Çıkışını Onaylıyormusunuz?", "  ONAY ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        HastaIslemler.Onayla(TcNo, Convert.ToDouble(txt_hastaislemno.Text), txt_Had.Text, txt_Hsoyad.Text, txt_polikilinik.Text.ToUpper(), txt_doktor.Text.ToUpper(), lbl_HastaKanGrubu.Text, Convert.ToDouble(txt_DonorIslemNo.Text), txt_Dad.Text, txt_Dsoyad.Text, lbl_HastaKanGrubu.Text, txt_KayitYapan.Text, txt_Tarih.Text, txt_Saat.Text);
                        MessageBox.Show("Hasta İçin Kan Çıkış İşlemi Başarıyla Gerçekleştirildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dtg_kanlar.DataSource = HastaIslemler.KanEslestirme(lbl_HastaKanGrubu.Text);
                        temizle();
                    }
                    else {
                        MessageBox.Show("İşlem İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    if (MessageBox.Show("Hasta Kanı İle Seçilen Donör Kaydı Uyuşmamaktadır. Devam Etmek İstediğinizden Eminmisiniz?", "HASTA KAN GRUBU != DONÖR KAN GRUBU ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Hasta için Kan Çıkışını Onaylıyormusunuz?", "  ONAY ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            HastaIslemler.Onayla(TcNo, Convert.ToDouble(txt_hastaislemno.Text), txt_Had.Text, txt_Hsoyad.Text, txt_polikilinik.Text.ToUpper(), txt_doktor.Text.ToUpper(), lbl_HastaKanGrubu.Text, Convert.ToDouble(txt_DonorIslemNo.Text), txt_Dad.Text, txt_Dsoyad.Text, lbl_HastaKanGrubu.Text, txt_KayitYapan.Text, txt_Tarih.Text, txt_Saat.Text);
                            MessageBox.Show("Hasta İçin Kan Çıkış İşlemi Başarıyla Gerçekleştirildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dtg_kanlar.DataSource = HastaIslemler.KanEslestirme(lbl_HastaKanGrubu.Text);
                            temizle();
                        }
                        else {
                            MessageBox.Show("İşlem İptal Edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
        private void temizle() {
            txt_Dad.Clear();
            txt_DonorIslemNo.Clear();
            txt_Dsoyad.Clear();
            lbl_DonorKanGrubu.Text = "";
        
        }
   
    }
}
