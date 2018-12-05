using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Kan_Bankasi
{
    //DONÖRE SORULACAK SORULARIN KAYDININ YAPILDIĞI SINIFTIR.
    class cls_donor_soru_olustur
    {
        SqlDataAdapter da;
        public DataTable dt;
        SqlConnection baglanti;
        SqlCommand uygula;
        string sorgu, mesaj;
        public string soru, cevap;
        public DataTable goster(string baglanilacak_adres, string baglanilacak_tablo)
        {
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = baglanilacak_tablo;
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        public string soru_kaydet(int soru_no,string soru,string cevap)
        {

            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_sorular\n";
            da.SelectCommand.CommandText += "where DonorSoruNo='" + soru_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                mesaj = "Bu soru nosuyla kayıtlı soru bulunmaktadır.Lütfen soru nosunu değiştiriniz.";
            }
            else
            {
                sorgu = "INSERT INTO tbl_donor_sorular(DonorSoruNo,Soru,Cevap) VALUES('" + soru_no + "','" + soru + "','" + cevap + "');";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = "Sistem veritabanına kaydedildi.";
            }
            return mesaj;
        }

        public bool soru_bul(int soru_no)
        {
            bool deger = false;
            int boyut;
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_sorular\n";
            da.SelectCommand.CommandText += "where DonorSoruNo='" + soru_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {deger=true;
                boyut = dt.Rows.Count;           
                DataRow guncellenecek_veri = dt.Rows[0];
                soru = guncellenecek_veri[1].ToString();
                cevap = guncellenecek_veri[2].ToString();
                }
            return deger;
        }

        public string soru_sil(int soru_no)
        {
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_sorular\n";
            da.SelectCommand.CommandText += "where DonorSoruNo='" + soru_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                da.DeleteCommand.CommandText = "delete from tbl_donor_sorular where  DonorSoruNo ='" + soru_no + "'";
                veri_silme_bulu.Delete();
                da.Update(dt);
                dt.AcceptChanges();
                mesaj = "Sistemden SORU  KAYDI silindi.";
            }
            else
            {
                mesaj = "Bu soru numarasında soru kayıtlı değil.";
            }
            return mesaj;
        }

        public string soru_guncelle(int soru_no,string soru,string cevap)
        {
            mesaj = "Sistemde bu numarada soru kayıtlı değildir.";
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_sorular\n";
            da.SelectCommand.CommandText += "where DonorSoruNo='" + soru_no + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                sorgu = "UPDATE tbl_donor_sorular SET DonorSoruNo='" + soru_no + "',Soru='" + soru + "',Cevap='" + cevap + "' where DonorSoruNo='" + soru_no + "'";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = "Sistemde kayıtlı soru güncellenmiştir.";

            }
           
            return mesaj;
        }
            
   }
    
}
