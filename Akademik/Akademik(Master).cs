using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Akademik
{
    public partial class MASTER : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public MASTER()
        {
            InitializeComponent();
        }

        //---------------------MENU MASTER JURUSAN----------------------//
        private void buttonSimpanJurusan_Click(object sender, EventArgs e)
        {
            //Cek Data Yang Ga Diisi//
            if (textBoxJurusan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu jurusannya Gan","Keterangan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();

                string query = "";
                query = "INSERT INTO MASTER_JURUSAN (JURUSAN, KD_JURUSAN) VALUES ('" + textBoxJurusan.Text.Replace("'", "''") + "' , '" + textBoxKDJurusanMasterJurusan.Text + "')"; //JURUSAN

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataMasterJurusan();
            }
        }

        private void dataGridViewMasterTahunAjaran_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string IDCari = dataGridViewMasterTahunAjaran.CurrentRow.Cells["ID_TAHUNAJARAN"].Value.ToString();

            string query = "";
            query = "SELECT * FROM MASTER_TAHUNAJARAN WHERE ID_TAHUNAJARAN = " + IDCari + "";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                #region AmbilDataDariTabel
                string TAHUN = dt.Rows[0]["TAHUN"].ToString();
                string SEMESTER = dt.Rows[0]["SEMESTER"].ToString();

                textBox_TA.Text = TAHUN;
                textBox_SMSTR.Text = SEMESTER;
                #endregion

            }
            koneksi.Close(); dt = null;
        } //DONE

        private void button_SedangBerlangsung_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "";
            query = "UPDATE MASTER_TAHUNAJARAN SET AKTIF = '0' WHERE AKTIF = '1' "; //NIS
            string query_2 = "";
            query_2 = "UPDATE MASTER_TAHUNAJARAN SET AKTIF = '1' WHERE TAHUN = '" + textBox_TA.Text + "' AND SEMESTER='" + textBox_SMSTR.Text + "'"; //NIS

            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            komen.ExecuteNonQuery();
            OleDbCommand komen_2 = new OleDbCommand();
            komen_2.CommandText = query_2;
            komen_2.Connection = koneksi;
            komen_2.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan");
            DataMasterTahunAjaran();
        }



        //---------------------MENU MASTER TAHUN AJARAN----------------------//
        private void buttonSimpanTahunAjaran_Click(object sender, EventArgs e)
        {
            //Cek Data Yang Ga Diisi//
            if (comboBoxSemesterTahunAjaran.Text.Trim() == string.Empty)
            { MessageBox.Show("Semester belum diisi Gan"); }
            else if (textBoxTahunTahunAjaran.Text.Trim() == string.Empty)
            { MessageBox.Show("Tahun belum diisi Gan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();

                string query = "";
                query = "INSERT INTO MASTER_TAHUNAJARAN (SEMESTER, TAHUN) VALUES ('" + comboBoxSemesterTahunAjaran.Text.Replace("'", "''") + "','" + textBoxTahunTahunAjaran.Text.Replace("'", "''") + "')"; //JURUSAN

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataMasterTahunAjaran();
            }
        }


        //---------------------MENU MASTER KEUANGAN----------------------//
        private void buttonSimpanKeuangan_Click(object sender, EventArgs e)
        {
            //Cek Data Yang Ga Diisi//
            if (textBoxJenisKeuangan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Jenis Keuangannya Gan", "Keterangan"); }
            else if (textBoxHarga.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Harganya gan Gan", "Keterangan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();

                string query = "";
                query = "INSERT INTO MASTER_KEUANGAN (JENIS_KEUANGAN, HARGA) VALUES ('" + textBoxJenisKeuangan.Text.Replace("'", "''") + "','" + textBoxHarga.Text.Replace("'", "''") + "')"; //JURUSAN

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataMasterKeuangan();
            }
        }


        //---------------------MENU MASTER MATA PELAJARAN----------------------//
        private void buttonSimpanMataPelajaran_Click(object sender, EventArgs e)
        {
            //Cek Data Yang Ga Diisi//
            if (textBoxKD_MataPelajaran.Text.Trim() == string.Empty)
            { MessageBox.Show("Masukin Kode Mata Pelajarannya dulu gan", "Keterangan"); }
            else if (textBoxNm_MataPelajaran.Text.Trim() == string.Empty)
            { MessageBox.Show("Masukin Nama Mata Pelajaran dulu gan", "Keterangan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();

                string query = "";
                query = "INSERT INTO MASTER_PELAJARAN (KD_MATAPELAJARAN, NAMA_MATAPELAJARAN) VALUES ('" + textBoxKD_MataPelajaran.Text.Replace("'", "''") + "','" + textBoxNm_MataPelajaran.Text.Replace("'", "''") + "')"; //MATAPELAJARAN

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataMasterMataPelajaran();
            }
        }


        //--------------------------MENU MASTER GURU----------------------------------//
        private void buttonSimpanMasterGuru_Click(object sender, EventArgs e)
        {
            //Cek Data Yang Ga Diisi//
            if (textBoxNama_Lengkap.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Nama Lengkao Gan","Keterangan"); }
            else if (textBoxTempatLahir.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Tempat Lahirnya Gan","Keterangan"); }
            else if (dateTimePickerTglLahir.Value.ToString() == string.Empty)
            { MessageBox.Show("Isi dulu Tanggal Lahirnya Gan","Keterangan"); }
            else if (comboBoxJenisKelamin.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Jenis Kelamin Gan","Keterangan"); }
            else if (textBoxTinggiBadan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Tinggi Badannya Gan","Keterangan"); }
            else if (textBoxBeratBadan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Berat Badannya Gan","Keterangan"); }
            else if (comboBoxAgama.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Agamanya Gan","Keterangan"); }
            else if (textBoxKewarganegaraan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Kewarganegaraan Gan","Keterangan"); }
            else if (textBoxStatusPernikahan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Status Pernikahan Gan","Keterangan"); }
            else if (textBoxAlamatRumah.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Alamat Rumah Gan","Keterangan"); }
            else if (textBoxNoTlp.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu No. Telp Gan", "Keterangan"); }
            else if (textBoxEmail.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Email Gan", "Keterangan"); }
            else if (textBoxPendidikan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Pendidikan Gan", "Keterangan"); }
            else if (textBoxPengalamanKerja.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Pengalaman Kerja Gan", "Keterangan"); }
            else if (textBoxKeterampilan.Text.Trim() == string.Empty)
            { MessageBox.Show("Isi dulu Keterampilan Gan", "Keterangan"); }
            else if (textBoxUploadMasterGuru.Text.Trim() == string.Empty)
            { MessageBox.Show("Upload Fotonya Gan", "Keterangan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();

                string query = "";
                query = "INSERT INTO MASTER_GURU (TGL_DAFTAR, NAMA_LENGKAP, " +
                        "TEMPAT_LAHIR, TANGGAL_LAHIR, JENIS_KELAMIN, TINGGI_BADAN, BERAT_BADAN, AGAMA, " +
                        "KEWARGANEGARAAN, STATUS_PERKAWINAN, ALAMAT, NOMOR_TLPN, EMAIL, " +
                        "PENDIDIKAN, PENGALAMAN_KERJA, KETERAMPILAN, GAMBAR ) VALUES ('"
                        + DateTime.Now.ToString() + "', '"  //TANGGAL_DAFTAR
                        + textBoxNama_Lengkap.Text.Replace("'", "''") + "', '" //NAMA_LENGKAP
                        + textBoxTempatLahir.Text.Replace("'", "''") + "', '" // TEMPAT_LAHIR
                        + dateTimePickerTglLahir.Value.ToString() + "', '" //TANGGAL_LAHIR
                        + comboBoxJenisKelamin.Text.Replace("'", "''") + "', "  //JENIS_KELAMIN
                        + textBoxTinggiBadan.Text.Replace("'", "''") + ", " //TINGGI_BADAN
                        + textBoxBeratBadan.Text.Replace("'", "''") + ", '" //BERAT_BADAN
                        + comboBoxAgama.Text.Replace("'", "''") + "', '" //AGAMA
                        + textBoxKewarganegaraan.Text.Replace("'", "''") + "', '" //KEWARGANEGARAAN
                        + textBoxStatusPernikahan.Text.Replace("'", "''") + "', '" //STATUS_PERKAWINAN
                        + textBoxAlamatRumah.Text.Replace("'", "''") + "', '" //ALAMAT
                        + textBoxNoTlp.Text.Replace("'", "''") + "', '" //NOMOR_TLPN
                        + textBoxEmail.Text.Replace("'", "''") + "', '" //EMAIL
                        + textBoxPendidikan.Text.Replace("'", "''") + "', '" //PENDIDIKAN
                        + textBoxPengalamanKerja.Text.Replace("'", "''") + "', '" //PENGALAMAN_KERJA
                        + textBoxKeterampilan.Text.Replace("'", "''") + "', '" //KETERAMPILAN
                        + textBoxUploadMasterGuru.Text.Replace("'", "''") + "')"; //GAMBAR//END

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataMasterGuru();
            }
        }
        private void buttonUploadMasterGuru_Click(object sender, EventArgs e)
        {
            openFileDialogMasterGuru.InitialDirectory = "D:\\";
            openFileDialogMasterGuru.Filter = "All Files|*.*|JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp";
            openFileDialogMasterGuru.FilterIndex = 2;

            if (openFileDialogMasterGuru.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMasterGuru.Image = Image.FromFile(openFileDialogMasterGuru.FileName);
                pictureBoxMasterGuru.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMasterGuru.BorderStyle = BorderStyle.Fixed3D;
                textBoxUploadMasterGuru.Text = openFileDialogMasterGuru.FileName;
            }
        }


        //--------------------------MENU MASTER KELAS----------------------------------//
        private void buttonTambahKelas_Click(object sender, EventArgs e)
        {
            //Cek Data Yang Ga Diisi//
            if (textBoxNoKelas.Text.Trim() == string.Empty || comboBoxJurusan.Text.Trim() == string.Empty || comboBoxTingkat.Text.Trim() == string.Empty)
            { MessageBox.Show("Lengkapi dulu datanya Gan", "Keterangan"); }
            else
            {
                #region CekRangkapData
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();
                string tingkat = comboBoxTingkat.Text;
                string jurusan = comboBoxJurusan.Text;
                string nokelas = textBoxNoKelas.Text;
                string kelas = tingkat + jurusan + nokelas;

                string query = "SELECT * FROM  MASTER_KELAS WHERE KELAS = '" + kelas + "'";
                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                OleDbDataAdapter da = new OleDbDataAdapter(komen);
                DataTable dt = new DataTable();
                da.Fill(dt);
                koneksi.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Udah Ada Gan Gabisa Dimasukin Lagi");
                }
                #endregion
                else
                {
                    OleDbConnection koneksi_2 = new OleDbConnection(db);
                    koneksi_2.Open();

                    string query_2 = "";
                    query_2 = "INSERT INTO MASTER_KELAS (KD_JURUSAN, KELAS) VALUES ('" + comboBoxJurusan.Text.Replace("'", "''") + "' , '" + kelas + "')"; //Kelas

                    OleDbCommand komen_2 = new OleDbCommand();
                    komen_2.CommandText = query_2;
                    komen_2.Connection = koneksi_2;
                    komen_2.ExecuteNonQuery();
                    koneksi_2.Close();
                    MessageBox.Show("Data Berhasil Disimpan");
                    DataMasterKelas();
                }
            }
        }


        //DATA DATA ADA DIMARI//
        #region DataData definition

        public void DataMasterKeuangan()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM MASTER_KEUANGAN";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDataMasterKeuangan.DataSource = dt;
            koneksi.Close();
        }

        public void DataMasterJurusan()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM MASTER_JURUSAN";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMasterJurusan.DataSource = dt;
            koneksi.Close();
        }

        public void DataMasterTahunAjaran()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM MASTER_TAHUNAJARAN";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMasterTahunAjaran.DataSource = dt;
            koneksi.Close();
        }

        public void DataMasterMataPelajaran()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM MASTER_PELAJARAN";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMasterMataPelajaran.DataSource = dt;
            koneksi.Close();
        }

        public void DataMasterGuru()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM MASTER_GURU";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMasterGuru.DataSource = dt;
            koneksi.Close();
        }

        public void DataJurusanKelas()
        {
            OleDbConnection con = new OleDbConnection(db);
            con.Open();
            string query = "SELECT * FROM MASTER_JURUSAN";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = con;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxJurusan.Items.Add(dt.Rows[i]["KD_JURUSAN"].ToString());
            }
            con.Close();
        }

        public void DataMasterKelas()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT KD_JURUSAN, KELAS FROM MASTER_KELAS ORDER BY KELAS";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDaftarKelas.DataSource = dt;
            koneksi.Close();
        }
        
        #endregion


        //LOAD LOAD ADA DIMARI//
        #region LoadData definition
        private void Form1_Load(object sender, EventArgs e)
        {
            DataMasterKeuangan();
            DataMasterJurusan();
            DataMasterTahunAjaran();
            DataMasterMataPelajaran();
            DataMasterGuru();
            DataJurusanKelas();
            DataMasterKelas();
        }
        #endregion

    }
}
