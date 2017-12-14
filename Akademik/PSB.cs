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
    public partial class PSB : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public PSB()
        {
            InitializeComponent();
        }

        //---------------------MENU INPUT EDIT----------------------//
        //SIMPAN BIODATA//
        private void buttonSimpanMasterBiodata_Click(object sender, EventArgs e)
        {
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
            else if (comboBoxJurusan.Text.Trim() == string.Empty)
            { MessageBox.Show("Jurusan belum dipilih Gan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();
                string query = "";
                query = "INSERT INTO MASTER_BIODATA (TANGGAL_DAFTAR, NAMA_LENGKAP, NAMA, " +
                        "TEMPAT_LHR, TANGGAL_LHR, JENIS_KEL, AGAMA, " +
                        "BAHASA, KEWARGANEGARAAN, STATUS_KLG, EKO_KLG, ALAMAT, ALAMAT_SKRG, " +
                        "TINGGAL, KEADAAN_RUMAH, R_TIDUR, R_BELAJAR, PENUNJANG_BELAJAR, " +
                        "NO_TLP, EMAIL, NAMA_AYAH, TEMPAT_LHR_AYAH, TANGGAL_LHR_AYAH, ALAMAT_AYAH, AGAMA_AYAH, " +
                        "PEKERJAAN_AYAH, PENDIDIKAN_AYAH, PENGHASILAN_AYAH, NAMA_IBU, TEMPAT_LHR_IBU," +
                        "TANGGAL_LHR_IBU, ALAMAT_IBU, AGAMA_IBU, PEKERJAAN_IBU, PENDIDIKAN_IBU, " +
                        "PENGHASILAN_IBU, JURUSAN ) VALUES ('"
                        + DateTime.Now.ToString() + "', '"  //TANGGAL_DAFTAR
                        + textBoxNamaLengkapMasterBiodata.Text.Replace("'", "''") + "', '" //NAMA_LENGKAP
                        + textBoxNamaPanggilanMasterBiodata.Text.Replace("'", "''") + "', '" // NAMA
                        + textBoxTempatLhrMasterBiodata.Text.Replace("'", "''") + "', '" //TEMPAT_LHR
                        + dateTimePickerTanggalLhrMasterBiodata.Value.ToString() + "', '"  //TANGGAL_LHR
                        + comboBoxJenisKelaminMasterBiodata.Text.Replace("'", "''") + "', '" //JENIS_KEL
                        + comboBoxAgamaMasterBiodata.Text.Replace("'", "''") + "', '" //AGAMA
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
                        + textBoxPenghasilan_IbuMasterBiodata.Text.Replace("'", "''") + ", '" //PENGHASILAN_IBU
                        + comboBoxJurusan.Text.Replace("'", "''") + "')"; //JURUSAN //END

                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                komen.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                Data();
            }
        }

        //-----------------------------------------------------------//



        //---------------------MENU DAFTAR KEUANGAN CALON SISWA----------------------//

        //BUKA EDIT KLIK PADA TABEL MENU DAFTAR KEUANGAN CALON SISWA//
        private void dataGridViewKeuanganDaftarCalonSiswa_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlMainMenu.SelectTab(tabPageKonfirmasi);

            string IDCari = dataGridViewKeuanganDaftarCalonSiswa.CurrentRow.Cells["ID_DAFTAR"].Value.ToString();

            string query = "";
            query = "SELECT * FROM MASTER_BIODATA WHERE ID_DAFTAR = " + IDCari + "";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string NamaLengkap = dt.Rows[0]["NAMA_LENGKAP"].ToString();
                string IDDaftar = dt.Rows[0]["ID_DAFTAR"].ToString();
                string TglLahir = dt.Rows[0]["TANGGAL_LHR"].ToString();
                string Alamat = dt.Rows[0]["ALAMAT_SKRG"].ToString();
                string TglDaftar = dt.Rows[0]["TANGGAL_DAFTAR"].ToString();
                string NamaAyah = dt.Rows[0]["NAMA_AYAH"].ToString();
                string NamaIbu = dt.Rows[0]["NAMA_IBU"].ToString();

                textBoxDaftarKeuanganCalonSiswa_NamaLengkap.Text = NamaLengkap;
                textBoxDaftarKeuanganCalonSiswa_ID.Text = IDDaftar;
                textBoxDaftarKeuanganCalonSiswa_TglLahir.Text = TglLahir;
                textBoxDaftarKeuanganCalonSiswa_Alamat.Text = Alamat;
                textBoxDaftarKeuanganCalonSiswa_TglDaftar.Text = TglDaftar;
                textBoxDaftarKeuanganCalonSiswa_NamaAyah.Text = NamaAyah;
                textBoxDaftarKeuanganCalonSiswa_NamaIbu.Text = NamaIbu;
            }
            koneksi.Close(); dt = null;
        }

        //APPROVE DATA KEUANGAN//
        private void buttonApproveKeuanganCalonSiswa_Click(object sender, EventArgs e)
        {
            //CEK DATA UDAH DI INPUT BELOM//
            if (textBoxDaftarKeuanganCalonSiswa_ID.Text.Trim() == string.Empty)
            { MessageBox.Show("Pilih Dulu Datanya Gan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();
                string query = "SELECT * FROM  DATA_KEUANGAN WHERE ID_DAFTAR = " + textBoxDaftarKeuanganCalonSiswa_ID.Text + "";
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
                else
                {
                    OleDbConnection con = new OleDbConnection(db);
                    con.Open();

                    string query_2 = "";
                    query_2 = "INSERT INTO DATA_KEUANGAN (ID_KEUANGAN, ID_DAFTAR, STATUS) VALUES (4, " + textBoxDaftarKeuanganCalonSiswa_ID.Text + ", '" + "LUNAS" + "') ";

                    OleDbCommand cmd_2 = new OleDbCommand();
                    cmd_2.CommandText = query_2;
                    cmd_2.Connection = con;
                    cmd_2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Saved", "Keterangan");
                    DataDaftarKeuangan();
                }
            }
        }

        //BUAT BERSIH BERSIH (BUTTON BERSIHKAN)//
        private void buttonBersihkanDaftarKeuanganCalonSiswa_Click(object sender, EventArgs e)
        {
            textBoxDaftarKeuanganCalonSiswa_NamaLengkap.Text = "";
            textBoxDaftarKeuanganCalonSiswa_ID.Text = "";
            textBoxDaftarKeuanganCalonSiswa_TglLahir.Text = "";
            textBoxDaftarKeuanganCalonSiswa_Alamat.Text = "";
            textBoxDaftarKeuanganCalonSiswa_TglDaftar.Text = "";
            textBoxDaftarKeuanganCalonSiswa_NamaAyah.Text = "";
            textBoxDaftarKeuanganCalonSiswa_NamaIbu.Text = "";
        }

        //-----------------------------------------------------------//



        //--------------------DATA DATA ADA DIMARI--------------------------//

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
            dataGridViewKeuanganDaftarCalonSiswa.DataSource = dt;
            dataGridViewKeuanganDaftarCalonSiswa.DataSource = dt;
            koneksi.Close();
        }

        public void DataDaftarKeuangan()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  vw_KEUANGAN_PENDAFTARAN";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDataDaftarKeuangan.DataSource = dt;
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
                comboBoxJurusan.Items.Add(dt.Rows[i]["JURUSAN"].ToString());
            }
            con.Close();
        }

        //-----------------------------------------------------------//


        private void PSB_Load(object sender, EventArgs e)
        {
            Data();
            DataDaftarKeuangan();
            DataJurusanKelas();
        }



        





       
    }
}
