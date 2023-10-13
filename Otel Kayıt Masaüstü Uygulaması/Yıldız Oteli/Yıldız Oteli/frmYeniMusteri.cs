using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using YıldızOteli.Islemler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace YıldızOteli
{
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }
        MusteriIslemler m = new MusteriIslemler();
        Odalar o = new Odalar();
        private void frmYeniMusteri_Load(object sender, EventArgs e)
        {
            VeriYukle();
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 300;
            TxtUcret.Text = Ucret.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = m.MusteriGetir(TxtKimlikNo.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Kayıtlı Kullanıcı");
            }
            else
            {
                m.MusteriEkle(TxtAdi.Text, TxtSoyadi.Text, comboBox1.Text, MskTxtTelefon.Text, TxtMail.Text, TxtKimlikNo.Text, Convert.ToInt32(TxtOdaNo.Text), Convert.ToInt32(TxtUcret.Text),
                    DtpGirisTarihi.Value.ToString("yyyy-MM-dd"), DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti.");
                VeriYukle();
            }
            


        }

        void VeriYukle()
        {
            DataTable dt = new DataTable();

            dt = o.VeriGetir(101);
            if (dt.Rows.Count > 0)
            {
                BtnOda101.Text = dt.Rows[0][1].ToString();
                if (BtnOda101.Text != "101")
                {
                    BtnOda101.BackColor = Color.Red;
                    BtnOda101.Enabled = false;
                }
                else
                {
                    BtnOda101.BackColor = Color.Green;
                    BtnOda101.Enabled = true;
                }
            }

            dt = o.VeriGetir(102);
            if (dt.Rows.Count > 0)
            {
                BtnOda102.Text = dt.Rows[0][1].ToString();
                if (BtnOda102.Text != "102")
                {
                    BtnOda102.BackColor = Color.Red;
                    BtnOda102.Enabled = false;
                }
                else
                {
                    BtnOda102.BackColor = Color.Green;
                    BtnOda102.Enabled = true;
                }
            }

            dt = o.VeriGetir(103);
            if (dt.Rows.Count > 0)
            {
                BtnOda103.Text = dt.Rows[0][1].ToString();
                if (BtnOda103.Text != "103")
                {
                    BtnOda103.BackColor = Color.Red;
                    BtnOda103.Enabled = false;
                }
                else
                {
                    BtnOda103.BackColor = Color.Green;
                    BtnOda103.Enabled = true;
                }
            }

            dt = o.VeriGetir(104);
            if (dt.Rows.Count > 0)
            {
                BtnOda104.Text = dt.Rows[0][1].ToString();
                if (BtnOda104.Text != "104")
                {
                    BtnOda104.BackColor = Color.Red;
                    BtnOda104.Enabled = false;
                }
                else
                {
                    BtnOda104.BackColor = Color.Green;
                    BtnOda104.Enabled = true;
                }
            }

            dt = o.VeriGetir(105);
            if (dt.Rows.Count > 0)
            {
                BtnOda105.Text = dt.Rows[0][1].ToString();
                if (BtnOda105.Text != "105")
                {
                    BtnOda105.BackColor = Color.Red;
                    BtnOda105.Enabled = false;
                }
                else
                {
                    BtnOda105.BackColor = Color.Green;
                    BtnOda105.Enabled = true;
                }
            }

            dt = o.VeriGetir(106);
            if (dt.Rows.Count > 0)
            {
                BtnOda106.Text = dt.Rows[0][1].ToString();
                if (BtnOda106.Text != "106")
                {
                    BtnOda106.BackColor = Color.Red;
                    BtnOda106.Enabled = false;
                }
                else
                {
                    BtnOda106.BackColor = Color.Green;
                    BtnOda106.Enabled = true;
                }
            }

            dt = o.VeriGetir(107);
            if (dt.Rows.Count > 0)
            {
                BtnOda107.Text = dt.Rows[0][1].ToString();
                if (BtnOda107.Text != "107")
                {
                    BtnOda107.BackColor = Color.Red;
                    BtnOda107.Enabled = false;
                }
                else
                {
                    BtnOda107.BackColor = Color.Green;
                    BtnOda107.Enabled = true;
                }
            }

            dt = o.VeriGetir(108);
            if (dt.Rows.Count > 0)
            {
                BtnOda108.Text = dt.Rows[0][1].ToString();
                if (BtnOda108.Text != "108")
                {
                    BtnOda108.BackColor = Color.Red;
                    BtnOda108.Enabled = false;
                }
                else
                {
                    BtnOda108.BackColor = Color.Green;
                    BtnOda108.Enabled = true;
                }
            }

            dt = o.VeriGetir(109);
            if (dt.Rows.Count > 0)
            {
                BtnOda109.Text = dt.Rows[0][1].ToString();
                if (BtnOda109.Text != "109")
                {
                    BtnOda109.BackColor = Color.Red;
                    BtnOda109.Enabled = false;
                }
                else
                {
                    BtnOda109.BackColor = Color.Green;
                    BtnOda109.Enabled = true;
                }
            }
        }


    }
}
//Data Source=DESKTOP-5T1TSP5;Initial Catalog=YıldızÖğretmenevi;Integrated Security=True
