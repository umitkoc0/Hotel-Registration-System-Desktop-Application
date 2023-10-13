using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YıldızOteli
{
    public partial class FrmHaberler : Form
    {
        public FrmHaberler()
        {
            InitializeComponent();
        }

        private void FrmHaberler_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }
        private void haberTurkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void hürriyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void sözcüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void fanatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void onedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com/");
        }

        private void shiftDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://shiftdelete.net/");
        }

        private void webTeknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.webtekno.com/");
        }

        
    }
}
