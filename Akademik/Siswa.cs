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
    public partial class Siswa : Form
    {

        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public Siswa()
        {
            InitializeComponent();
        }

        private void buttonLihatDataKelas_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  MASTER_SISWA WHERE KELAS = '" + comboBoxDataSiswa.Text + "'";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDataSiswa.DataSource = dt;
            koneksi.Close();
        }

        private void buttonTampilSemuaData_Click(object sender, EventArgs e)
        {
            DataSiswa();
        }

        private void dataGridViewDataSiswa_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlSiswa.SelectTab(Tambah_Kelas);

            string IDCari = dataGridViewDataSiswa.CurrentRow.Cells["NIS"].Value.ToString();

            string query = "";
            query = "SELECT * FROM MASTER_SISWA WHERE NIS = '" + IDCari + "'";
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
                string NIS = dt.Rows[0]["NIS"].ToString();
                string KELAS = dt.Rows[0]["KELAS"].ToString();
                string KDJURUSAN = dt.Rows[0]["KD_JURUSAN"].ToString();



                textBoxNama.Text = NAMA_LENGKAP;
                textBoxNIS.Text = NIS;
                textBoxJurusan.Text = KDJURUSAN;
                textBoxKelasLama.Text = KELAS;
                #endregion

                #region Buat data kelas seuai jurusan
                string query_2 = "SELECT * FROM MASTER_KELAS WHERE KD_JURUSAN = '" + textBoxJurusan.Text + "'";

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = query_2;
                cmd.Connection = koneksi;

                OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd);
                DataTable dt_2 = new DataTable();
                da_2.Fill(dt_2);

                for (int i = 0; i < dt_2.Rows.Count; i++)
                {
                    comboBoxKelasBaru.Items.Add(dt_2.Rows[i]["KELAS"].ToString());
                }
                #endregion

            }
            koneksi.Close(); dt = null;
        }

        private void buttonKonfirm_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "";


            query = "UPDATE MASTER_SISWA SET KELAS = '"
                    + comboBoxKelasBaru.Text.Replace("'", "''") + "' WHERE NIS = '" //ID
                    + textBoxNIS.Text + "'"; //NIS


            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            komen.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan");
            DataSiswa();
        }


        //DATA DATA ADA DIMARI//
        public void DataSiswa()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  MASTER_SISWA ORDER BY KELAS";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDataSiswa.DataSource = dt;
            dataGridViewDaftarSiswa.DataSource = dt;
            koneksi.Close();
        }

        public void DataKelas()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_KELAS";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxDataSiswa.Items.Add(dt.Rows[i]["KELAS"].ToString());
            }
            koneksi.Close();
        }

        private void Siswa_Load(object sender, EventArgs e)
        {
            DataSiswa();
            DataKelas();
        }


    }
}
