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
    public partial class FrmAdminDuzenle : Form
    {
        public FrmAdminDuzenle()
        {
            InitializeComponent();
        }
        Admin a =new Admin();
        private void FrmAdminDuzenle_Load(object sender, EventArgs e)
        {
            VeriYukle();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool hata= a.AdminGuncelle(int.Parse(lblID.Text),TxtAdSoyad.Text,TxtKadi.Text,TxtSifre.Text);
            if (hata==false)
            {
                MessageBox.Show("Kayıt Başarıyla Güncellendi.");
                FrmAnaForm fr = new FrmAnaForm();
                VeriYukle();
                fr.lblAdmin1.Text = lblID.Text;
                fr.lblAdmin2.Text = TxtAdSoyad.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt Başarıyla Güncellenemedi.","Hata");
            }
        }

        void VeriYukle()
        {
            DataTable dt = new DataTable();
            dt = a.AdminAra(int.Parse(lblID.Text));
            TxtAdSoyad.Text = dt.Rows[0][1].ToString();
            TxtKadi.Text = dt.Rows[0][2].ToString();
            TxtSifre.Text = dt.Rows[0][3].ToString();
        }

        
    }
}
