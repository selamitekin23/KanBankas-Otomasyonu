using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Kan_Bankasi
{
    //DONÖR İŞLEMLERİNİN YAPILDIĞI SINIFTIR.
    class cls_DonorGirisi
    {
        SqlDataAdapter da;
        public DataTable dt;
        SqlConnection baglanti;
        SqlCommand uygula;
        string sorgu, mesaj;    
        double donor_no=0;
        public bool kayit_sonuc;
       // cls_giris_kontrol giris_sinifi = new cls_giris_kontrol();
        public void baglan_adrese(string baglanilacak_adres)
        {
            //baglanti metodum
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();
        }
        public string KullaniciBul(string kullanici) {
            //sisteme giriş yapılan kullanıci giris isminin kayıtlı olduğu kullanıcı ismini bulma
            string k_ad="", k_soyad="";
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
       
        public string donor_kaydet(double TcNo, double donorno, string ad, string soyad, string kan_grubu, string kan_verme_nedeni, string cinsiyet, string medeni_hali,double ev_tel ,double cep_tel ,string dogum_tarihi,string dogum_yeri,string baba_adi,string anne_adi,string meslegi,string eposta,string adres,string il,string ilce,string aciklama,string k_adi,string tarih,string zaman)
        {
           
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + TcNo + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kayit_sonuc = false;
                mesaj = TcNo+"  TC Numarasına ait kayıt sistemde mevcuttur.Lütfen TC numarasını kontrol ediniz.";
            }
            else
            {
                kayit_sonuc = true;
                sorgu = "INSERT INTO tbl_donor_bilgileri(TcNo,Ad,Soyad,DonorNo,KanGrubu,KanVermeNedeni,Cinsiyet,MedeniHali,DogumTarihi,DogumYeri,BabaAdi,AnaAdi,EvTelefonu,CepTelefonu,Meslegi,Eposta,IletisimAdresi,Il,Ilce,Aciklama,KayitYapan,Tarih,Saat) VALUES('" + TcNo + "','" + ad + "','" + soyad + "','" + donorno + "','" + kan_grubu + "','" + kan_verme_nedeni + "','" + cinsiyet + "','" + medeni_hali + "','" + dogum_tarihi + "','" + dogum_yeri + "','" + baba_adi + "','" + anne_adi + "','" + ev_tel + "','" + cep_tel + "','" + meslegi + "','" + eposta + "','" + adres + "','" + il + "','" + ilce + "','" + aciklama + "','" + k_adi + "','" + tarih + "','" + zaman + "');";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = "Donör bilgileri sistem veritabanına başarıyla kaydedildi.";
            }
            return mesaj;
        }
        public double donor_no_olustur(double tc_numarasi) {
            bool dogrula=true;
            donor_no = tc_numarasi % 10000000;
            while(dogrula){
             //donör numarası kullanıcının tc kimlik numarasının  mod 10000000 alınıpta oluşturuluyo eğer bu donor nosuna sahip başka kullanıcı varsa donor nosunu 1 arttrırıp tekrar kontrol ediliyo taki aynı donor numarasına sahip kullanıcı olmayıncaya kadar
           
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where DonorNo='" + donor_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dogrula=true;
                donor_no++;
            }else{
            dogrula=false;
            
            }
            
            }
          
           return donor_no;

        }
        public DataRow bulunan_veri;
        public bool tc_no_kontrol(double tc_numarasi) {
            //tc numarası kontrol edilip eğer daha önceden kan vermişse bilgiler bulunup textboxlara yazdırılıyo
            bool sonuc = false;
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_numarasi + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sonuc = true;
                bulunan_veri = dt.Rows[0];
            }

            return sonuc;        
        }
        
        public DataTable kan_gruplarini_getir() { 
        //sistemde kayıtlı kan gruplarını comboboxa aktarma
            DataTable kan_gruplari_tablosu=new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kan_grubu_ismi\n";
            kan_gruplari_tablosu.Clear();
            da.Fill(kan_gruplari_tablosu);
            return kan_gruplari_tablosu;
        }
        public string donor_guncelle(double TcNo, double donorno, string ad, string soyad, string kan_grubu, string kan_verme_nedeni, string cinsiyet, string medeni_hali, double ev_tel, double cep_tel, string dogum_tarihi, string dogum_yeri, string baba_adi, string anne_adi, string meslegi, string eposta, string adres, string il, string ilce, string aciklama, string k_adi, string tarih, string zaman)
        {
            //donör bilgilerini güncelleme metodu
            mesaj = TcNo + " TC Numarasına ait kayıt sistemde kayıtlı değildir.Tc numarasını kontrol ediniz.";
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + TcNo + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sorgu = "UPDATE tbl_donor_bilgileri SET Ad='" + ad + "',Soyad='" + soyad + "',KanGrubu='" + kan_grubu + "',KanVermeNedeni='" + kan_verme_nedeni + "',Cinsiyet='" + cinsiyet + "',MedeniHali='" + medeni_hali + "',DogumTarihi='" + dogum_tarihi + "',DogumYeri='" + dogum_yeri + "',BabaAdi='" + baba_adi + "',AnaAdi='" + anne_adi + "',EvTelefonu='" + ev_tel + "',CepTelefonu='" + cep_tel + "',Meslegi='" + meslegi + "',Eposta='" + eposta + "',IletisimAdresi='" + adres + "',Il='" + il + "',Ilce='" + ilce + "',Aciklama='" + aciklama + "',KayitYapan='" + k_adi + "',Tarih='" + tarih + "',Saat='" + zaman + "' where TcNo='" + TcNo + "'";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = TcNo + " TC Numarasına ait kayıt başarıyla güncellenmiştir.";

            }

            return mesaj;
        }
        public string donor_sil(double tc_no)
        {
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                da.DeleteCommand.CommandText = "delete from tbl_donor_bilgileri where  TcNo ='" + tc_no + "'";
                veri_silme_bulu.Delete();
                da.Update(dt);
                dt.AcceptChanges();
                mesaj = tc_no+" TC Numrasına ait kayıt başarıyla silindi.";
            }
            else
            {
                mesaj = tc_no+" TC Numarasına ait Donör kaydı sistemde bulunmamaktadır";
            }
            return mesaj;
        }
    }
}
