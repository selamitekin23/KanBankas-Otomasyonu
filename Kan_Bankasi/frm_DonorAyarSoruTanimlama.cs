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
    public partial class frm_DonorAyarSoruTanimlama : Form
    {
        frm_Kullanici_girisi kullanici_girisi = new frm_Kullanici_girisi();
        cls_donor_soru_olustur donor_soru = new cls_donor_soru_olustur();
        string mesaj;
        public frm_DonorAyarSoruTanimlama()
        {
            InitializeComponent();
        }
        //Tüm işlemler classımız olan donor soru olustur da hallediliyo
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Soru kaydı eklemesi
            if (txt_donor_soru_no.Text == "" || txt_soru.Text == "" || cb_cevap.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm Bilgileri Doldurmadan Kayıt Yapılamaz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    mesaj = donor_soru.soru_kaydet(Convert.ToInt16(txt_donor_soru_no.Text), txt_soru.Text, cb_cevap.Text);
                    dtg_sorular.DataSource = donor_soru.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_donor_sorular\n");
                    dtg_sorular.Sort(dtg_sorular.Columns[0], ListSortDirection.Ascending);
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                   
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontrol Ediniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
               
            }
          
        }

        private void frm_Donör_soru_tanımlama_formu_Load(object sender, EventArgs e)
        {
           
            try
            {
                dtg_sorular.EnableHeadersVisualStyles = false;
                dtg_sorular.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
                //KULLANICI GİRİS ADRESİ KULLANICI GİRİS FORMUNDAN ALINIYOR
                dtg_sorular.DataSource = donor_soru.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_donor_sorular\n");
                cb_cevap.Items.Add("EVET"); cb_cevap.Items.Add("HAYIR");
                dtg_sorular.Columns["DonorSoruNo"].HeaderText = "Soru Numarası";

                dtg_sorular.DefaultCellStyle.SelectionBackColor = Color.Green;
                dtg_sorular.DefaultCellStyle.SelectionForeColor = Color.White;
                dtg_sorular.Columns["Cevap"].DefaultCellStyle.ForeColor = Color.Red;
                dtg_sorular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtg_sorular.Sort(dtg_sorular.Columns[0], ListSortDirection.Ascending);
            }
            catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
       
        }

     

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //Silme işlemini gereçekleştiriyo
            if (txt_donor_soru_no.Text == "")
            {
                MessageBox.Show("Soru Numarası Girilmeden Silme İşlemi Gerçekleştirilemez.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mesaj = donor_soru.soru_sil(Convert.ToInt16(txt_donor_soru_no.Text));
                    dtg_sorular.DataSource = donor_soru.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_donor_sorular\n");
                    txt_donor_soru_no.Clear(); txt_soru.Clear();
                    dtg_sorular.Sort(dtg_sorular.Columns[0], ListSortDirection.Ascending);
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("Donor Soru Numarası Rakamlardan Oluşur.Donor Soru Numarasını Değiştiriniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //girilen değerleree göre sorunumarası baz alınarak değerler değiştiriliyo
            if (txt_donor_soru_no.Text == "" || txt_soru.Text == "" || cb_cevap.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm Bilgileri Doldurmadan Kayıt Yapılamaz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    mesaj = donor_soru.soru_guncelle(Convert.ToInt32(txt_donor_soru_no.Text), txt_soru.Text, cb_cevap.Text);
                    dtg_sorular.DataSource = donor_soru.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_donor_sorular\n");
                    dtg_sorular.Sort(dtg_sorular.Columns[0], ListSortDirection.Ascending);
                    MessageBox.Show(mesaj, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (FormatException) { MessageBox.Show("Girilen Değerleri Kontrol Ediniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }         
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            frm_Ayarlar Ayarlar = new frm_Ayarlar();
            this.Hide();
            Ayarlar.Show();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_donor_soru_no.Clear();
            txt_soru.Clear();
            cb_cevap.SelectedIndex = -1;
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            //soru numarasına göre veritabanından ilgili soru kontrolu yapılıyo
            if (txt_donor_soru_no.Text == "")
            {
                MessageBox.Show("Donör Soru Numarası Girilmeden Soru Kaydı Bulunmaz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool deger = donor_soru.soru_bul(Convert.ToInt16(txt_donor_soru_no.Text));
                    if (deger == true)
                    {
                        txt_soru.Text = donor_soru.soru;
                        if (donor_soru.cevap == "EVET ")
                            cb_cevap.SelectedIndex = 0;
                        else cb_cevap.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz soru nosuyla kayıtlı bilgi bulunmamaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    dtg_sorular.DataSource = donor_soru.goster(kullanici_girisi.baglanti_adresi, "Select * from tbl_donor_sorular\n");
                    dtg_sorular.Sort(dtg_sorular.Columns[0], ListSortDirection.Ascending);
                }
                catch (FormatException) { MessageBox.Show("Donor Soru Numarası Rakamlardan Oluşur.Donor Soru Numarasını Değiştiriniz."); }
                catch (Exception hata) { MessageBox.Show("İstenmiyen Bir Hata Oluştu. Hata İçeriği : " + hata); }
            }
        }

        private void txt_donor_soru_no_KeyPress(object sender, KeyPressEventArgs e)
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
