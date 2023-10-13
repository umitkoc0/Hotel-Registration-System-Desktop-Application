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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        MusteriIslemler m = new MusteriIslemler();

        private void araText_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = m.Ara(araText.Text);
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            parcala();
        }
        void parcala()
        {
            label13.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MskTxtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TxtKimlikNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtOdaNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TxtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            DtpGirisTarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value);
            DtpCikisTarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);

            
        }
        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            VeriYukle();
        }

        void VeriYukle()
        {
            dataGridView1.DataSource = m.TamaminiGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label13.Text);
            if (id > 0)
            {
                m.MusteriSil(Convert.ToInt32(label13.Text));
                VeriYukle();
                Temizle();
            }
            else
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçiniz.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label13.Text != "-1")
            {

                m.MusteriGuncelle(Convert.ToInt32(label13.Text), TxtAdi.Text, TxtSoyadi.Text, comboBox1.Text, MskTxtTelefon.Text, TxtMail.Text, TxtKimlikNo.Text, Convert.ToInt32(TxtOdaNo.Text), Convert.ToInt32(TxtUcret.Text),
                    DtpGirisTarihi.Value.ToString("yyyy-MM-dd"),DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
                VeriYukle();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Kaydı Seçiniz.");
            }
        }
        void Temizle()
        {
            label13.Text = "-1";
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = null;
            MskTxtTelefon.Text= null;
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = null;
            DtpCikisTarihi.Text= null;
        }
    }
}
//Data Source=DESKTOP-5T1TSP5;Initial Catalog=YıldızÖğretmenevi;Integrated Security=True
