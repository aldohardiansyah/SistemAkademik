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
            this.MENU_MASTER = new System.Windows.Forms.ToolStripMenuItem();
            this.MASTER = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MASTER_SISWA = new System.Windows.Forms.ToolStripMenuItem();
            this.MASTER_GURU = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MENU_PSB = new System.Windows.Forms.ToolStripMenuItem();
            this.PSB_PENDAFTARAN = new System.Windows.Forms.ToolStripMenuItem();
            this.PSB_PANITIAUJIAN = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_KEUANGAN = new System.Windows.Forms.ToolStripMenuItem();
            this.KEUANGAN_SISWABARU = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_PENJADWALAN = new System.Windows.Forms.ToolStripMenuItem();
            this.PENJADWALAN = new System.Windows.Forms.ToolStripMenuItem();
            this.cETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU_MASTER
            // 
            this.MENU_MASTER.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MASTER,
            this.toolStripSeparator4,
            this.MASTER_SISWA,
            this.MASTER_GURU,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.MENU_MASTER.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MENU_MASTER.Name = "MENU_MASTER";
            this.MENU_MASTER.Size = new System.Drawing.Size(55, 20);
            this.MENU_MASTER.Text = "Master";
            // 
            // MASTER
            // 
            this.MASTER.Image = ((System.Drawing.Image)(resources.GetObject("MASTER.Image")));
            this.MASTER.ImageTransparentColor = System.Drawing.Color.Black;
            this.MASTER.Name = "MASTER";
            this.MASTER.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MASTER.ShowShortcutKeys = false;
            this.MASTER.Size = new System.Drawing.Size(152, 22);
            this.MASTER.Text = "Master";
            this.MASTER.Click += new System.EventHandler(this.MASTER_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // MASTER_SISWA
            // 
            this.MASTER_SISWA.Image = ((System.Drawing.Image)(resources.GetObject("MASTER_SISWA.Image")));
            this.MASTER_SISWA.Name = "MASTER_SISWA";
            this.MASTER_SISWA.Size = new System.Drawing.Size(130, 22);
            this.MASTER_SISWA.Text = "Data Siswa";
            this.MASTER_SISWA.Click += new System.EventHandler(this.MASTER_SISWA_Click);
            // 
            // MASTER_GURU
            // 
            this.MASTER_GURU.Image = ((System.Drawing.Image)(resources.GetObject("MASTER_GURU.Image")));
            this.MASTER_GURU.Name = "MASTER_GURU";
            this.MASTER_GURU.Size = new System.Drawing.Size(130, 22);
            this.MASTER_GURU.Text = "Data Guru";
            this.MASTER_GURU.Click += new System.EventHandler(this.MASTER_GURU_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENU_MASTER,
            this.MENU_PSB,
            this.MENU_KEUANGAN,
            this.MENU_PENJADWALAN,
            this.cETToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(796, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MENU_PSB
            // 
            this.MENU_PSB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PSB_PENDAFTARAN,
            this.PSB_PANITIAUJIAN});
            this.MENU_PSB.Name = "MENU_PSB";
            this.MENU_PSB.Size = new System.Drawing.Size(141, 20);
            this.MENU_PSB.Text = "Penerimaan Siswa Baru";
            // 
            // PSB_PENDAFTARAN
            // 
            this.PSB_PENDAFTARAN.Image = ((System.Drawing.Image)(resources.GetObject("PSB_PENDAFTARAN.Image")));
            this.PSB_PENDAFTARAN.ImageTransparentColor = System.Drawing.Color.Black;
            this.PSB_PENDAFTARAN.Name = "PSB_PENDAFTARAN";
            this.PSB_PENDAFTARAN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.PSB_PENDAFTARAN.ShowShortcutKeys = false;
            this.PSB_PENDAFTARAN.Size = new System.Drawing.Size(140, 22);
            this.PSB_PENDAFTARAN.Text = "Pendaftaran";
            this.PSB_PENDAFTARAN.Click += new System.EventHandler(this.PSB_PENDAFTARAN_Click);
            // 
            // PSB_PANITIAUJIAN
            // 
            this.PSB_PANITIAUJIAN.Image = ((System.Drawing.Image)(resources.GetObject("PSB_PANITIAUJIAN.Image")));
            this.PSB_PANITIAUJIAN.ImageTransparentColor = System.Drawing.Color.Black;
            this.PSB_PANITIAUJIAN.Name = "PSB_PANITIAUJIAN";
            this.PSB_PANITIAUJIAN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.PSB_PANITIAUJIAN.ShowShortcutKeys = false;
            this.PSB_PANITIAUJIAN.Size = new System.Drawing.Size(140, 22);
            this.PSB_PANITIAUJIAN.Text = "Panitian Ujian";
            this.PSB_PANITIAUJIAN.Click += new System.EventHandler(this.PSB_PANITIAUJIAN_Click);
            // 
            // MENU_KEUANGAN
            // 
            this.MENU_KEUANGAN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KEUANGAN_SISWABARU});
            this.MENU_KEUANGAN.ImageTransparentColor = System.Drawing.Color.Black;
            this.MENU_KEUANGAN.Name = "MENU_KEUANGAN";
            this.MENU_KEUANGAN.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MENU_KEUANGAN.ShowShortcutKeys = false;
            this.MENU_KEUANGAN.Size = new System.Drawing.Size(72, 20);
            this.MENU_KEUANGAN.Text = "Keuangan";
            // 
            // KEUANGAN_SISWABARU
            // 
            this.KEUANGAN_SISWABARU.Image = ((System.Drawing.Image)(resources.GetObject("KEUANGAN_SISWABARU.Image")));
            this.KEUANGAN_SISWABARU.Name = "KEUANGAN_SISWABARU";
            this.KEUANGAN_SISWABARU.Size = new System.Drawing.Size(186, 22);
            this.KEUANGAN_SISWABARU.Text = "Keuangan Siswa Baru";
            this.KEUANGAN_SISWABARU.Click += new System.EventHandler(this.KEUANGAN_SISWABARU_Click);
            // 
            // MENU_PENJADWALAN
            // 
            this.MENU_PENJADWALAN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PENJADWALAN});
            this.MENU_PENJADWALAN.Name = "MENU_PENJADWALAN";
            this.MENU_PENJADWALAN.Size = new System.Drawing.Size(86, 20);
            this.MENU_PENJADWALAN.Text = "Penjadwalan";
            // 
            // PENJADWALAN
            // 
            this.PENJADWALAN.Image = ((System.Drawing.Image)(resources.GetObject("PENJADWALAN.Image")));
            this.PENJADWALAN.Name = "PENJADWALAN";
            this.PENJADWALAN.Size = new System.Drawing.Size(152, 22);
            this.PENJADWALAN.Text = "Penjadwalan";
            this.PENJADWALAN.Click += new System.EventHandler(this.PENJADWALAN_Click);
            // 
            // cETToolStripMenuItem
            // 
            this.cETToolStripMenuItem.Name = "cETToolStripMenuItem";
            this.cETToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.cETToolStripMenuItem.Text = "Cetak Rapot Siswa";
            this.cETToolStripMenuItem.Click += new System.EventHandler(this.cETToolStripMenuItem_Click);
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

        private System.Windows.Forms.ToolStripMenuItem MENU_MASTER;
        private System.Windows.Forms.ToolStripMenuItem MASTER;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MASTER_GURU;
        private System.Windows.Forms.ToolStripMenuItem MASTER_SISWA;
        private System.Windows.Forms.ToolStripMenuItem MENU_PSB;
        private System.Windows.Forms.ToolStripMenuItem PSB_PENDAFTARAN;
        private System.Windows.Forms.ToolStripMenuItem PSB_PANITIAUJIAN;
        private System.Windows.Forms.ToolStripMenuItem MENU_KEUANGAN;
        private System.Windows.Forms.ToolStripMenuItem MENU_PENJADWALAN;
        private System.Windows.Forms.ToolStripMenuItem KEUANGAN_SISWABARU;
        private System.Windows.Forms.ToolStripMenuItem PENJADWALAN;
        private System.Windows.Forms.ToolStripMenuItem cETToolStripMenuItem;

    }
}



