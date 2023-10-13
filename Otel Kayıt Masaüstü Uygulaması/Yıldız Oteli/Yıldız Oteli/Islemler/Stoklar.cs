using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YıldızOteli.VeriBaglantisi;

namespace YıldızOteli.Islemler
{
    internal class Stoklar
    {
        Baglan b = new Baglan();
        public DataTable TamaminiGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("stok_getir_usp", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Stoklar");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Stoklar"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;

            /*
             
             create proc [dbo].[stok_getir_usp]
                as
                begin
                select * from Stoklar order by Gun desc
                end
             */
        }

        public bool StokEkle(int gida, int icecek, int cerez, string gun)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("stok_ekle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@gida", gida);
                        komut.Parameters.AddWithValue("@icecek", icecek);
                        komut.Parameters.AddWithValue("@cerez", cerez);
                        komut.Parameters.AddWithValue("@gun", gun);
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                hataOlustuMu = true;
            }
            return hataOlustuMu;
            /*

             create proc stok_ekle_usp
                (
                @gida			int,
                @icecek			int,
                @cerez			int,
                @gun		    date
                )
                as
                begin

                insert into Stoklar values (@gida,@icecek,@cerez,@gun) end
             */
        }


        public DataTable ToplamGelirGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("ucret_getir", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Gelir");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Gelir"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;

            /*
             
             create proc ucret_getir
                as
                begin 
                select sum(Ucret) as Toplam from Musteriler
                end
             */
        }

        public DataTable GidaGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("gida_ucret_getir", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Gelir");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Gelir"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;

            /*
             
             create proc ucret_getir
                as
                begin 
                select sum(Ucret) as Toplam from Musteriler
                end
             */
        }

        public DataTable IcecekGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("icecek_ucret_getir", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Gelir");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Gelir"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;

            /*
             
             create proc ucret_getir
                as
                begin 
                select sum(Ucret) as Toplam from Musteriler
                end
             */
        }

        public DataTable CerezGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("cerez_ucret_getir", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Gelir");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Gelir"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;

            /*
             
             create proc ucret_getir
                as
                begin 
                select sum(Ucret) as Toplam from Musteriler
                end
             */
        }


    }
}
