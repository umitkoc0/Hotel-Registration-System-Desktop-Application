namespace YıldızOteli
{
    partial class FrmHaberler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.haberTurkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hürriyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milliyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözcüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanatikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webTeknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1027, 499);
            this.webBrowser1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haberTurkToolStripMenuItem,
            this.hürriyetToolStripMenuItem,
            this.milliyetToolStripMenuItem,
            this.sözcüToolStripMenuItem,
            this.fanatikToolStripMenuItem,
            this.onedioToolStripMenuItem,
            this.shiftDeleteToolStripMenuItem,
            this.webTeknoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 41);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // haberTurkToolStripMenuItem
            // 
            this.haberTurkToolStripMenuItem.Name = "haberTurkToolStripMenuItem";
            this.haberTurkToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.haberTurkToolStripMenuItem.Text = "HaberTürk";
            this.haberTurkToolStripMenuItem.Click += new System.EventHandler(this.haberTurkToolStripMenuItem_Click);
            // 
            // hürriyetToolStripMenuItem
            // 
            this.hürriyetToolStripMenuItem.Name = "hürriyetToolStripMenuItem";
            this.hürriyetToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.hürriyetToolStripMenuItem.Text = "Hürriyet";
            this.hürriyetToolStripMenuItem.Click += new System.EventHandler(this.hürriyetToolStripMenuItem_Click);
            // 
            // milliyetToolStripMenuItem
            // 
            this.milliyetToolStripMenuItem.Name = "milliyetToolStripMenuItem";
            this.milliyetToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.milliyetToolStripMenuItem.Text = "Milliyet";
            this.milliyetToolStripMenuItem.Click += new System.EventHandler(this.milliyetToolStripMenuItem_Click);
            // 
            // sözcüToolStripMenuItem
            // 
            this.sözcüToolStripMenuItem.Name = "sözcüToolStripMenuItem";
            this.sözcüToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.sözcüToolStripMenuItem.Text = "Sözcü";
            this.sözcüToolStripMenuItem.Click += new System.EventHandler(this.sözcüToolStripMenuItem_Click);
            // 
            // fanatikToolStripMenuItem
            // 
            this.fanatikToolStripMenuItem.Name = "fanatikToolStripMenuItem";
            this.fanatikToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.fanatikToolStripMenuItem.Text = "Fanatik";
            this.fanatikToolStripMenuItem.Click += new System.EventHandler(this.fanatikToolStripMenuItem_Click);
            // 
            // onedioToolStripMenuItem
            // 
            this.onedioToolStripMenuItem.Name = "onedioToolStripMenuItem";
            this.onedioToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            this.onedioToolStripMenuItem.Text = "Onedio";
            this.onedioToolStripMenuItem.Click += new System.EventHandler(this.onedioToolStripMenuItem_Click);
            // 
            // shiftDeleteToolStripMenuItem
            // 
            this.shiftDeleteToolStripMenuItem.Name = "shiftDeleteToolStripMenuItem";
            this.shiftDeleteToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.shiftDeleteToolStripMenuItem.Text = "ShiftDelete";
            this.shiftDeleteToolStripMenuItem.Click += new System.EventHandler(this.shiftDeleteToolStripMenuItem_Click);
            // 
            // webTeknoToolStripMenuItem
            // 
            this.webTeknoToolStripMenuItem.Name = "webTeknoToolStripMenuItem";
            this.webTeknoToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.webTeknoToolStripMenuItem.Text = "WebTekno";
            this.webTeknoToolStripMenuItem.Click += new System.EventHandler(this.webTeknoToolStripMenuItem_Click);
            // 
            // FrmHaberler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 540);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHaberler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Haberler";
            this.Load += new System.EventHandler(this.FrmHaberler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem haberTurkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hürriyetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milliyetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözcüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanatikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webTeknoToolStripMenuItem;
    }
}