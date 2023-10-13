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
    public partial class FrmAdminGiris : Form
    {
        Admin a =new Admin();
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (TxtKullaniciAdi.Text==""|| TxtSifre.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
            }
            else
            {
                dt = a.AdminGiris(TxtKullaniciAdi.Text, TxtSifre.Text);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.lblAdmin1.Text = dt.Rows[0][0].ToString();
                    fr.lblAdmin2.Text = dt.Rows[0][1].ToString();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
            }
            
        }

        
    }
}
