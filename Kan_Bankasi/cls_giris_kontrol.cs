using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Kan_Bankasi
{
    //KULLANICI GİRİŞ KONTOLÜNÜN YAPILDIĞI SINIFTIR.
    class cls_giris_kontrol
    {
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection baglanti;
        public string kullanici;
        public bool kullanıcı_kontrol(string baglanilacak_adres,string kullanici_adi,int kullanici_sifre) {
            //kullanici adı ile şifrenin veritabanındaki kayıtla aynı olup olmadığını karşılaştırıyom eğer aynıysa true değeri gönderiyom
            bool deger = false;
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where KullaniciAdi='" + kullanici_adi + "'and Sifre='" + kullanici_sifre + "'";
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                kullanici = kullanici_adi;
                deger = true;
            }

            return deger;
        }      

    }
}
