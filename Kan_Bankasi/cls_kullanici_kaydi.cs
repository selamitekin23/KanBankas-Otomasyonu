using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Kan_Bankasi
{
    //KULLANICI KAYDININ YAPILDIĞI SINIFIMIZDIR.Kullanıcı bilgileri bu sınıfımızdan alınmaktadır.
    class cls_kullanici_kaydi
    {
        SqlDataAdapter da;
        public DataTable dt;
        SqlConnection baglanti;
        SqlCommand uygula;
        string sorgu, mesaj;
        public void baglan_adrese(string baglanilacak_adres)
        {
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();
        }
        //kullanıcı kayıt işlemi
        public string kullanici_kaydet(double tc_no, string ad, string soyad, string eposta, string cep, string kurum_adi, string brans, string adres, string il, string ilce, string kullanici_adi, double sifre)
        {
            //
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                mesaj = "TC numarasına ait kayıt sistemde mevcuttur";
            }
            else
            {
                da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
                da.SelectCommand.CommandText += "where KullaniciAdi='" + kullanici_adi + "'";
                dt.Clear();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    mesaj = "Bu kullanıcı adı sistemde mevcut farklı bir kullanıcı adı seçiniz.";
                }
                else
                {
                    sorgu = "INSERT INTO tbl_kullanici_bilgileri(TcNo,ad,soyad,Eposta,CepNo,KurumAdi,Brans,Adres,İl,İlce,KullaniciAdi,Sifre) VALUES('" + tc_no + "','" + ad + "','" + soyad + "','" + eposta + "','" + cep + "','" + kurum_adi + "','" + brans + "','" + adres + "','" + il + "','" + ilce + "','" + kullanici_adi + "','" + sifre + "');";
                    uygula = new SqlCommand(sorgu, baglanti);
                    uygula.ExecuteNonQuery();
                    mesaj = "Kullanıcı Kaydı Başarıyla Kaydedildi";
                }
            }
            return mesaj;
        }

        public string kullanici_sil(double tc_no)
        {
            string kullanici_ad;
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                kullanici_ad = veri_silme_bulu[10].ToString();
                da.DeleteCommand.CommandText = "delete from tbl_kullanici_bilgileri where  TcNo ='" + tc_no + "'";
                veri_silme_bulu.Delete();
                da.Update(dt);
                dt.AcceptChanges();
                mesaj = "Kullanıcı kaydı sistemden silindi.";
            }
            else
            {
                mesaj = "Bu TC numarasına ait kullanıcı kaydı bulunmamaktadır.";
            }
            return mesaj;
        }

        public string kullanici_guncelle(double tc_no, string ad, string soyad, string eposta, string cep, string kurum_adi, string brans, string adres, string il, string ilce, string kullanici_adi, double sifre)
        {
            double x; string k_adi;
            mesaj = "Sistemde bu TC numarasına ait kullanıcı bulunmamaktadır.";
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                k_adi= veri_silme_bulu[10].ToString();
                da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
                da.SelectCommand.CommandText += "where KullaniciAdi='" + k_adi + "'";
                dt.Clear();
                da.Fill(dt);
                veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                x=Convert.ToDouble(veri_silme_bulu[0]);
                if (dt.Rows.Count > 0 &&x!=tc_no)
                {
                    mesaj = "Bu kullanıcı adı sistemde mevcut farklı bir kullanıcı adı seçiniz.";
                }
                else
                {
                    sorgu = "UPDATE tbl_kullanici_bilgileri SET TcNo='" + tc_no + "',ad='" + ad + "',soyad='" + soyad + "',Eposta='" + eposta + "',CepNo='" + cep + "',KurumAdi='" + kurum_adi + "',Brans='" + brans + "',Adres='" + adres + "',İl='" + il + "',İlce='" + ilce + "',KullaniciAdi='" + kullanici_adi + "',Sifre='" + sifre + "' where TcNo='" + tc_no + "'";
                    uygula = new SqlCommand(sorgu, baglanti);
                    uygula.ExecuteNonQuery();
                    mesaj = "Sistemde kayıtlı kullanıcı kaydı güncellenmiştir.";
                }

            }

            return mesaj;
        }
        public  DataRow bulunan_veri ;
        public bool kullanici_bul(double tc_no)
        {
            bool sonuc = false;
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sonuc = true;
                bulunan_veri = dt.Rows[0];
            }
          
            return sonuc;
        }
    }
}
