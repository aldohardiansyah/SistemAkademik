namespace Akademik
{
    partial class CetakRapot
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
            this.tabControl_CetakRapot = new System.Windows.Forms.TabControl();
            this.tabPage_DataKLS = new System.Windows.Forms.TabPage();
            this.dataGridView_DaftarSiswa = new System.Windows.Forms.DataGridView();
            this.label_SMST = new System.Windows.Forms.Label();
            this.label_TA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LihatData = new System.Windows.Forms.Button();
            this.comboBox_DaftarKelas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_CetakRapot = new System.Windows.Forms.TabPage();
            this.dataGridView_RapotNilai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_RapotTHN = new System.Windows.Forms.Label();
            this.label_RapotSMT = new System.Windows.Forms.Label();
            this.label_RapotKelas = new System.Windows.Forms.Label();
            this.label_RapotNIS = new System.Windows.Forms.Label();
            this.label_RapotNama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Cetak = new System.Windows.Forms.Button();
            this.tabControl_CetakRapot.SuspendLayout();
            this.tabPage_DataKLS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DaftarSiswa)).BeginInit();
            this.tabPage_CetakRapot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RapotNilai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_CetakRapot
            // 
            this.tabControl_CetakRapot.Controls.Add(this.tabPage_DataKLS);
            this.tabControl_CetakRapot.Controls.Add(this.tabPage_CetakRapot);
            this.tabControl_CetakRapot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_CetakRapot.Location = new System.Drawing.Point(0, 0);
            this.tabControl_CetakRapot.Name = "tabControl_CetakRapot";
            this.tabControl_CetakRapot.SelectedIndex = 0;
            this.tabControl_CetakRapot.Size = new System.Drawing.Size(787, 518);
            this.tabControl_CetakRapot.TabIndex = 0;
            // 
            // tabPage_DataKLS
            // 
            this.tabPage_DataKLS.Controls.Add(this.dataGridView_DaftarSiswa);
            this.tabPage_DataKLS.Controls.Add(this.label_SMST);
            this.tabPage_DataKLS.Controls.Add(this.label_TA);
            this.tabPage_DataKLS.Controls.Add(this.label2);
            this.tabPage_DataKLS.Controls.Add(this.button_LihatData);
            this.tabPage_DataKLS.Controls.Add(this.comboBox_DaftarKelas);
            this.tabPage_DataKLS.Controls.Add(this.label1);
            this.tabPage_DataKLS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DataKLS.Name = "tabPage_DataKLS";
            this.tabPage_DataKLS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DataKLS.Size = new System.Drawing.Size(779, 492);
            this.tabPage_DataKLS.TabIndex = 0;
            this.tabPage_DataKLS.Text = "Pilih Data";
            this.tabPage_DataKLS.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DaftarSiswa
            // 
            this.dataGridView_DaftarSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DaftarSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DaftarSiswa.Location = new System.Drawing.Point(8, 163);
            this.dataGridView_DaftarSiswa.Name = "dataGridView_DaftarSiswa";
            this.dataGridView_DaftarSiswa.Size = new System.Drawing.Size(763, 321);
            this.dataGridView_DaftarSiswa.TabIndex = 6;
            this.dataGridView_DaftarSiswa.DoubleClick += new System.EventHandler(this.dataGridView_DaftarSiswa_DoubleClick);
            // 
            // label_SMST
            // 
            this.label_SMST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SMST.AutoSize = true;
            this.label_SMST.Location = new System.Drawing.Point(432, 50);
            this.label_SMST.Name = "label_SMST";
            this.label_SMST.Size = new System.Drawing.Size(51, 13);
            this.label_SMST.TabIndex = 5;
            this.label_SMST.Text = "Semester";
            // 
            // label_TA
            // 
            this.label_TA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TA.AutoSize = true;
            this.label_TA.Location = new System.Drawing.Point(360, 50);
            this.label_TA.Name = "label_TA";
            this.label_TA.Size = new System.Drawing.Size(38, 13);
            this.label_TA.TabIndex = 4;
            this.label_TA.Text = "Tahun";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "CETAK RAPOT";
            // 
            // button_LihatData
            // 
            this.button_LihatData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LihatData.Location = new System.Drawing.Point(480, 102);
            this.button_LihatData.Name = "button_LihatData";
            this.button_LihatData.Size = new System.Drawing.Size(117, 22);
            this.button_LihatData.TabIndex = 2;
            this.button_LihatData.Text = "Tampilkan Data";
            this.button_LihatData.UseVisualStyleBackColor = true;
            // 
            // comboBox_DaftarKelas
            // 
            this.comboBox_DaftarKelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_DaftarKelas.FormattingEnabled = true;
            this.comboBox_DaftarKelas.Location = new System.Drawing.Point(339, 102);
            this.comboBox_DaftarKelas.Name = "comboBox_DaftarKelas";
            this.comboBox_DaftarKelas.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DaftarKelas.TabIndex = 1;
            this.comboBox_DaftarKelas.SelectedIndexChanged += new System.EventHandler(this.comboBox_DaftarKelas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilih Data Kelas";
            // 
            // tabPage_CetakRapot
            // 
            this.tabPage_CetakRapot.Controls.Add(this.button_Cetak);
            this.tabPage_CetakRapot.Controls.Add(this.dataGridView_RapotNilai);
            this.tabPage_CetakRapot.Controls.Add(this.panel1);
            this.tabPage_CetakRapot.Controls.Add(this.label3);
            this.tabPage_CetakRapot.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CetakRapot.Name = "tabPage_CetakRapot";
            this.tabPage_CetakRapot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CetakRapot.Size = new System.Drawing.Size(779, 492);
            this.tabPage_CetakRapot.TabIndex = 1;
            this.tabPage_CetakRapot.Text = "Cetak Rapot";
            this.tabPage_CetakRapot.UseVisualStyleBackColor = true;
            // 
            // dataGridView_RapotNilai
            // 
            this.dataGridView_RapotNilai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_RapotNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RapotNilai.Location = new System.Drawing.Point(131, 169);
            this.dataGridView_RapotNilai.Name = "dataGridView_RapotNilai";
            this.dataGridView_RapotNilai.Size = new System.Drawing.Size(511, 315);
            this.dataGridView_RapotNilai.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label_RapotTHN);
            this.panel1.Controls.Add(this.label_RapotSMT);
            this.panel1.Controls.Add(this.label_RapotKelas);
            this.panel1.Controls.Add(this.label_RapotNIS);
            this.panel1.Controls.Add(this.label_RapotNama);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 81);
            this.panel1.TabIndex = 2;
            // 
            // label_RapotTHN
            // 
            this.label_RapotTHN.AutoSize = true;
            this.label_RapotTHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RapotTHN.Location = new System.Drawing.Point(689, 50);
            this.label_RapotTHN.Name = "label_RapotTHN";
            this.label_RapotTHN.Size = new System.Drawing.Size(0, 13);
            this.label_RapotTHN.TabIndex = 9;
            // 
            // label_RapotSMT
            // 
            this.label_RapotSMT.AutoSize = true;
            this.label_RapotSMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RapotSMT.Location = new System.Drawing.Point(634, 50);
            this.label_RapotSMT.Name = "label_RapotSMT";
            this.label_RapotSMT.Size = new System.Drawing.Size(0, 13);
            this.label_RapotSMT.TabIndex = 8;
            // 
            // label_RapotKelas
            // 
            this.label_RapotKelas.AutoSize = true;
            this.label_RapotKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RapotKelas.Location = new System.Drawing.Point(634, 15);
            this.label_RapotKelas.Name = "label_RapotKelas";
            this.label_RapotKelas.Size = new System.Drawing.Size(0, 13);
            this.label_RapotKelas.TabIndex = 7;
            // 
            // label_RapotNIS
            // 
            this.label_RapotNIS.AutoSize = true;
            this.label_RapotNIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RapotNIS.Location = new System.Drawing.Point(163, 50);
            this.label_RapotNIS.Name = "label_RapotNIS";
            this.label_RapotNIS.Size = new System.Drawing.Size(0, 13);
            this.label_RapotNIS.TabIndex = 6;
            // 
            // label_RapotNama
            // 
            this.label_RapotNama.AutoSize = true;
            this.label_RapotNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RapotNama.Location = new System.Drawing.Point(163, 15);
            this.label_RapotNama.Name = "label_RapotNama";
            this.label_RapotNama.Size = new System.Drawing.Size(0, 13);
            this.label_RapotNama.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Semester/Tahun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "NIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Lengkap";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "RAPOT NILAI";
            // 
            // button_Cetak
            // 
            this.button_Cetak.Location = new System.Drawing.Point(682, 454);
            this.button_Cetak.Name = "button_Cetak";
            this.button_Cetak.Size = new System.Drawing.Size(89, 30);
            this.button_Cetak.TabIndex = 14;
            this.button_Cetak.Text = "Cetak Kartu";
            this.button_Cetak.UseVisualStyleBackColor = true;
            this.button_Cetak.Click += new System.EventHandler(this.button_Cetak_Click);
            // 
            // CetakRapot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 518);
            this.Controls.Add(this.tabControl_CetakRapot);
            this.Name = "CetakRapot";
            this.Text = "CetakRapot";
            this.Load += new System.EventHandler(this.CetakRapot_Load);
            this.tabControl_CetakRapot.ResumeLayout(false);
            this.tabPage_DataKLS.ResumeLayout(false);
            this.tabPage_DataKLS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DaftarSiswa)).EndInit();
            this.tabPage_CetakRapot.ResumeLayout(false);
            this.tabPage_CetakRapot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RapotNilai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_CetakRapot;
        private System.Windows.Forms.TabPage tabPage_DataKLS;
        private System.Windows.Forms.TabPage tabPage_CetakRapot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LihatData;
        private System.Windows.Forms.ComboBox comboBox_DaftarKelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_DaftarSiswa;
        private System.Windows.Forms.Label label_SMST;
        private System.Windows.Forms.Label label_TA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_RapotSMT;
        private System.Windows.Forms.Label label_RapotKelas;
        private System.Windows.Forms.Label label_RapotNIS;
        private System.Windows.Forms.Label label_RapotNama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_RapotNilai;
        private System.Windows.Forms.Label label_RapotTHN;
        private System.Windows.Forms.Button button_Cetak;

    }
}