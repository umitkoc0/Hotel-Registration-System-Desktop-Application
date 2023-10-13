using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YıldızOteli.Islemler;

namespace YıldızOteli
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        MusteriIslemler m = new MusteriIslemler();
        Stoklar s = new Stoklar();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&&Convert.ToInt32(textBox1.Text)>0&& Convert.ToInt32(textBox1.Text) <20)
            {
                int personel = Convert.ToInt16(textBox1.Text);
                lblPersonelMaas.Text = (personel * 2500).ToString();

                lblgider.Text= (Convert.ToInt32(lblPersonelMaas.Text) + Convert.ToInt32(lblAlınanUrunTutar1.Text) + Convert.ToInt32(lblAlınanUrunTutar2.Text) + Convert.ToInt32(lblAlınanUrunTutar3.Text)).ToString();

                lbltoplam.Text = (Convert.ToInt32(lblKasaTutar.Text) - (Convert.ToInt32(lblPersonelMaas.Text) + Convert.ToInt32(lblAlınanUrunTutar1.Text) + Convert.ToInt32(lblAlınanUrunTutar2.Text) + Convert.ToInt32(lblAlınanUrunTutar3.Text))).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Doğru Personel Bilgisi Giriniz");
            }

            


        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = s.ToplamGelirGetir();
            lblKasaTutar.Text = dt.Rows[0][0].ToString();
            dt = s.GidaGetir();
            lblAlınanUrunTutar1.Text = dt.Rows[0][0].ToString();
            dt = s.IcecekGetir();
            lblAlınanUrunTutar2.Text = dt.Rows[0][0].ToString();
            dt = s.CerezGetir();
            lblAlınanUrunTutar3.Text = dt.Rows[0][0].ToString();

        }

       
    }
}
