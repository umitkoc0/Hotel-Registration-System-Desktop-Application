using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YıldızOteli.VeriBaglantisi;
using System.Windows.Forms;

namespace YıldızOteli.Islemler
{
    internal class Odalar
    {
        Baglan b = new Baglan();

        public DataTable VeriGetir(int odaNo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("oda_veri_getir_usp", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@odaNo", odaNo);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Odalar");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Odalar"];
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
             create proc oda_veri_getir_usp
                (
                @odaNo int
                )
                as
                begin 
                select * from Musteriler where OdaID like '%'+@odaNo+'%'
                end
             */
        }
    }
}
