using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using  System.Data.SqlClient;
namespace Kan_Bankasi
{
     //KAN GRUBU İSİMLERİNİN KAYDININ YAPILDIĞI SINIFTIR.SINIF YAPISI OLMASADA OLURDU AMA MAKSAT SINIFLARI ÖĞRENMEK :)   
    class cls_kan_grubu_girisi
    {
        SqlDataAdapter da;
        public DataTable dt;
        SqlConnection baglanti;
        SqlCommand uygula;
        string sorgu, mesaj;
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

        public string kan_grubu_kaydet(string kan_gadi) {

            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kan_grubu_ismi\n";
            da.SelectCommand.CommandText += "where KanGrubu='" + kan_gadi + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                mesaj = "Bu isimde kan grubu sistemde kayıtlı.";
            }
            else
            {
                sorgu = "INSERT INTO tbl_kan_grubu_ismi(KanGrubu) VALUES('" + kan_gadi+ "');";
                uygula = new SqlCommand(sorgu, baglanti);
                uygula.ExecuteNonQuery();
                mesaj = "KAYDEDİLDİ";
            }
            return mesaj;
        
        
        }

        public string kan_grubu_sil(string kan_gadi)
        {
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kan_grubu_ismi\n";
            da.SelectCommand.CommandText += "where KanGrubu='" + kan_gadi + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow veri_silme_bulu = dt.Rows[0];
                da.DeleteCommand = baglanti.CreateCommand();
                da.DeleteCommand.CommandText = "delete from tbl_kan_grubu_ismi where  KanGrubu ='" + kan_gadi + "'";
                veri_silme_bulu.Delete();
                da.Update(dt);
                dt.AcceptChanges();
                mesaj = "Sistemden Kan Grubu ismi silindi.";
            }
            else
            {
                mesaj = "Bu kan grubu sistemde kayıtlı değil.";
            }
            return mesaj;
        }

    }
}
