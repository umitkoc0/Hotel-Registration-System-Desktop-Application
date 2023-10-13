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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YıldızOteli
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        Stoklar s = new Stoklar();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            VeriYukle();
        }

        void VeriYukle()
        {
            dataGridView1.DataSource = s.TamaminiGetir();
        }

        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&& textBox2.Text != "" && textBox3.Text != "")
            {
                s.StokEkle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), DateTime.Now.ToShortDateString());
                Temizle();
                VeriYukle();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
            }
        }
    }
}
