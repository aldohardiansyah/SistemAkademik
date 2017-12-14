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


        //---------------------MENU MASTER BIODATA----------------------//
        private void buttonSimpanMasterBiodata_Click(object sender, EventArgs e)
        {
            #region nilai tidak di isi
            //Cek Data Yang Ga Diisi//
            if (textBoxNamaLengkapMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Nama Lengkap belum diisi Gan"); }
            else if (textBoxNamaPanggilanMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Nama Panggilannya belum diisi Gan"); }
            else if (textBoxTempatLhrMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Tempat Lahir belum diisi Gan"); }
            else if (dateTimePickerTanggalLhrMasterBiodata.Value.ToString() == string.Empty)
            { MessageBox.Show("Tanggal belum diisi Gan"); }
            else if (comboBoxJenisKelaminMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Jenis Kelamin belum diisi Gan"); }
            else if (comboBoxAgamaMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Agama belum diisi Gan"); }
            else if (textBoxHobbyMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Hobi belum diisi Gan"); }
            else if (textBoxCitaMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Cita-cita belum diisi Gan"); }
            else if (textBoxBahasaMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Bahasa belum diisi Gan"); }
            else if (textBoxKewarganegaraanMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Kewarganegaraan belum diisi Gan"); }
            else if (comboBoxStatusKlgMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Status Keluarga belum diisi Gan"); }
            else if (comboBoxEkoKlgMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Keadaan Ekonomi belum diisi Gan"); }
            else if (textBoxAlamatMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Alamat belum diisi Gan"); }
            else if (textBoxAlamatSkrgMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Alamat Sekarang belum diisi Gan"); }
            else if (textBoxTinggalMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Tinggal Bersama belum diisi Gan"); }
            else if (comboBoxKeadaan_RumahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Keadaan Rumah belum diisi Gan"); }
            else if (comboBoxR_TidurMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Ruang Tidur belum diisi Gan"); }
            else if (comboBoxR_BelajarMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Ruang Belajar belum diisi Gan"); }
            else if (comboBoxPenunjangBelajarMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Penunjang Belajar belum diisi Gan"); }
            else if (textBoxNo_TlpMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("No. Telp belum diisi Gan"); }
            else if (textBoxEmailMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Email belum diisi Gan"); }
            else if (textBoxNama_AyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Nama Ayah belum diisi Gan"); }
            else if (textBoxTempat_Lhr_AyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Tempat Lahir Ayah belum diisi Gan"); }
            else if (dateTimePickerTanggal_Lhr_AyahMasterBiodata.Value.ToString() == string.Empty)
            { MessageBox.Show("Tanggal Lahir Ayah belum diisi Gan"); }
            else if (textBoxAlamat_AyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Alamat Ayah belum diisi Gan"); }
            else if (comboBoxAgama_AyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Agama belum diisi Gan"); }
            else if (textBoxPekerjaan_AyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Pekerjaan Ayah belum diisi Gan"); }
            else if (textBoxPendidikan_AyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Pendidikan Ayah belum diisi Gan"); }
            else if (textBoxPenghasilanAyahMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Penghasilan Ayah belum diisi Gan"); }
            else if (textBoxNama_IbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Nama Ibu belum diisi Gan"); }
            else if (textBoxTempat_Lhr_IbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Tempat Lahir Ibu belum diisi Gan"); }
            else if (dateTimePickerTanggal_Lhr_IbuMasterBiodata.Value.ToString() == string.Empty)
            { MessageBox.Show("Tanggal Lahir Ibu belum diisi Gan"); }
            else if (textBoxAlamat_IbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Alamat Ibu belum diisi Gan"); }
            else if (comboBoxAgamaIbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Agama Ibu belum diisi Gan"); }
            else if (textBoxPekerjaan_IbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Pekerjaan Ibu belum diisi Gan"); }
            else if (textBoxPendidikan_IbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Pendidikan Ibu belum diisi Gan"); }
            else if (textBoxPenghasilan_IbuMasterBiodata.Text.Trim() == string.Empty)
            { MessageBox.Show("Penghasilan Ibu belum diisi Gan"); }
            #endregion
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();

                string query = "";
                query = "INSERT INTO MASTER_BIODATA (TANGGAL_DAFTAR, NAMA_LENGKAP, NAMA, " +
                        "TEMPAT_LHR, TANGGAL_LHR, JENIS_KEL, AGAMA, HOBBY, CITA, " +
                        "BAHASA, KEWARGANEGARAAN, STATUS_KLG, EKO_KLG, ALAMAT, ALAMAT_SKRG, " +
                        "TINGGAL, KEADAAN_RUMAH, R_TIDUR, R_BELAJAR, PENUNJANG_BELAJAR, " +
                        "NO_TLP, EMAIL, NAMA_AYAH, TEMPAT_LHR_AYAH, TANGGAL_LHR_AYAH, ALAMAT_AYAH, AGAMA_AYAH, " +
                        "PEKERJAAN_AYAH, PENDIDIKAN_AYAH, PENGHASILAN_AYAH, NAMA_IBU, TEMPAT_LHR_IBU," +
                        "TANGGAL_LHR_IBU, ALAMAT_IBU, AGAMA_IBU, PEKERJAAN_IBU, PENDIDIKAN_IBU, " +
                        "PENGHASILAN_IBU ) VALUES ('"
                        + DateTime.Now.ToString() + "', '"  //TANGGAL_DAFTAR
                        + textBoxNamaLengkapMasterBiodata.Text.Replace("'", "''") + "', '" //NAMA_LENGKAP
                        + textBoxNamaPanggilanMasterBiodata.Text.Replace("'", "''") + "', '" // NAMA
                        + textBoxTempatLhrMasterBiodata.Text.Replace("'", "''") + "', '" //TEMPAT_LHR
                        + dateTimePickerTanggalLhrMasterBiodata.Value.ToString() + "', '"  //TANGGAL_LHR
                        + comboBoxJenisKelaminMasterBiodata.Text.Replace("'", "''") + "', '" //JENIS_KEL
                        + comboBoxAgamaMasterBiodata.Text.Replace("'", "''") + "', '" //AGAMA
                        + textBoxHobbyMasterBiodata.Text.Replace("'", "''") + "', '" //HOBBY
                        + textBoxCitaMasterBiodata.Text.Replace("'", "''") + "', '" //CITA
                        + textBoxBahasaMasterBiodata.Text.Replace("'", "''") + "', '" //BAHASA
                        + textBoxKewarganegaraanMasterBiodata.Text.Replace("'", "''") + "', '" //KEWARGANEGARAAN
                        + comboBoxStatusKlgMasterBiodata.Text.Replace("'", "''") + "', '" //STATUS_KLG
                        + comboBoxEkoKlgMasterBiodata.Text.Replace("'", "''") + "', '" //EKO_KLG
                        + textBoxAlamatMasterBiodata.Text.Replace("'", "''") + "', '" //ALAMAT
                        + textBoxAlamatSkrgMasterBiodata.Text.Replace("'", "''") + "', '" //ALAMAT_SKRG
                        + textBoxTinggalMasterBiodata.Text.Replace("'", "''") + "', '"// TINGGAL
                        + comboBoxKeadaan_RumahMasterBiodata.Text.Replace("'", "''") + "', '"//KEADAAN_RUMAH
                        + comboBoxR_TidurMasterBiodata.Text.Replace("'", "''") + "', '" //R_TIDUR
                        + comboBoxR_BelajarMasterBiodata.Text.Replace("'", "''") + "', '" //R_BELAJAR
                        + comboBoxPenunjangBelajarMasterBiodata.Text.Replace("'", "''") + "', '" //PENUNJANG_BELAJAR
                        + textBoxNo_TlpMasterBiodata.Text.Replace("'", "''") + "', '" //NO_TLP
                        + textBoxEmailMasterBiodata.Text.Replace("'", "''") + "', '" //EMAIL
                        + textBoxNama_AyahMasterBiodata.Text.Replace("'", "''") + "', '" //NAMA_AYAH
                        + textBoxTempat_Lhr_AyahMasterBiodata.Text.Replace("'", "''") + "', '" //TEMPAT_LHR_AYAH
                        + dateTimePickerTanggal_Lhr_AyahMasterBiodata.Value.ToString() + "', '" //TANGGAL_LAHIR_AYAH
                        + textBoxAlamat_AyahMasterBiodata.Text.Replace("'", "''") + "', '" //ALAMAT_AYAH
                        + comboBoxAgama_AyahMasterBiodata.Text.Replace("'", "''") + "', '" //AGAMA_AYAH
                        + textBoxPekerjaan_AyahMasterBiodata.Text.Replace("'", "''") + "', '" //PEKERJAAN_AYAH
                        + textBoxPendidikan_AyahMasterBiodata.Text.Replace("'", "''") + "', " //PENDIDIKAN_AYAH
                        + textBoxPenghasilanAyahMasterBiodata.Text.Replace("'", "''") + ", '" //PENGHASILAN_AYAH
                        + textBoxNama_IbuMasterBiodata.Text.Replace("'", "''") + "', '" //NAMA_IBU
                        + textBoxTempat_Lhr_IbuMasterBiodata.Text.Replace("'", "''") + "', '" //TEMPAT_LHR_IBU
                        + dateTimePickerTanggal_Lhr_IbuMasterBiodata.Value.ToString() + "', '" //TANGGAL_LHR_IBU
                        + textBoxAlamat_IbuMasterBiodata.Text.Replace("'", "''") + "', '" //ALAMAT_IBU
                        + comboBoxAgamaIbuMasterBiodata.Text.Replace("'", "''") + "', '" //AGAMA_IBU
                        + textBoxPekerjaan_IbuMasterBiodata.Text.Replace("'", "''") + "', '" //PEKERJAAN_IBU
                        + textBoxPendidikan_IbuMasterBiodata.Text.Replace("'", "''") + "', " //PENDIDIKAN_IBU
                        + textBoxPenghasilan_IbuMasterBiodata.Text.Replace("'", "''") + ")"; //PENGHASILAN_IBU //END

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                Data();
            }
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
                query = "INSERT INTO MASTER_GURU (NAMA_LENGKAP, " +
                        "TEMPAT_LAHIR, TANGGAL_LAHIR, JENIS_KELAMIN, TINGGI_BADAN, BERAT_BADAN, AGAMA, " +
                        "KEWARGANEGARAAN, STATUS_PERKAWINAN, ALAMAT, NOMOR_TLPN, EMAIL, " +
                        "PENDIDIKAN, PENGALAMAN_KERJA, KETERAMPILAN, GAMBAR ) VALUES ('"
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
        public void Data()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM MASTER_BIODATA";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBiodata.DataSource = dt;
            koneksi.Close();
        }

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
            Data();
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
