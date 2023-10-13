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
    internal class Admin
    {
        Baglan b =new Baglan();
        public DataTable AdminGiris(string kadi,string sifre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("admin_giris_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@kadi", kadi);
                        komut.Parameters.AddWithValue("@sifre", sifre);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Admin");
                        dt = ds.Tables["Admin"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;

            
        }

        public DataTable AdminAra(int ID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("admin_ara_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ID", ID);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Admin");
                        dt = ds.Tables["Admin"];
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
             create proc admin_ara_usp
                (
                @ID int
				)
                as
                begin 
                select * from AdminGiris where ID like @ID
                end
            
             */
        }

        public bool AdminGuncelle(int ID, string adsoyad, string kadi, string sifre)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("admin_guncelle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ID", ID);
                        komut.Parameters.AddWithValue("@adsoyad", adsoyad);
                        komut.Parameters.AddWithValue("@kadi", kadi);
                        komut.Parameters.AddWithValue("@sifre", sifre);
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
             
             create proc admin_guncelle_usp
            (
			@ID int,
            @adsoyad		nvarchar(100),
            @kadi			varchar(25),
            @sifre			varchar(25)
            )
            as
            begin
            update AdminGiris set AdSoyad=@adsoyad,KullaniciAdi=@kadi,Sifre=@sifre
			where ID=@ID
			end		
             */
        }
    }
}
