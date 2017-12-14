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
    public partial class Keuangan : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public Keuangan()
        {
            InitializeComponent();
        }

        //--------------------------MENU DATA LULUS---------------------------------//
        private void buttonTampilkanSemuaData_Click(object sender, EventArgs e)
        {
            DataNilai();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            if (textBoxNomorUjian.Text.Trim() == string.Empty)
            { MessageBox.Show("Situ Mau Nyari Apa Gan Isi Dulu", "Keterangan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();
                String query = "SELECT * FROM  vw_NILAI_KELULUSAN WHERE ID_DAFTAR = " + textBoxNomorUjian.Text + "";
                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                OleDbDataAdapter da = new OleDbDataAdapter(komen);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewHasilUjian.DataSource = dt;
                koneksi.Close();
            }
        }

         public void dataGridViewHasilUjian_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlKeuangan.SelectTab(tabPageDaftarUlang);

            string IDCari = dataGridViewHasilUjian.CurrentRow.Cells["ID_DAFTAR"].Value.ToString();

            string query = "";
            query = "SELECT * FROM vw_NILAI_TEST WHERE ID_DAFTAR = " + IDCari + "";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                #region AmbilDataDariTabel
                string NAMA_LENGKAP = dt.Rows[0]["NAMA_LENGKAP"].ToString();
                string ID_DAFTAR = dt.Rows[0]["ID_DAFTAR"].ToString();
                string KD_JURUSAN = dt.Rows[0]["KD_JURUSAN"].ToString();
                string TEMPAT_LHR = dt.Rows[0]["TEMPAT_LHR"].ToString();
                string TANGGAL_LHR = Convert.ToDateTime(dt.Rows[0]["TANGGAL_LHR"]).ToString("dd/MM/yyyy");
                string TANGGAL_DAFTAR = Convert.ToDateTime(dt.Rows[0]["TANGGAL_DAFTAR"]).ToString("yyyy");
                string JENIS_KEL = dt.Rows[0]["JENIS_KEL"].ToString();
                string AGAMA = dt.Rows[0]["AGAMA"].ToString();
                string ALAMAT = dt.Rows[0]["ALAMAT_SKRG"].ToString();
                string NO_TLP = dt.Rows[0]["NO_TLP"].ToString();
                string EMAIL = dt.Rows[0]["EMAIL"].ToString();
                string NAMA_AYAH = dt.Rows[0]["NAMA_AYAH"].ToString();
                string TANGGAL_LHR_AYAH = Convert.ToDateTime(dt.Rows[0]["TANGGAL_LHR_AYAH"]).ToString("dd/MM/yyyy");
                string ALAMAT_AYAH = dt.Rows[0]["ALAMAT_AYAH"].ToString();
                string PEKERJAAN_AYAH = dt.Rows[0]["PEKERJAAN_AYAH"].ToString();
                string PENGHASILAN_AYAH = dt.Rows[0]["PENGHASILAN_AYAH"].ToString();
                string NAMA_IBU = dt.Rows[0]["NAMA_IBU"].ToString();
                string TANGGAL_LHR_IBU = Convert.ToDateTime(dt.Rows[0]["TANGGAL_LHR_IBU"]).ToString("dd/MM/yyyy");
                string ALAMAT_IBU = dt.Rows[0]["ALAMAT_IBU"].ToString();
                string PEKERJAAN_IBU = dt.Rows[0]["PEKERJAAN_IBU"].ToString();
                string PENGHASILAN_IBU = dt.Rows[0]["PENGHASILAN_IBU"].ToString();
                string JURUSAN = dt.Rows[0]["JURUSAN"].ToString();



                textBoxNamaLengkap.Text = NAMA_LENGKAP;
                textBoxNoDaftar.Text = ID_DAFTAR;
                textBoxTgl_Lahir.Text = TANGGAL_LHR;
                textBoxThn_Daftar.Text = TANGGAL_DAFTAR;
                textBoxJurusan.Text = KD_JURUSAN;
                textTEMPAT_LHR.Text = TEMPAT_LHR;
                textJENIS_KEL.Text = JENIS_KEL;
                textAGAMA.Text = AGAMA;
                textALAMAT.Text = ALAMAT;
                textNO_TLP.Text = NO_TLP;
                textEMAIL.Text = EMAIL;
                textNAMA_AYAH.Text = NAMA_AYAH;
                textTANGGAL_LHR_AYAH.Text = TANGGAL_LHR_AYAH;
                textALAMAT_AYAH.Text = ALAMAT_AYAH;
                textPEKERJAAN_AYAH.Text = PEKERJAAN_AYAH;
                textPENGHASILAN_AYAH.Text = PENGHASILAN_AYAH;
                textNAMA_IBU.Text = NAMA_IBU;
                textTANGGAL_LHR_IBU.Text = TANGGAL_LHR_IBU;
                textALAMAT_IBU.Text = ALAMAT_IBU;
                textPEKERJAAN_IBU.Text = PEKERJAAN_IBU;
                textPENGHASILAN_IBU.Text = PENGHASILAN_IBU;
                textJURUSAN.Text = JURUSAN;
                #endregion

            }
            koneksi.Close(); dt = null;
            buttonCekNis_Click(buttonCekNis,e);
        }


        //--------------------------MENU DAFTAR ULANG---------------------------------//
        private void buttonApproveKonfirmasiDaftarUlang_Click(object sender, EventArgs e)
            {
                if (textBoxNoDaftar.Text.Trim() == string.Empty)
                { 
                    MessageBox.Show("Mau masukin apa gan datanya belum ada"); 
                }
                else if (textBoxUploadMasterGuru.Text.Trim() == string.Empty)
                { 
                    MessageBox.Show("Upload Fotonya Gan", "Keterangan"); 
                }
                else
                {
                    #region CekRangkapData
                    OleDbConnection koneksi = new OleDbConnection(db);
                    koneksi.Open();
                    
                    string query = "SELECT * FROM  DATA_NIS WHERE ID_DAFTAR = " + textBoxNoDaftar.Text + "";
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
                        string query_3 = "";
                        string query_4 = "";

                        query_2 = "INSERT INTO DATA_NIS (ID_DAFTAR, NIS) VALUES ('"
                                + textBoxNoDaftar.Text.Replace("'", "''") + "', '" //ID
                                + textBoxNis.Text.Replace("'", "''") + "')"; //NIS
                        query_3 = "INSERT INTO DATA_KEUANGAN (ID_DAFTAR, ID_KEUANGAN,STATUS) VALUES (" + textBoxNoDaftar.Text + ",6,'" + "LUNAS" + "') ";
                       
                        query_4 = "INSERT INTO MASTER_SISWA(NIS, NAMA_LENGKAP, KELAS, TEMPAT_LHR, TANGGAL_LHR, JENIS_KEL, AGAMA, " +
                        "ALAMAT, NO_TLP, EMAIL, NAMA_AYAH, TANGGAL_LHR_AYAH, ALAMAT_AYAH, " +
                        #region query_4 buat insert ke master_siswa
                        "PEKERJAAN_AYAH, PENGHASILAN_AYAH,NAMA_IBU, TANGGAL_LHR_IBU, ALAMAT_IBU, PEKERJAAN_IBU, " +
                        "PENGHASILAN_IBU, KD_JURUSAN, FOTO_SISWA ) VALUES ('"
                        + textBoxNis.Text.Replace("'", "''") + "', '" //NIS
                        + textBoxNamaLengkap.Text.Replace("'", "''") + "', '" // NAMA_LENGKAP
                        + "Belum Ada Kelas" + "', '" //KELAS
                        + textTEMPAT_LHR.Text.Replace("'", "''") + "', '" // TEMPAT_LHR
                        + textBoxTgl_Lahir.Text.Replace("'", "''") + "', '"  //TANGGAL_LHR
                        + textJENIS_KEL.Text.Replace("'", "''") + "', '" //JENIS_KEL
                        + textAGAMA.Text.Replace("'", "''") + "', '" //AGAMA
                        + textALAMAT.Text.Replace("'", "''") + "', '" //ALAMAT
                        + textNO_TLP.Text.Replace("'", "''") + "', '" //NO_TLP
                        + textEMAIL.Text.Replace("'", "''") + "', '" //EMAIL
                        + textNAMA_AYAH.Text.Replace("'", "''") + "', '" //NAMA_AYAH
                        + textTANGGAL_LHR_AYAH.Text.Replace("'", "''") + "', '" //TANGGAL_LHR_AYAH
                        + textALAMAT_AYAH.Text.Replace("'", "''") + "', '" //ALAMAT_AYAH
                        + textPEKERJAAN_AYAH.Text.Replace("'", "''") + "', "// PEKERJAAN_AYAH
                        + textPENGHASILAN_AYAH.Text.Replace("'", "''") + ", '"//PENGHASILAN_AYAH
                        + textNAMA_IBU.Text.Replace("'", "''") + "', '" //NAMA_IBU
                        + textTANGGAL_LHR_IBU.Text.Replace("'", "''") + "', '" //TANGGAL_LHR_IBU
                        + textALAMAT_IBU.Text.Replace("'", "''") + "', '" //ALAMAT_IBU
                        + textPEKERJAAN_IBU.Text.Replace("'", "''") + "', " //PEKERJAAN_IBU
                        + textPENGHASILAN_IBU.Text.Replace("'", "''") + ", '" //PENGHASILAN_IBU
                        + textBoxJurusan.Text.Replace("'", "''") + "', '" //KD_JURUSAN
                        + textBoxUploadMasterGuru.Text.Replace("'", "''") + "')"; //GAMBAR//END
                        #endregion


                        OleDbCommand komen_2 = new OleDbCommand();
                        komen_2.CommandText = query_2;
                        komen_2.Connection = koneksi_2;
                        komen_2.ExecuteNonQuery();
                        OleDbCommand komen_3 = new OleDbCommand();
                        komen_3.CommandText = query_3;
                        komen_3.Connection = koneksi_2;
                        komen_3.ExecuteNonQuery();
                        OleDbCommand komen_4 = new OleDbCommand();
                        komen_4.CommandText = query_4;
                        komen_4.Connection = koneksi_2;
                        komen_4.ExecuteNonQuery();
                        koneksi_2.Close();
                        MessageBox.Show("Data Berhasil Disimpan");
                        DataNIS();
                    }  
                }
                
            }

        #region CekNIS
        private void buttonCekNis_Click(object sender, EventArgs e)
        {

            string thn_daftar = textBoxThn_Daftar.Text;
            string jurusan = textBoxJurusan.Text;
            string nodaftar;
            int id = 0;
            Int32.TryParse(textBoxNoDaftar.Text, out id);
            if (id < 10)
            {
                nodaftar = "000" + id.ToString();
            }
            else if (id < 100)
            {
                nodaftar = "00" + id.ToString();
            }
            else if (id < 1000)
            {
                nodaftar = "0" + id.ToString();
            }
            else
            {
                nodaftar = id.ToString();
            }
            textBoxNis.Text = thn_daftar + jurusan + nodaftar;
        }

        #endregion //BUAT CEK NIS ADA DIMARI //



        //DATA DATA ADA DIMARI//
        #region DataData definition

        public void DataNilai()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  vw_NILAI_TEST";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewHasilUjian.DataSource = dt;
            koneksi.Close();
        }

        public void DataNIS()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  vw_DATA_NIS";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDaftarUlang.DataSource = dt;
            koneksi.Close();
        }

        #endregion




        private void Keuangan_Load(object sender, EventArgs e)
        {
            DataNilai();
            DataNIS();
        }

        private void buttonUploadMasterGuru_Click(object sender, EventArgs e)
        {
            openFileDialogKeuangan.InitialDirectory = "D:\\";
            openFileDialogKeuangan.Filter = "All Files|*.*|JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp";
            openFileDialogKeuangan.FilterIndex = 2;

            if (openFileDialogKeuangan.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMasterGuru.Image = Image.FromFile(openFileDialogKeuangan.FileName);
                pictureBoxMasterGuru.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMasterGuru.BorderStyle = BorderStyle.Fixed3D;
                textBoxUploadMasterGuru.Text = openFileDialogKeuangan.FileName;
            }
        }





    }
}
