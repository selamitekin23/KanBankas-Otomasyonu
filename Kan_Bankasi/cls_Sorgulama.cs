using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Kan_Bankasi
{
    //ÇEŞİTLİ SORGULAMALARIN OLUŞTURULDUĞU SINIFIMIZDIR.
    class cls_Sorgulama
    {
        SqlDataAdapter da;
        SqlConnection baglanti;
        public  bool deger;
        public void baglan(string baglanilacak_adres)
        {
            baglanti = new SqlConnection(baglanilacak_adres);
            baglanti.Open();
            da = new SqlDataAdapter();
        }
        public DataTable HastaKayitlari() {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            Hasta.Clear();
            da.Fill(Hasta);
            return Hasta;
        }

        public DataTable DonorKayitlari()
        {
            DataTable Donor = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            Donor.Clear();
            da.Fill(Donor);
            return Donor;
        }

        public DataTable KanKayitlari()
        {
            DataTable Kan = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
            Kan.Clear();
            da.Fill(Kan);
            return Kan;
        }
        public DataTable H_TcNoAra(double tcno) {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            da.SelectCommand.CommandText += "where TcNo='" + tcno + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }
        public DataTable H_KanGrubuAra(string kanGrubu)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_HastaBilgi\n";
            da.SelectCommand.CommandText += "where KanGrubu='" + kanGrubu + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
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
        public DataTable D_TcNoAra(double tcno)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tcno + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }
        public DataTable D_KanGrubuAra(string kanGrubu)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_donor_bilgileri\n";
            da.SelectCommand.CommandText += "where KanGrubu='" + kanGrubu + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }

        public DataTable K_DonorNoAra(double donorno)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
            da.SelectCommand.CommandText += "where DonorNo='" + donorno + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }
        public DataTable K_KanGrubuAra(string kanGrubu)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStok\n";
            da.SelectCommand.CommandText += "where KanGrubu='" + kanGrubu + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }

        public DataTable StokCikisKayitlari()
        {
            DataTable StokCikis = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStokCikisTakip\n";
            StokCikis.Clear();
            da.Fill(StokCikis);
            return StokCikis;
        }
        public DataTable StokCikis_TcNoAra(double tcno)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStokCikisTakip\n";
            da.SelectCommand.CommandText += "where HastaTcNo='" + tcno + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }
        public DataTable StokCikis_KanGrubuAra(string kanGrubu)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_KanStokCikisTakip\n";
            da.SelectCommand.CommandText += "where HastaKanGrubu='" + kanGrubu + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }

        public DataTable Kullanicilar()
        {
            DataTable StokCikis = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            StokCikis.Clear();
            da.Fill(StokCikis);
            return StokCikis;
        }
        public DataTable KullaniciTcnoAra(double tcno)
        {
            DataTable Hasta = new DataTable();
            da.SelectCommand = baglanti.CreateCommand();
            da.SelectCommand.CommandText = "Select * from tbl_kullanici_bilgileri\n";
            da.SelectCommand.CommandText += "where TcNo='" + tcno + "'";
            Hasta.Clear();
            da.Fill(Hasta);
            if (Hasta.Rows.Count > 0) { deger = true; } else { deger = false; }
            return Hasta;
        }
    }
}
