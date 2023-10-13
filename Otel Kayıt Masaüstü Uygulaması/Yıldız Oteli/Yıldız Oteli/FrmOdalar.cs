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
using System.Data.Sql;
using System.Data.SqlClient;

namespace YıldızOteli
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        Odalar o = new Odalar();

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            VeriYukle();
        }
        void VeriYukle()
        {
            DataTable dt = new DataTable();

            dt = o.VeriGetir(101);
            if (dt.Rows.Count > 0)
            {
                BtnOda101.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda101.Text != "101")
                    BtnOda101.BackColor = Color.Red;
                else
                    BtnOda101.BackColor = Color.Green;
            }

            dt = o.VeriGetir(102);
            if (dt.Rows.Count > 0)
            {
                BtnOda102.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda102.Text != "102")
                    BtnOda102.BackColor = Color.Red;
                else
                    BtnOda102.BackColor = Color.Green;
            }

            dt = o.VeriGetir(103);
            if (dt.Rows.Count > 0)
            {
                BtnOda103.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda103.Text != "103")
                    BtnOda103.BackColor = Color.Red;
                else
                    BtnOda103.BackColor = Color.Green;
            }

            dt = o.VeriGetir(104);
            if (dt.Rows.Count > 0)
            {
                BtnOda104.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda104.Text != "104")
                    BtnOda104.BackColor = Color.Red;
                else
                    BtnOda104.BackColor = Color.Green;
            }

            dt = o.VeriGetir(105);
            if (dt.Rows.Count > 0)
            {
                BtnOda105.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda105.Text != "105")
                    BtnOda105.BackColor = Color.Red;
                else
                    BtnOda105.BackColor = Color.Green;
            }

            dt = o.VeriGetir(106);
            if (dt.Rows.Count > 0)
            {
                BtnOda106.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda106.Text != "106")
                    BtnOda106.BackColor = Color.Red;
                else
                    BtnOda106.BackColor = Color.Green;
            }

            dt = o.VeriGetir(107);
            if (dt.Rows.Count > 0)
            {
                BtnOda107.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda107.Text != "107")
                    BtnOda107.BackColor = Color.Red;
                else
                    BtnOda107.BackColor = Color.Green;
            }

            dt = o.VeriGetir(108);
            if (dt.Rows.Count > 0)
            {
                BtnOda108.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda108.Text != "108")
                    BtnOda108.BackColor = Color.Red;
                else
                    BtnOda108.BackColor = Color.Green;
            }

            dt = o.VeriGetir(109);
            if (dt.Rows.Count > 0)
            {
                BtnOda109.Text = (dt.Rows[0][1] + " " + dt.Rows[0][2]).ToString();
                if (BtnOda109.Text != "109")
                    BtnOda109.BackColor = Color.Red;
                else
                    BtnOda109.BackColor = Color.Green;
            }
        }
        void BilgiGoster(int oda)
        {
            DataTable dt = new DataTable();
            dt = o.VeriGetir(oda);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("TC: " + dt.Rows[0][6] + "\n\nCinsiyet: " + dt.Rows[0][3] + "\n\nE-Posta: " + dt.Rows[0][5] + "\n\nTelefon: " + dt.Rows[0][4] + "\n\nGiriş Tarihi: " + dt.Rows[0][9] + "\n\nÇıkış Tarihi: " + dt.Rows[0][10], dt.Rows[0][1] + " " + dt.Rows[0][2]);
            }
            else
            {
                MessageBox.Show("Boş Oda");
            }
            
        }


        private void BtnOda101_Click(object sender, EventArgs e)
        {
            BilgiGoster(101);
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            BilgiGoster(102);
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            BilgiGoster(103);
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            BilgiGoster(104);
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            BilgiGoster(105);
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            BilgiGoster(106);
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            BilgiGoster(107);
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            BilgiGoster(108);
        }
        private void BtnOda109_Click(object sender, EventArgs e)
        {
            BilgiGoster(109);
        }
    }
}
