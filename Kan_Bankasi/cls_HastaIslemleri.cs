using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Kan_Bankasi
{
    //HASTA  KAYDININ YAPILDIĞI SINIFIMIZDIR.METOTLARIN NE İŞ YAPTIĞI METOT İSİMLERİNDEN ANLAŞILMAKTADIR.
    class cls_HastaIslemleri
    {
        SqlDataAdapter da;
        public DataTable dt;
        SqlConnection baglanti;
        SqlCommand uygula;
        string mesaj="",sorgu;
        public void AdreseBaglan(string baglanilacak_adres)
        {
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();
      
        }

        public string HastaKaydet(double Tcno,string ad,string soyad,string cinsiyet,string ceptel,string adres,string il,string ilce,string Kangrubu,string k_adi,string tarih,string saat)
        {
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            da.SelectCommand.CommandText += "where TcNo='" + Tcno + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                mesaj =Tcno+ "TC Numarasına ait Kayıt Sistemde mevcuttur.TC Numarasını Kontrol Ediniz.";
            }
            else
            {
                sorgu = "INSERT INTO tbl_HastaBilgi(TcNo,Ad,Soyad,Cinsiyet,CepTel,Adres,Il,Ilce,KanGrubu,KayitYapan,Tarih,Saat) VALUES('" + Tcno + "','" + ad + "','" + soyad + "','" + cinsiyet + "','" + ceptel + "','" + adres + "','" + il + "','" + ilce + "','" + Kangrubu + "','" + k_adi + "','" + tarih + "','" + saat + "');";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = "Hasta Bilgileri Başarıyla Kaydedildi.";
            }
            return mesaj;
        }
        public string KullaniciBul(string kullanici)
        {
            //sisteme giriş yapılan kullanıci giris isminin kayıtlı olduğu kullanıcı ismini bulma
            string k_ad = "", k_soyad = "";
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where KullaniciAdi='" + kullanici + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow guncellenecek_veri = dt.Rows[0];
                k_ad = guncellenecek_veri[1].ToString();
                k_soyad = guncellenecek_veri[2].ToString();
            }
            k_ad = k_ad + "  " + k_soyad;
            return k_ad.ToUpper();
        }

        public DataTable kan_gruplarini_getir()
        {
            //sistemde kayıtlı kan gruplarını comboboxa aktarma
            DataTable kan_gruplari_tablosu = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kan_grubu_ismi\n";
            kan_gruplari_tablosu.Clear();
            da.Fill(kan_gruplari_tablosu);
            return kan_gruplari_tablosu;
        }
        public DataRow bulunan_veri;
        public bool HastaKontrol(double TcNo)
        {
            bool deger = false;
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            da.SelectCommand.CommandText += "where TcNo='" + TcNo + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                deger = true;
                bulunan_veri = dt.Rows[0];
            }
            return deger;
        }

        public string HastaGuncelle(double Tcno, string ad, string soyad, string cinsiyet, string ceptel, string adres, string il, string ilce, string Kangrubu, string k_adi, string tarih, string saat)
        {
            mesaj = Tcno+"Numarasına Ait Kayıt Sistem Veri Tabnında Bulunmamaktadır.";
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            da.SelectCommand.CommandText += "where TcNo='" + Tcno + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {               
                sorgu = "UPDATE tbl_HastaBilgi SET Ad='" + ad + "',Soyad='" + soyad + "',Cinsiyet='" + cinsiyet + "',CepTel='" + ceptel + "',Adres='" + adres + "',Il='" + il + "',Ilce='" + ilce + "',KanGrubu='" + Kangrubu + "',KayitYapan='" + k_adi + "',Tarih='" + tarih + "',Saat='" + saat + "' where TcNo='" + Tcno + "'";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = "Hasta Bilgileri Başarıyla Güncellenmiştir.";

            }

            return mesaj;
        }

        public string HastaSil(double tcno)
        {
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            da.SelectCommand.CommandText += "where TcNo='" + tcno + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                da.DeleteCommand.CommandText = "delete from tbl_HastaBilgi where  TcNo ='" + tcno + "'";
                veri_silme_bulu.Delete();
                da.Update(dt);
                dt.AcceptChanges();
                mesaj = " Hasta Kaydı Sistem Veri Tabanından Başarıyla Silindi.";
            }
            else
            {
                mesaj =tcno+ "Numarasına ait Hasta Kaydı Bulunmamaktadır..";
            }
            return mesaj;
        }

        public double HastaIslemNumarasi(double TcNo) {
            double h_numara = 0;
            bool deger=true;
            h_numara=(TcNo% 10000000);
            h_numara = h_numara * 3 + 1;
            while (deger)
            {
                da.SelectCommand = baglanti.CreateCommand();
                da.SelectCommand.CommandText = "Select * from tbl_KanStokCikisTakip\n";
                da.SelectCommand.CommandText += "where HastaIslemNo='" + h_numara + "'";
                dt.Clear();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    h_numara++;
                }
                else { deger = false; }
            }
            return h_numara;
        }

        public DataTable KanEslestirme(string KanGrubu) {
            DataTable Kanlar = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
            da.SelectCommand.CommandText += "where KanGrubu='" + KanGrubu + "'";
            Kanlar.Clear();
            da.Fill(Kanlar);
            return Kanlar;       
        }
        public DataTable TumKanlar()
        {
            DataTable Kanlar = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
            Kanlar.Clear();
            da.Fill(Kanlar);
            return Kanlar;
        }

        public void Onayla(double tcno, double hastaislemno, string hastaadi, string hastasoyadi, string polikilinik, string doktor, string hastakangrubu, double donorislemnumarasi, string donorad, string donorsoyad, string donorkangrubu, string k_adi, string tarih, string saat)
        {
            sorgu = "INSERT INTO tbl_KanStokCikisTakip(HastaTcNo,HastaIslemNo,HastaAdi,HastaSoyad,Polikilinik,Doktor,HastaKanGrubu,DonorIslemNo,DonorAd,DonorSoyad,DonorKanGrubu,KayitYapan,Tarih,Saat) VALUES('" + tcno + "','" + hastaislemno + "','" + hastaadi + "','" + hastasoyadi + "','" + polikilinik + "','" + doktor + "','" + hastakangrubu + "','" + donorislemnumarasi + "','" + donorad + "','" + donorsoyad + "','" + donorkangrubu + "','" + k_adi + "','" + tarih + "','" + saat + "');";
            uygula = new SqlCommand(sorgu, baglanti);
            uygula.ExecuteNonQuery();

            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
            da.SelectCommand.CommandText += "where DonorIslemNo='" + donorislemnumarasi + "'";
            dt.Clear();
            da.Fill(dt);
            DataRow veri_silme_bulu = dt.Rows[0];
            da.DeleteCommand = baglanti.CreateCommand();
            da.DeleteCommand.CommandText = "delete from tbl_KanStok where  DonorIslemNo ='" + donorislemnumarasi + "'";
            veri_silme_bulu.Delete();
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
