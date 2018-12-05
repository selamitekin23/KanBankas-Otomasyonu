using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Kan_Bankasi
{
    //TESTLER SINIFI DONÖRE UYGULANMASI GERKEN TESTLERİN YAPILMASI İÇİN TANIMLANMIŞTIR.EN ÖNEMLİ SINIFIMIZDIR 
    class cls_Testler
    {
        SqlDataAdapter da;
        public DataTable dt;
        SqlConnection baglanti;
        SqlCommand uygula;
        public double donor_numarasi = 0;
        public double donor_islem_numarasi = 0;
        public string KanGrubu;
        public DataRow bulunan_veri;
        public string ad, soyad, mesaj, sorgu, bos_testler;
        public void baglan_adrese(string baglanilacak_adres)
        {
            //baglanti metodum
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();
        
        }
        public void tc_no_kontrol(double tc_numarasi)
        {
            //tc numarası kontrol edilip donör numarası,ad,soyad bilgileri alınıyo          
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tc_numarasi + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                bulunan_veri = dt.Rows[0];
                ad = bulunan_veri[1].ToString();
                soyad = bulunan_veri[2].ToString();
                donor_numarasi =Convert.ToDouble (bulunan_veri[3]);
            }
  
        }
        public string donor_islem_no_olustur(string talep) {
            //donör işlem numarası hatası
            donor_islem_numarasi = donor_numarasi * 2 + 1000;
            bool dogrula = true;
            double donorIno = 0;
            mesaj = "";
            bos_testler = "";
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
            da.SelectCommand.CommandText += "where DonorNo='" + donor_numarasi + "'";
            dt.Clear();
            da.Fill(dt);
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                               
                    bulunan_veri = dt.Rows[i];
                    
                    if ((bulunan_veri["FizikSonuc"].ToString() == "OLUMLU(+)" || bulunan_veri["FizikSonuc"].ToString() == "OLUMSUZ(-)") && (bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMLU(+)" || bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMSUZ(-)") && (bulunan_veri["TestSonuc"].ToString() == "OLUMLU(+)" || bulunan_veri["TestSonuc"].ToString() == "OLUMSUZ(-)") && (bulunan_veri["KanGirisi"].ToString() == "ALINDI" || bulunan_veri["KanGirisi"].ToString() == "KanAlımıUygunDegil"))
                    {
                        dogrula = true; 
                        donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]);
                        //donor_islem_numarasi++;
                    }
                    else
                    {
                        //DONÖR İŞLEM NUMARASINI YAPILMAYAN TESTLERE GÖRE OLUŞTURMAK İÇİN TEST SONUÇLARININ KONTROL EDİLMESİ GEREKİR 
                        //BU İŞLEM İÇİN OLUMLU YADA OLUMSUZ OLAN TESTLERDE HER TEST YAPILMIŞSA YENİ BİR TEST NUMARASI VERİLİYO EĞER HER TEST YAPILMADIYSA TEST NUMARASI VERİLMİYO YAPILMAYAN TEST NUMARASI BULUNUP BU TESTLERİN YAPILMASI OPERATÖRDEN İSTENİYO
                        if (bulunan_veri["KanGirisi"].ToString() == "ALINMADI")
                        {
                            //kan girişi alınmamışsa kullanıcı uyarılarak kan girişinin yapılmadan yeni bir işlem yapılamayacağı belirtiliyo
                            mesaj = "Daha Önceden Yapılan Testler Sonucunda Alınan Kan Girişi Yapılmadığından Yeni Bir İnceleme Kaydı Başlatılamıyor.";
                            dogrula = false;
                            donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]); i = dt.Rows.Count;
                        }
                        else
                        {

                            if (talep == "DonörFizikİnceleme" && ((bulunan_veri["FizikSonuc"].ToString() == "OLUMSUZ(-)") || (bulunan_veri["FizikSonuc"].ToString() == "OLUMLU(+)")))
                            {
                                i = dt.Rows.Count;
                                donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]);
                                if (bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMSUZ(-)" || bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMLU(+)")
                                { }
                                else { bos_testler += "\n-BİLGİ TESTİ"; }
                                if (bulunan_veri["TestSonuc"].ToString() == "OLUMSUZ(-)" || bulunan_veri["TestSonuc"].ToString() == "OLUMLU(+)")
                                { }
                                else { bos_testler += "\n-TEST SONUÇLARI"; }
                                dogrula = false;
                                mesaj = "Yeni Bir Donör Fizik İnceleme Kaydı Yapılması için Donöre ait Tüm Testlerin Yapılması Gerekir.\nKayıt Edilmesi Gereken TESTLER: " + bos_testler;
                            }
                            else
                            {
                                donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]);
                                dogrula = false; i = dt.Rows.Count;
                            }

                            //************************//******************************///

                            if (talep == "DonorBilgiTest" && ((bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMSUZ(-)") || (bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMLU(+)")))
                            {
                                i = dt.Rows.Count;
                                donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]);
                                if (bulunan_veri["FizikSonuc"].ToString() == "OLUMSUZ(-)" || bulunan_veri["FizikSonuc"].ToString() == "OLUMLU(+)")
                                { }
                                else { bos_testler += "\n-FİZİK İNCELEME"; }


                                if (bulunan_veri["TestSonuc"].ToString() == "OLUMSUZ(-)" || bulunan_veri["TestSonuc"].ToString() == "OLUMLU(+)")
                                { }
                                else { bos_testler += "\n-TEST SONUÇLARI"; }


                                dogrula = false;
                                mesaj = "Yeni Bir Donör Bilgi Formu Kaydı Yapılması için Donöre ait Tüm Testlerin Yapılması Gerekir.\nKayıt Edilmesi Gereken TESTLER:" + bos_testler;


                            }
                            else
                            {
                                donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]);
                                dogrula = false; i = dt.Rows.Count;
                            }

                            //***************************//******************///****************////

                            if (talep == "DonorTestİşlemleri" && ((bulunan_veri["TestSonuc"].ToString() == "OLUMSUZ(-)") || (bulunan_veri["TestSonuc"].ToString() == "OLUMLU(+)")))
                            {
                                i = dt.Rows.Count;
                                donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]);
                                if (bulunan_veri["FizikSonuc"].ToString() == "OLUMSUZ(-)" || bulunan_veri["FizikSonuc"].ToString() == "OLUMLU(+)")
                                { }
                                else { bos_testler += "\n-FİZİK İNCELEME"; }


                                if (bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMSUZ(-)" || bulunan_veri["BilgiFormuSonuc"].ToString() == "OLUMLU(+)")
                                { }
                                else { bos_testler += "\n-BİLGİ TESTİ"; }

                                dogrula = false;
                                mesaj = "Yeni Bir Donör Test Kaydının Yapılması için Donöre ait Tüm Testlerin Yapılması Gerekir.\nKayıt Edilmesi Gereken TESTLER:" + bos_testler;

                            }
                            else { donorIno = Convert.ToDouble(bulunan_veri["DonorIslemNo"]); dogrula = false; i = dt.Rows.Count; }
                        }
                    }
            }

            if (dogrula == true)
            {
                donor_islem_numarasi = donor_numarasi * 2 + 1000;

                da.SelectCommand = baglanti.CreateCommand();
                da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
                dt.Clear();
                da.Fill(dt);
                for (int i = 0; dt.Rows.Count > i; )
                {
                    bulunan_veri = dt.Rows[i];
                    if (donor_islem_numarasi == Convert.ToDouble(bulunan_veri["DonorIslemNo"]))
                    {
                        i = 0; donor_islem_numarasi++;

                    }
                    else { i++; }
                }

            }
            else { donor_islem_numarasi = donorIno; }
           
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
      public void fizik_inceleme_kaydet(double donorno,double donorislemno, string ad, string soyad,double ates,int nabiz,double agirlik,int boy,int tansiyonbuyuk,int tansiyonkucuk,double hct,double hgb,int wbc,int plt,string aciklama,string sonuc,string k_adi,string tarih,string zaman)
         {
             string ates_f, agirlik_f, hct_f, hgb_f; 
             ates_f = Convert.ToString(ates); agirlik_f = Convert.ToString(agirlik); hgb_f = Convert.ToString(hgb); hct_f = Convert.ToString(hct);
             ates_f = ates_f.Replace(",", ".");
             agirlik_f = agirlik_f.Replace(",", ".");
             hct_f = hct_f.Replace(",", ".");
             hgb_f = hgb_f.Replace(",", ".");
             sorgu = "INSERT INTO tbl_FizikIncelemeKayitlari(DonorNo,DonorIslemNo,Ad,Soyad,Ates,Nabiz,Agirlik,Boy,TansiyonBuyuk,TansiyonKucuk,HCT,HGB,WBC,PLT,Aciklama,Sonuc,KayitYapan,Tarih,Saat) VALUES('" + donorno + "','" + donorislemno + "','" + ad + "','" + soyad + "','" + ates_f +" ','" + nabiz + "','" + agirlik_f + "','" + boy + "','" + tansiyonbuyuk + "','" + tansiyonkucuk + "','" + hct_f + "','" + hgb_f + "','" + wbc + "','" + plt + "','" + aciklama + "','" + sonuc + "','" + k_adi + "','" + tarih + "','" + zaman + "');";
             uygula = new SqlCommand(sorgu, baglanti);
             uygula.ExecuteNonQuery();

             //donor kan verme sonuça da kayıt ekleniyo bu sayede kullanıcı programı yarıda kapatsa bile diğer testleride yapabilir
             da.SelectCommand = baglanti.CreateCommand();
             da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
             da.SelectCommand.CommandText += "where DonorNo='" + donor_numarasi + "'and DonorIslemNo='" + donor_islem_numarasi + "'";
             dt.Clear();
             da.Fill(dt);
             if (dt.Rows.Count > 0)
             {
                 sorgu = "UPDATE tbl_DonorKanVermeSonuc SET FizikSonuc='" + sonuc + "' where DonorNo=" + donorno + "and DonorIslemNo=" + donorislemno + "";
                 uygula = new SqlCommand(sorgu, baglanti);
                 uygula.ExecuteNonQuery();
             }
             else {
                 sorgu = "INSERT INTO tbl_DonorKanVermeSonuc(DonorNo,DonorIslemNo,FizikSonuc) VALUES('" + donorno + "','" + donorislemno + "','" + sonuc + "');";
                 uygula = new SqlCommand(sorgu, baglanti);
                 uygula.ExecuteNonQuery();
             }
             
         }
      public DataTable FizikIncelemeGoster(double donorno)
      {
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_FizikIncelemeKayitlari\n";
          da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'";
          dt.Clear();
          da.Fill(dt);
          return dt;
      }
      public string Fizik_inceleme_sil(double donorislemno)
      {
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_FizikIncelemeKayitlari\n";
          da.SelectCommand.CommandText += "where DonorIslemNo='" + donorislemno + "'";
          dt.Clear();
          da.Fill(dt);
          if (dt.Rows.Count > 0)
          {
              DataRow veri_silme_bulu = dt.Rows[0];
              da.DeleteCommand = baglanti.CreateCommand();
              da.DeleteCommand.CommandText = "delete from tbl_FizikIncelemeKayitlari where  DonorIslemNo ='" + donorislemno + "'";
              veri_silme_bulu.Delete();
              da.Update(dt);
              dt.AcceptChanges();
              mesaj = donorislemno + " Numrasına ait kayıt başarıyla silindi.";
          }
          else
          {
              mesaj = donorislemno + " Numarasına ait Donör işlem  kaydı sistemde bulunmamaktadır";
          }
          return mesaj;
      }

      //Donör bilgi formunda sorulacak soruları veritabanından alma
      public DataTable SorulariAl() {
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_donor_sorular\n";
          dt.Clear();
          da.Fill(dt);
          return dt;
      }

        //Donör soru cevaplarının veritabana kaydedilmesi
      public void BilgiSorularininCevaplarini_Kaydet(double DonorNo, double DonorIslemNo, string[,] sorularvecevaplar, int uzunluk, string k_adi, string tarih, string saat)
      {

          for (int i = 0; uzunluk > i; i++) {
              sorgu = "INSERT INTO tbl_BilgiSorulariDonorCevap(DonorNO,DonorIslemNo,SoruNo,Soru,Cevap,KayitYapan,Tarih,Saat) VALUES('" + DonorNo + "','" + DonorIslemNo + "','" + (i + 1) + "','" + sorularvecevaplar[i, 0] + "','" + sorularvecevaplar[i, 1] + " ','" + k_adi + "','" + tarih + "','" + saat + "');";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();                  
          }
      
      
      }
      public void BilgiSoruSonuc(double donorno,double donorislemno,string sonuc)
      {
          //Bilgi sonucunun  donor kan verme sonuc tablosuna ekleme
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
          da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'and DonorIslemNo='" + donorislemno + "'";
          dt.Clear();
          da.Fill(dt);
          if (dt.Rows.Count > 0)
          {
              sorgu = "UPDATE tbl_DonorKanVermeSonuc SET BilgiFormuSonuc='" + sonuc + "' where DonorNo=" + donorno + "and DonorIslemNo=" + donorislemno + "";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
          }
          else
          {
              sorgu = "INSERT INTO tbl_DonorKanVermeSonuc(DonorNo,DonorIslemNo,BilgiFormuSonuc) VALUES('" + donorno + "','" + donorislemno + "','" + sonuc + "');";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
          }

      }

        //DONÖR TEST KAYITLARININ YAPILMASI
      public void DonorTestKaydet(double donorno,double donorislemno,string ad,string soyad,string hepatitB,string hepatitC,string aids,string frengi,string kan_grubu,string sonuc,string k_adi,string tarih,string saat) {
          sorgu = "INSERT INTO tbl_DonorTestSonuc(DonorNo,DonorIslemNo,Ad,Soyad,HepatitB,HepatitC,Aids,KanGrubu,Frengi,Sonuc,KayitYapan,Tarih,Saat) VALUES('" + donorno + "','" + donorislemno + "','" + ad + "','" + soyad + "','" + hepatitB + "','" + hepatitC + "','" + aids + "','" + kan_grubu + "','" + frengi + "','" + sonuc + "','" + k_adi + "','" + tarih + "','" + saat + "');";
          uygula = new SqlCommand(sorgu, baglanti);
          uygula.ExecuteNonQuery();      
      }
      public void TestSonucYazma(double donorno, double donorislemno, string sonuc)
      {
          //TEST SONUCLARININ donor kan verme sonuc tablosuna ekleme
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
          da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'and DonorIslemNo='" + donorislemno + "'";
          dt.Clear();
          da.Fill(dt);
          if (dt.Rows.Count > 0)
          {
              sorgu = "UPDATE tbl_DonorKanVermeSonuc SET TestSonuc='" + sonuc + "' where DonorNo=" + donorno + "and DonorIslemNo=" + donorislemno + "";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
          }
          else
          {
              sorgu = "INSERT INTO tbl_DonorKanVermeSonuc(DonorNo,DonorIslemNo,TestSonuc) VALUES('" + donorno + "','" + donorislemno + "','" + sonuc + "');";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
          }

      }

      //donöre ait tüm testler yapıldıktan sonra testlerin sonucuna göre kan alınıp alınmayacağının belirlenmesi
      public bool GenelSonuc(double donorno) {
          string sonuc; bool islem = false;
          string alinma="";
          DataRow GenelSonucVerisi;
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
          da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'";
          dt.Clear();
          da.Fill(dt); 
          for (int i = 0; dt.Rows.Count > i; i++) {
               GenelSonucVerisi = dt.Rows[i];
               if ((GenelSonucVerisi["FizikSonuc"].ToString() == "OLUMLU(+)" || GenelSonucVerisi["FizikSonuc"].ToString() == "OLUMSUZ(-)") && (GenelSonucVerisi["BilgiFormuSonuc"].ToString() == "OLUMLU(+)" || GenelSonucVerisi["BilgiFormuSonuc"].ToString() == "OLUMSUZ(-)") && (GenelSonucVerisi["TestSonuc"].ToString() == "OLUMLU(+)" || GenelSonucVerisi["TestSonuc"].ToString() == "OLUMSUZ(-)") && (GenelSonucVerisi["GenelSonuc"].ToString() != "OLUMLU(+)" && GenelSonucVerisi["GenelSonuc"].ToString() != "OLUMSUZ(-)"))
               {

                   if ((GenelSonucVerisi["FizikSonuc"].ToString() == "OLUMLU(+)") && (GenelSonucVerisi["BilgiFormuSonuc"].ToString() == "OLUMLU(+)") && (GenelSonucVerisi["TestSonuc"].ToString() == "OLUMLU(+)"))
                   {
                       alinma = "ALINMADI";
                       sonuc = "OLUMLU(+)";
                       sorgu = "UPDATE tbl_DonorKanVermeSonuc SET GenelSonuc='" + sonuc + "',KanGirisi='" + alinma + "' where DonorNo=" + donorno + "and DonorIslemNo=" + GenelSonucVerisi["DonorIslemNo"] + "";
                       uygula = new SqlCommand(sorgu, baglanti);
                       uygula.ExecuteNonQuery();
                       donor_islem_numarasi = Convert.ToDouble(GenelSonucVerisi["DonorIslemNo"]);
                   }
                   else
                   {
                       alinma = "KanAlımıUygunDegil";
                       sonuc = "OLUMSUZ(-)";
                       sorgu = "UPDATE tbl_DonorKanVermeSonuc SET GenelSonuc='" + sonuc + "',KanGirisi='" + alinma + "' where DonorNo=" + donorno + "and DonorIslemNo=" + GenelSonucVerisi["DonorIslemNo"] + "";
                       uygula = new SqlCommand(sorgu, baglanti);
                       uygula.ExecuteNonQuery();
                   }

               }
               else { 
               
               }
               
              if (GenelSonucVerisi["KanGirisi"].ToString() == "ALINMADI")
              {
                  donor_islem_numarasi = Convert.ToDouble(GenelSonucVerisi["DonorIslemNo"]);
                  islem = true;

              }
              if (alinma == "ALINMADI")
              {
                  islem = true;

              }




          }
          return islem;
      }

     //KAN GİRİŞ KISMI
      public bool KanGirisBilgiGetir(double DonorIslemNo) {
          //KanGiriş bilgileri getirme
          bool dogrula = true;
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
          da.SelectCommand.CommandText += "where DonorIslemNo='" + DonorIslemNo + "'and KanGirisi='" + "ALINMADI" + "'";
          dt.Clear();
          da.Fill(dt);
          if (dt.Rows.Count > 0)
          {
              da.SelectCommand = baglanti.CreateCommand();
              da.SelectCommand.CommandText = "Select * from tbl_DonorTestSonuc\n";
              da.SelectCommand.CommandText += "where DonorIslemNo='" + DonorIslemNo + "'";
              dt.Clear();
              da.Fill(dt);
              if (dt.Rows.Count > 0)
              {
                  DataRow bulunan_veri = dt.Rows[0];
                  donor_numarasi = Convert.ToDouble(bulunan_veri["DonorNo"]);
                  ad = bulunan_veri["Ad"].ToString();
                  soyad = bulunan_veri["Soyad"].ToString();
                  KanGrubu = bulunan_veri["KanGrubu"].ToString();
              }
          }
          else
          {
              dogrula = false;
          }
          return dogrula;
      
      
      }
      public DataTable BeklemedekiKanGirisleri() {
          //beklemede olan donör kan girişlerini gösterme
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
          da.SelectCommand.CommandText += "where KanGirisi='" + "ALINMADI" + "'";
          dt.Clear();
          da.Fill(dt);
          return dt;      
      }
      public DataTable DonorNoKanGirisOlumluBul(double donorno)
      {
          //DONOR NOYA GÖRE BEKLEME OLAN KAN GİRİŞ KAYITLARINI GÖSTERME
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_DonorKanVermeSonuc\n";
          da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'and KanGirisi='" + "ALINMADI" + "'";
          dt.Clear();
          da.Fill(dt);
          return dt;     
      }
      public DataTable StokKan()
      {
          //stoğa girmiş kan kayıtları
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
          dt.Clear();
          da.Fill(dt);
          return dt;
      }
      public DataTable DonorStokKan(double donorno)
      {
          //stoğa girmiş kan kayıtları donor formunda gösterme
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
          da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'";
          dt.Clear();
          da.Fill(dt);
          return dt;
      }
      public string KanGirisKayit(double donorno,double donorislemno,string ad,string soyad,string islemtarihi,string islemsaati,string sonkullanmatarihi,string kangrubu,string k_adi,string tarih,string saat) {
        
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
          da.SelectCommand.CommandText += "where DonorIslemNo='" + donorislemno + "'";
          dt.Clear();
          da.Fill(dt);
          if (dt.Rows.Count > 0)
          {
              mesaj = donorislemno+" Donör İşlem Numarasına Ait Kan Girişi Daha Önceden Yapılmıştır.Donör İşlem Numaranızı Kontrol Ediniz.";
          }
          else
          {
              sorgu = "INSERT INTO tbl_KanStok(DonorNo,DonorIslemNo,Ad,Soyad,IslemTarihi,IslemSaati,SonKullanmaTarihi,KanGrubu,KayitYapan,Tarih,Saat) VALUES('" + donorno + "','" + donorislemno + "','" + ad + "','" + soyad + "','" + islemtarihi + "','" + islemsaati + "','" + sonkullanmatarihi + "','" + kangrubu + "','" + k_adi + "','" + tarih + "','" + saat + "');";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
              mesaj = "Sistem Veri Tabanı'na Kaydedildi.";
              //kayıt yapıldığından DONOR KAN VERME SONUÇ KISMINDA KANGİRİŞ KISMINIDA GÜNCELLEMEMİZ GEREKİYOR ALINDI DİYE
              sorgu = "UPDATE tbl_DonorKanVermeSonuc SET KanGirisi='" + "ALINDI" + "' where DonorNo=" + donorno + "and DonorIslemNo=" + donorislemno + "";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
          }
          
          
          return mesaj;
      
      
      }

      public string KanGirisSil(double donorislemno) {
          da.SelectCommand = baglanti.CreateCommand();
          da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
          da.SelectCommand.CommandText += "where DonorIslemNo='" + donorislemno + "'";
          dt.Clear();
          da.Fill(dt);
          if (dt.Rows.Count > 0)
          {
              DataRow veri_silme_bulu = dt.Rows[0];
              da.DeleteCommand = baglanti.CreateCommand();
              da.DeleteCommand.CommandText = "delete from tbl_KanStok where  DonorIslemNo ='" + donorislemno + "'";
              veri_silme_bulu.Delete();
              da.Update(dt);
              dt.AcceptChanges();
              mesaj = donorislemno+" Ait Kan Giriş Kaydı Silindi.";
              //kayıt yapıldığından DONOR KAN VERME SONUÇ KISMINDA KANGİRİŞ KISMINIDA GÜNCELLEMEMİZ GEREKİYOR ALINDI DİYE
              sorgu = "UPDATE tbl_DonorKanVermeSonuc SET KanGirisi='" + "ALINMADI" + "' where DonorIslemNo=" + donorislemno + "";
              uygula = new SqlCommand(sorgu, baglanti);
              uygula.ExecuteNonQuery();
          }
          else
          {
              mesaj =donorislemno+ " Ait Kan Giriş Kaydı Bulunamamaktadır.";
          }
          return mesaj;
      }
    }
}
