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
    internal class MusteriIslemler
    {
        Baglan b = new Baglan();
        public DataTable TamaminiGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("musteri_getir_usp", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Musteriler");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Musteriler"];
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
             
             alter view personelview as
                select personel_no ID, ad Ad, soyad Soyad, case cinsiyet
                when 'E' then 'ERKEK'
                when 'K' then 'KADIN'
                end
                Cinsiyet,
                dogum_tarihi [Doğum Tarihi],
                ic.ilce_ad [Doğum Yeri],
                baslama_tarihi [Başlama Tarihi],
                birim_ad Birim,
                unvan_ad [Ünvan],
                calisma_saati [Çalışma Saati],
                maas [Maaş],
                prim Prim
                from personel p, ilce ic,birim b, unvan u
                where p.dogum_yeri=ic.ilce_no and p.birim_no=b.birim_no and p.unvan_no=u.unvan_no


            create proc personel_getir_usp
                as
                begin
                select * from personelview order by ID desc
                end
             */
        }
        public bool MusteriEkle(string ad, string soyad, string cinsiyet, string tel, string mail, string tc, int odaID, int ucret, string giris, string cikis)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("musteri_ekle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@a", ad);
                        komut.Parameters.AddWithValue("@s", soyad);
                        komut.Parameters.AddWithValue("@c", cinsiyet);
                        komut.Parameters.AddWithValue("@tel", tel);
                        komut.Parameters.AddWithValue("@mail", mail);
                        komut.Parameters.AddWithValue("@tc", tc);
                        komut.Parameters.AddWithValue("@odaID", odaID);
                        komut.Parameters.AddWithValue("@ucret", ucret);
                        komut.Parameters.AddWithValue("@giris", giris);
                        komut.Parameters.AddWithValue("@cikis", cikis);
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
             
             create proc personel_ekle_usp_yeni
            (
            @a			varchar(25),
            @s			varchar(25),
            @c			char(1),
            @dtar		date,
            @dyer		int,
            @bastar		date,
            @birim		int,
            @unvan		int,
            @casa		tinyint,
            @maas		money,
            @pirim		money
            )
            as
            begin

            insert into personel values (@a,@s,@c,@dtar,@dyer,@bastar,@birim,@unvan,@casa,@maas,@pirim) end		
             */
        }
        public DataTable Ara(string parametre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("musteri_ara_usp", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", parametre);
                        komut.Parameters.AddWithValue("@soyAd", parametre);
                        komut.Parameters.AddWithValue("@telefon", parametre);
                        komut.Parameters.AddWithValue("@mail", parametre);
                        komut.Parameters.AddWithValue("@tc", parametre);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Musteriler");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Musteriler"];
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
             create proc personel_ara_usp
                (
                @ad varchar(25),
                @soyAd varchar(25),
                @dogumYeri varchar(20),
                @birim varchar(20),
                @unvan varchar(20)
                )
                as
                begin 
                select * from personelview where Ad like '%'+@ad+'%' or Soyad like '%'+@soyAd+'%' or [Doğum Yeri] like '%'+@dogumYeri+'%' or birim like '%'+@birim+'%' or Ünvan like '%'+@unvan+'%'
                end
            
             */
        }
        public bool MusteriSil(int ID)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("musteri_sil_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ID", ID);
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
             create proc personel_sil_usp_yeni
            (
			@ID int)
            as
            begin

            delete from personel where personel_no=@ID
			end	
            
             */
        }

        public bool MusteriGuncelle(int ID, string ad, string soyad, string cinsiyet, string tel, string mail, string tc, int odaID, int ucret, string giris, string cikis)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("musteri_guncelle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ID", ID);
                        komut.Parameters.AddWithValue("@a", ad);
                        komut.Parameters.AddWithValue("@s", soyad);
                        komut.Parameters.AddWithValue("@c", cinsiyet);
                        komut.Parameters.AddWithValue("@tel", tel);
                        komut.Parameters.AddWithValue("@mail", mail);
                        komut.Parameters.AddWithValue("@tc", tc);
                        komut.Parameters.AddWithValue("@odaID", odaID);
                        komut.Parameters.AddWithValue("@ucret", ucret);
                        komut.Parameters.AddWithValue("@giris", giris);
                        komut.Parameters.AddWithValue("@cikis", cikis);
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
             
             create proc personel_guncelle_usp_yeni
            (
			@ID int,
            @a			varchar(25),
            @s			varchar(25),
            @c			char(1),
            @dtar		date,
            @dyer		int,
            @bastar		date,
            @birim		int,
            @unvan		int,
            @casa		tinyint,
            @maas		money,
            @pirim		money
            )
            as
            begin

            update personel set ad=@a,soyad=@s,cinsiyet=@c,dogum_tarihi=@dtar,dogum_yeri=@dyer,baslama_tarihi=@bastar,birim_no=@birim,unvan_no=@unvan,calisma_saati=@casa,maas=@maas,prim=@pirim 
			where personel_no=@ID
			end		
             */
        }

        public DataTable MusteriGetir(string kullaniciAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("musteri_getir_usp2", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Kullanicilar");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Kullanicilar"];
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
             
             create proc kullanici_getir_usp2
                @kullaniciAdi varchar(50)
                as
                begin
                select ID from Kullanicilar where kullaniciAdi=@kullaniciAdi
                end     
             */
        }

        

        
    }
}
