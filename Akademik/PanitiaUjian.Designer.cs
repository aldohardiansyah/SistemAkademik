namespace Akademik
{
    partial class PanitiaUjian
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
            this.tabControlHasilUjian = new System.Windows.Forms.TabControl();
            this.tabPagePencarianHasilUjian = new System.Windows.Forms.TabPage();
            this.buttonCari = new System.Windows.Forms.Button();
            this.textBoxNomorUjian = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.buttonTampilkanSemuaData = new System.Windows.Forms.Button();
            this.dataGridViewLunasBayar = new System.Windows.Forms.DataGridView();
            this.tabPageMasukanNilai = new System.Windows.Forms.TabPage();
            this.dataGridViewHasilUjian = new System.Windows.Forms.DataGridView();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxHasil = new System.Windows.Forms.TextBox();
            this.textBoxNilaiTest = new System.Windows.Forms.TextBox();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.textBoxNoDaftar = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tabControlHasilUjian.SuspendLayout();
            this.tabPagePencarianHasilUjian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLunasBayar)).BeginInit();
            this.tabPageMasukanNilai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasilUjian)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlHasilUjian
            // 
            this.tabControlHasilUjian.Controls.Add(this.tabPagePencarianHasilUjian);
            this.tabControlHasilUjian.Controls.Add(this.tabPageMasukanNilai);
            this.tabControlHasilUjian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHasilUjian.Location = new System.Drawing.Point(0, 0);
            this.tabControlHasilUjian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlHasilUjian.Name = "tabControlHasilUjian";
            this.tabControlHasilUjian.SelectedIndex = 0;
            this.tabControlHasilUjian.Size = new System.Drawing.Size(926, 629);
            this.tabControlHasilUjian.TabIndex = 0;
            // 
            // tabPagePencarianHasilUjian
            // 
            this.tabPagePencarianHasilUjian.Controls.Add(this.buttonCari);
            this.tabPagePencarianHasilUjian.Controls.Add(this.textBoxNomorUjian);
            this.tabPagePencarianHasilUjian.Controls.Add(this.label46);
            this.tabPagePencarianHasilUjian.Controls.Add(this.label45);
            this.tabPagePencarianHasilUjian.Controls.Add(this.buttonTampilkanSemuaData);
            this.tabPagePencarianHasilUjian.Controls.Add(this.dataGridViewLunasBayar);
            this.tabPagePencarianHasilUjian.Location = new System.Drawing.Point(4, 25);
            this.tabPagePencarianHasilUjian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPagePencarianHasilUjian.Name = "tabPagePencarianHasilUjian";
            this.tabPagePencarianHasilUjian.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPagePencarianHasilUjian.Size = new System.Drawing.Size(918, 600);
            this.tabPagePencarianHasilUjian.TabIndex = 0;
            this.tabPagePencarianHasilUjian.Text = "Pencarian";
            this.tabPagePencarianHasilUjian.UseVisualStyleBackColor = true;
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(368, 10);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(87, 28);
            this.buttonCari.TabIndex = 11;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // textBoxNomorUjian
            // 
            this.textBoxNomorUjian.Location = new System.Drawing.Point(180, 13);
            this.textBoxNomorUjian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNomorUjian.Name = "textBoxNomorUjian";
            this.textBoxNomorUjian.Size = new System.Drawing.Size(171, 23);
            this.textBoxNomorUjian.TabIndex = 10;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 28);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(129, 16);
            this.label46.TabIndex = 9;
            this.label46.Text = "(Nomor Pendaftaran)";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(8, 8);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(133, 16);
            this.label45.TabIndex = 8;
            this.label45.Text = "Masukan Nomor Ujian";
            // 
            // buttonTampilkanSemuaData
            // 
            this.buttonTampilkanSemuaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTampilkanSemuaData.Location = new System.Drawing.Point(825, 563);
            this.buttonTampilkanSemuaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTampilkanSemuaData.Name = "buttonTampilkanSemuaData";
            this.buttonTampilkanSemuaData.Size = new System.Drawing.Size(85, 28);
            this.buttonTampilkanSemuaData.TabIndex = 7;
            this.buttonTampilkanSemuaData.Text = "Refresh";
            this.buttonTampilkanSemuaData.UseVisualStyleBackColor = true;
            this.buttonTampilkanSemuaData.Click += new System.EventHandler(this.buttonTampilkanSemuaData_Click);
            // 
            // dataGridViewLunasBayar
            // 
            this.dataGridViewLunasBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLunasBayar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLunasBayar.Location = new System.Drawing.Point(9, 48);
            this.dataGridViewLunasBayar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewLunasBayar.Name = "dataGridViewLunasBayar";
            this.dataGridViewLunasBayar.Size = new System.Drawing.Size(901, 507);
            this.dataGridViewLunasBayar.TabIndex = 6;
            this.dataGridViewLunasBayar.DoubleClick += new System.EventHandler(this.dataGridViewLunasBayar_DoubleClick);
            // 
            // tabPageMasukanNilai
            // 
            this.tabPageMasukanNilai.Controls.Add(this.dataGridViewHasilUjian);
            this.tabPageMasukanNilai.Controls.Add(this.buttonSimpan);
            this.tabPageMasukanNilai.Controls.Add(this.textBoxHasil);
            this.tabPageMasukanNilai.Controls.Add(this.textBoxNilaiTest);
            this.tabPageMasukanNilai.Controls.Add(this.textBoxNamaLengkap);
            this.tabPageMasukanNilai.Controls.Add(this.textBoxNoDaftar);
            this.tabPageMasukanNilai.Controls.Add(this.label51);
            this.tabPageMasukanNilai.Controls.Add(this.label50);
            this.tabPageMasukanNilai.Controls.Add(this.label48);
            this.tabPageMasukanNilai.Controls.Add(this.label47);
            this.tabPageMasukanNilai.Location = new System.Drawing.Point(4, 25);
            this.tabPageMasukanNilai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMasukanNilai.Name = "tabPageMasukanNilai";
            this.tabPageMasukanNilai.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMasukanNilai.Size = new System.Drawing.Size(918, 600);
            this.tabPageMasukanNilai.TabIndex = 1;
            this.tabPageMasukanNilai.Text = "Input Hasil Ujian";
            this.tabPageMasukanNilai.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHasilUjian
            // 
            this.dataGridViewHasilUjian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHasilUjian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasilUjian.Location = new System.Drawing.Point(7, 106);
            this.dataGridViewHasilUjian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewHasilUjian.Name = "dataGridViewHasilUjian";
            this.dataGridViewHasilUjian.Size = new System.Drawing.Size(903, 481);
            this.dataGridViewHasilUjian.TabIndex = 21;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(137, 70);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(87, 28);
            this.buttonSimpan.TabIndex = 20;
            this.buttonSimpan.Text = "Submit";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // textBoxHasil
            // 
            this.textBoxHasil.Enabled = false;
            this.textBoxHasil.Location = new System.Drawing.Point(238, 39);
            this.textBoxHasil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHasil.Name = "textBoxHasil";
            this.textBoxHasil.Size = new System.Drawing.Size(121, 23);
            this.textBoxHasil.TabIndex = 19;
            this.textBoxHasil.Visible = false;
            // 
            // textBoxNilaiTest
            // 
            this.textBoxNilaiTest.Location = new System.Drawing.Point(137, 39);
            this.textBoxNilaiTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNilaiTest.Name = "textBoxNilaiTest";
            this.textBoxNilaiTest.Size = new System.Drawing.Size(57, 23);
            this.textBoxNilaiTest.TabIndex = 18;
            this.textBoxNilaiTest.TextChanged += new System.EventHandler(this.textBoxNilaiTest_TextChanged);
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(137, 8);
            this.textBoxNamaLengkap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.ReadOnly = true;
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(222, 23);
            this.textBoxNamaLengkap.TabIndex = 17;
            // 
            // textBoxNoDaftar
            // 
            this.textBoxNoDaftar.Location = new System.Drawing.Point(441, 40);
            this.textBoxNoDaftar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNoDaftar.Name = "textBoxNoDaftar";
            this.textBoxNoDaftar.Size = new System.Drawing.Size(222, 23);
            this.textBoxNoDaftar.TabIndex = 16;
            this.textBoxNoDaftar.Visible = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(197, 42);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 16);
            this.label51.TabIndex = 15;
            this.label51.Text = "Hasil";
            this.label51.Visible = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(12, 42);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(61, 16);
            this.label50.TabIndex = 14;
            this.label50.Text = "Nilai Test";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 12);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(92, 16);
            this.label48.TabIndex = 13;
            this.label48.Text = "Nama Lengkap";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(373, 43);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(62, 16);
            this.label47.TabIndex = 12;
            this.label47.Text = "No Daftar";
            this.label47.Visible = false;
            // 
            // PanitiaUjian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 629);
            this.Controls.Add(this.tabControlHasilUjian);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PanitiaUjian";
            this.Text = "Panitia Ujian";
            this.Load += new System.EventHandler(this.PanitiaUjian_Load);
            this.tabControlHasilUjian.ResumeLayout(false);
            this.tabPagePencarianHasilUjian.ResumeLayout(false);
            this.tabPagePencarianHasilUjian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLunasBayar)).EndInit();
            this.tabPageMasukanNilai.ResumeLayout(false);
            this.tabPageMasukanNilai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasilUjian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHasilUjian;
        private System.Windows.Forms.TabPage tabPagePencarianHasilUjian;
        private System.Windows.Forms.TabPage tabPageMasukanNilai;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.TextBox textBoxNomorUjian;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button buttonTampilkanSemuaData;
        private System.Windows.Forms.DataGridView dataGridViewLunasBayar;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxHasil;
        private System.Windows.Forms.TextBox textBoxNilaiTest;
        private System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.TextBox textBoxNoDaftar;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.DataGridView dataGridViewHasilUjian;
    }
}