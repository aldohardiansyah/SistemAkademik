namespace Akademik
{
    partial class Siswa
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
            this.tabControlSiswa = new System.Windows.Forms.TabControl();
            this.Data_Siswa = new System.Windows.Forms.TabPage();
            this.buttonTampilSemuaData = new System.Windows.Forms.Button();
            this.buttonLihatDataKelas = new System.Windows.Forms.Button();
            this.comboBoxDataSiswa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDataSiswa = new System.Windows.Forms.DataGridView();
            this.Tambah_Kelas = new System.Windows.Forms.TabPage();
            this.textBoxJurusan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxKelasBaru = new System.Windows.Forms.ComboBox();
            this.dataGridViewDaftarSiswa = new System.Windows.Forms.DataGridView();
            this.buttonKonfirm = new System.Windows.Forms.Button();
            this.textBoxKelasLama = new System.Windows.Forms.TextBox();
            this.textBoxNIS = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlSiswa.SuspendLayout();
            this.Data_Siswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSiswa)).BeginInit();
            this.Tambah_Kelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSiswa
            // 
            this.tabControlSiswa.Controls.Add(this.Data_Siswa);
            this.tabControlSiswa.Controls.Add(this.Tambah_Kelas);
            this.tabControlSiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSiswa.Location = new System.Drawing.Point(0, 0);
            this.tabControlSiswa.Name = "tabControlSiswa";
            this.tabControlSiswa.SelectedIndex = 0;
            this.tabControlSiswa.Size = new System.Drawing.Size(898, 519);
            this.tabControlSiswa.TabIndex = 0;
            // 
            // Data_Siswa
            // 
            this.Data_Siswa.Controls.Add(this.buttonTampilSemuaData);
            this.Data_Siswa.Controls.Add(this.buttonLihatDataKelas);
            this.Data_Siswa.Controls.Add(this.comboBoxDataSiswa);
            this.Data_Siswa.Controls.Add(this.label1);
            this.Data_Siswa.Controls.Add(this.dataGridViewDataSiswa);
            this.Data_Siswa.Location = new System.Drawing.Point(4, 22);
            this.Data_Siswa.Name = "Data_Siswa";
            this.Data_Siswa.Padding = new System.Windows.Forms.Padding(3);
            this.Data_Siswa.Size = new System.Drawing.Size(890, 493);
            this.Data_Siswa.TabIndex = 0;
            this.Data_Siswa.Text = "Data Siswa";
            this.Data_Siswa.UseVisualStyleBackColor = true;
            // 
            // buttonTampilSemuaData
            // 
            this.buttonTampilSemuaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTampilSemuaData.Location = new System.Drawing.Point(734, 462);
            this.buttonTampilSemuaData.Name = "buttonTampilSemuaData";
            this.buttonTampilSemuaData.Size = new System.Drawing.Size(148, 23);
            this.buttonTampilSemuaData.TabIndex = 4;
            this.buttonTampilSemuaData.Text = "Tampilkan Semua Data";
            this.buttonTampilSemuaData.UseVisualStyleBackColor = true;
            this.buttonTampilSemuaData.Click += new System.EventHandler(this.buttonTampilSemuaData_Click);
            // 
            // buttonLihatDataKelas
            // 
            this.buttonLihatDataKelas.Location = new System.Drawing.Point(614, 49);
            this.buttonLihatDataKelas.Name = "buttonLihatDataKelas";
            this.buttonLihatDataKelas.Size = new System.Drawing.Size(75, 23);
            this.buttonLihatDataKelas.TabIndex = 3;
            this.buttonLihatDataKelas.Text = "Lihat Data";
            this.buttonLihatDataKelas.UseVisualStyleBackColor = true;
            this.buttonLihatDataKelas.Click += new System.EventHandler(this.buttonLihatDataKelas_Click);
            // 
            // comboBoxDataSiswa
            // 
            this.comboBoxDataSiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataSiswa.FormattingEnabled = true;
            this.comboBoxDataSiswa.Items.AddRange(new object[] {
            "Belum Ada Kelas"});
            this.comboBoxDataSiswa.Location = new System.Drawing.Point(465, 51);
            this.comboBoxDataSiswa.Name = "comboBoxDataSiswa";
            this.comboBoxDataSiswa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDataSiswa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih Data Siswa";
            // 
            // dataGridViewDataSiswa
            // 
            this.dataGridViewDataSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataSiswa.Location = new System.Drawing.Point(8, 108);
            this.dataGridViewDataSiswa.Name = "dataGridViewDataSiswa";
            this.dataGridViewDataSiswa.Size = new System.Drawing.Size(874, 337);
            this.dataGridViewDataSiswa.TabIndex = 0;
            this.dataGridViewDataSiswa.DoubleClick += new System.EventHandler(this.dataGridViewDataSiswa_DoubleClick);
            // 
            // Tambah_Kelas
            // 
            this.Tambah_Kelas.Controls.Add(this.textBoxJurusan);
            this.Tambah_Kelas.Controls.Add(this.label6);
            this.Tambah_Kelas.Controls.Add(this.comboBoxKelasBaru);
            this.Tambah_Kelas.Controls.Add(this.dataGridViewDaftarSiswa);
            this.Tambah_Kelas.Controls.Add(this.buttonKonfirm);
            this.Tambah_Kelas.Controls.Add(this.textBoxKelasLama);
            this.Tambah_Kelas.Controls.Add(this.textBoxNIS);
            this.Tambah_Kelas.Controls.Add(this.textBoxNama);
            this.Tambah_Kelas.Controls.Add(this.label5);
            this.Tambah_Kelas.Controls.Add(this.label4);
            this.Tambah_Kelas.Controls.Add(this.label3);
            this.Tambah_Kelas.Controls.Add(this.label2);
            this.Tambah_Kelas.Location = new System.Drawing.Point(4, 22);
            this.Tambah_Kelas.Name = "Tambah_Kelas";
            this.Tambah_Kelas.Padding = new System.Windows.Forms.Padding(3);
            this.Tambah_Kelas.Size = new System.Drawing.Size(890, 493);
            this.Tambah_Kelas.TabIndex = 1;
            this.Tambah_Kelas.Text = "Ubah Kelas";
            this.Tambah_Kelas.UseVisualStyleBackColor = true;
            // 
            // textBoxJurusan
            // 
            this.textBoxJurusan.Enabled = false;
            this.textBoxJurusan.Location = new System.Drawing.Point(124, 95);
            this.textBoxJurusan.Name = "textBoxJurusan";
            this.textBoxJurusan.Size = new System.Drawing.Size(100, 20);
            this.textBoxJurusan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jurusan";
            // 
            // comboBoxKelasBaru
            // 
            this.comboBoxKelasBaru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKelasBaru.FormattingEnabled = true;
            this.comboBoxKelasBaru.Location = new System.Drawing.Point(421, 82);
            this.comboBoxKelasBaru.Name = "comboBoxKelasBaru";
            this.comboBoxKelasBaru.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKelasBaru.TabIndex = 10;
            // 
            // dataGridViewDaftarSiswa
            // 
            this.dataGridViewDaftarSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDaftarSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarSiswa.Location = new System.Drawing.Point(8, 139);
            this.dataGridViewDaftarSiswa.Name = "dataGridViewDaftarSiswa";
            this.dataGridViewDaftarSiswa.Size = new System.Drawing.Size(874, 346);
            this.dataGridViewDaftarSiswa.TabIndex = 9;
            // 
            // buttonKonfirm
            // 
            this.buttonKonfirm.Location = new System.Drawing.Point(612, 58);
            this.buttonKonfirm.Name = "buttonKonfirm";
            this.buttonKonfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonKonfirm.TabIndex = 8;
            this.buttonKonfirm.Text = "Konfirm";
            this.buttonKonfirm.UseVisualStyleBackColor = true;
            this.buttonKonfirm.Click += new System.EventHandler(this.buttonKonfirm_Click);
            // 
            // textBoxKelasLama
            // 
            this.textBoxKelasLama.Enabled = false;
            this.textBoxKelasLama.Location = new System.Drawing.Point(421, 43);
            this.textBoxKelasLama.Name = "textBoxKelasLama";
            this.textBoxKelasLama.Size = new System.Drawing.Size(100, 20);
            this.textBoxKelasLama.TabIndex = 6;
            // 
            // textBoxNIS
            // 
            this.textBoxNIS.Enabled = false;
            this.textBoxNIS.Location = new System.Drawing.Point(125, 69);
            this.textBoxNIS.Name = "textBoxNIS";
            this.textBoxNIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxNIS.TabIndex = 5;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Location = new System.Drawing.Point(125, 43);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kelas Baru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kelas Lama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 519);
            this.Controls.Add(this.tabControlSiswa);
            this.Name = "Siswa";
            this.Text = "Siswa";
            this.Load += new System.EventHandler(this.Siswa_Load);
            this.tabControlSiswa.ResumeLayout(false);
            this.Data_Siswa.ResumeLayout(false);
            this.Data_Siswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSiswa)).EndInit();
            this.Tambah_Kelas.ResumeLayout(false);
            this.Tambah_Kelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarSiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSiswa;
        private System.Windows.Forms.TabPage Data_Siswa;
        private System.Windows.Forms.DataGridView dataGridViewDataSiswa;
        private System.Windows.Forms.TabPage Tambah_Kelas;
        private System.Windows.Forms.ComboBox comboBoxDataSiswa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLihatDataKelas;
        private System.Windows.Forms.Button buttonTampilSemuaData;
        private System.Windows.Forms.DataGridView dataGridViewDaftarSiswa;
        private System.Windows.Forms.Button buttonKonfirm;
        private System.Windows.Forms.TextBox textBoxKelasLama;
        private System.Windows.Forms.TextBox textBoxNIS;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKelasBaru;
        private System.Windows.Forms.TextBox textBoxJurusan;
        private System.Windows.Forms.Label label6;
    }
}