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
    public partial class PanitiaUjian : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public PanitiaUjian()
        {
            InitializeComponent();
        }


        //-------------------KLIK DUA KALI PADA DATA KEUANGAN PENDAFTARAN--------------------------//
        #region Doubleclick
        private void dataGridViewLunasBayar_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlHasilUjian.SelectTab(tabPageMasukanNilai);

            string IDCari = dataGridViewLunasBayar.CurrentRow.Cells["ID_DAFTAR"].Value.ToString();

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


                textBoxNamaLengkap.Text = NamaLengkap;
                textBoxNoDaftar.Text = IDDaftar;

            }
            koneksi.Close(); dt = null;
        }
        #endregion

        //--------------------------MENU HASIL UJIAN---------------------------------//
        #region HASIL UJIAN

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            //CEK DATA UDAH DI INPUT BELOM//
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();

            string query = "SELECT * FROM  DATA_NILAI_TEST WHERE ID_DAFTAR = " + textBoxNoDaftar.Text + "";
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
                OleDbConnection koneksi_2 = new OleDbConnection(db);
                koneksi_2.Open();
                string query_2 = "";
                query_2 = "INSERT INTO DATA_NILAI_TEST (ID_DAFTAR, NILAI, STATUS) VALUES ('"
                        + textBoxNoDaftar.Text.Replace("'", "''") + "', '" //ID Daftar
                        + textBoxNilaiTest.Text.Replace("'", "''") + "', '" //Nilai
                        + textBoxHasil.Text.Replace("'", "''") + "')"; //Hasil

                OleDbCommand komen_2 = new OleDbCommand();
                komen_2.CommandText = query_2;
                komen_2.Connection = koneksi_2;
                komen_2.ExecuteNonQuery();
                koneksi_2.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataNilai();
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            if (textBoxNomorUjian.Text.Trim() == string.Empty)
            { MessageBox.Show("Situ Mau Nyari Apa Gan Isi Dulu", "Keterangan"); }
            else
            {
                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();
                String query = "SELECT * FROM  vw_KEUANGAN_PENDAFTARAN WHERE ID_DAFTAR = " + textBoxNomorUjian.Text + "";
                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                OleDbDataAdapter da = new OleDbDataAdapter(komen);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewLunasBayar.DataSource = dt;
                koneksi.Close();
            }
        }

        private void buttonTampilkanSemuaData_Click(object sender, EventArgs e)
        {
            DataKeuanganPendaftaran();
        }

        private void textBoxNilaiTest_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNilaiTest.Text == "")
            {
                //
            }
            else
            {
                int nilai;
                nilai = Convert.ToInt32(textBoxNilaiTest.Text);
                if (nilai >= 70)
                {
                    textBoxHasil.Text = "LULUS";
                }
                else
                {
                    textBoxHasil.Text = "TIDAK LULUS";
                }
            }
        }



        #endregion


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

        public void DataKeuanganPendaftaran()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  vw_KEUANGAN_PENDAFTARAN ORDER BY TANGGAL_DAFTAR DESC";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewLunasBayar.DataSource = dt;
            koneksi.Close();
        }

        #endregion

        private void PanitiaUjian_Load(object sender, EventArgs e)
        {
            DataNilai();
            DataKeuanganPendaftaran();
        }







    }
}
