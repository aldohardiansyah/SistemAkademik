namespace Akademik
{
    partial class HalamanUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtama));
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MASTER = new System.Windows.Forms.ToolStripMenuItem();
            this.PSB = new System.Windows.Forms.ToolStripMenuItem();
            this.PANITIAUJIAN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.siswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KBMPENJADWALAN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MASTER,
            this.PSB,
            this.PANITIAUJIAN,
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.toolStripMenuItem2,
            this.siswaToolStripMenuItem,
            this.KBMPENJADWALAN,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // MASTER
            // 
            this.MASTER.Image = ((System.Drawing.Image)(resources.GetObject("MASTER.Image")));
            this.MASTER.ImageTransparentColor = System.Drawing.Color.Black;
            this.MASTER.Name = "MASTER";
            this.MASTER.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MASTER.ShowShortcutKeys = false;
            this.MASTER.Size = new System.Drawing.Size(189, 22);
            this.MASTER.Text = "Master";
            this.MASTER.Click += new System.EventHandler(this.MASTER_Click);
            // 
            // PSB
            // 
            this.PSB.Image = ((System.Drawing.Image)(resources.GetObject("PSB.Image")));
            this.PSB.ImageTransparentColor = System.Drawing.Color.Black;
            this.PSB.Name = "PSB";
            this.PSB.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.PSB.ShowShortcutKeys = false;
            this.PSB.Size = new System.Drawing.Size(189, 22);
            this.PSB.Text = "Penerimaan Siswa Baru";
            this.PSB.Click += new System.EventHandler(this.PSB_Click);
            // 
            // PANITIAUJIAN
            // 
            this.PANITIAUJIAN.Image = ((System.Drawing.Image)(resources.GetObject("PANITIAUJIAN.Image")));
            this.PANITIAUJIAN.ImageTransparentColor = System.Drawing.Color.Black;
            this.PANITIAUJIAN.Name = "PANITIAUJIAN";
            this.PANITIAUJIAN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.PANITIAUJIAN.ShowShortcutKeys = false;
            this.PANITIAUJIAN.Size = new System.Drawing.Size(189, 22);
            this.PANITIAUJIAN.Text = "Panitian Ujian";
            this.PANITIAUJIAN.Click += new System.EventHandler(this.PANITIAUJIAN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem1.Text = "Keuangan";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem2.Text = "Siswa";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // siswaToolStripMenuItem
            // 
            this.siswaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("siswaToolStripMenuItem.Image")));
            this.siswaToolStripMenuItem.Name = "siswaToolStripMenuItem";
            this.siswaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.siswaToolStripMenuItem.Text = "Guru";
            // 
            // KBMPENJADWALAN
            // 
            this.KBMPENJADWALAN.Image = ((System.Drawing.Image)(resources.GetObject("KBMPENJADWALAN.Image")));
            this.KBMPENJADWALAN.ImageTransparentColor = System.Drawing.Color.Black;
            this.KBMPENJADWALAN.Name = "KBMPENJADWALAN";
            this.KBMPENJADWALAN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.KBMPENJADWALAN.ShowShortcutKeys = false;
            this.KBMPENJADWALAN.Size = new System.Drawing.Size(189, 22);
            this.KBMPENJADWALAN.Text = "KBM/Penjadwalan";
            this.KBMPENJADWALAN.Click += new System.EventHandler(this.KBMPENJADWALAN_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(796, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 453);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HalamanUtama";
            this.Text = "Smart Akademik : Biar Ngurus Sekolah Kaga pake Ribet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem MASTER;
        private System.Windows.Forms.ToolStripMenuItem PSB;
        private System.Windows.Forms.ToolStripMenuItem PANITIAUJIAN;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem KBMPENJADWALAN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem siswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    }
}



