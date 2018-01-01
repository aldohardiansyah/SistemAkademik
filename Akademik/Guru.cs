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
    public partial class Guru : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public Guru()
        {
            InitializeComponent();
        }

        //HALAMAN Pembagian Mapel//
        private void dataGridViewDataGuru_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlGuru.SelectTab(tab_PembagianMataPelajaran);

            string IDCari = dataGridViewDataGuru.CurrentRow.Cells["ID"].Value.ToString();

            string query = "";
            query = "SELECT * FROM MASTER_GURU WHERE ID = " + IDCari + "";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable(); ;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                #region AmbilDataDariTabel
                string NAMA_LENGKAP = dt.Rows[0]["NAMA_LENGKAP"].ToString();
                string ID = dt.Rows[0]["ID"].ToString();
                string TGL_DAFTAR = Convert.ToDateTime(dt.Rows[0]["TGL_DAFTAR"]).ToString("yyyy");


                textBoxNamaGuru.Text = NAMA_LENGKAP;
                textBoxID.Text = ID;
                string nodaftar;
                int id = 0;
                Int32.TryParse(textBoxID.Text, out id);
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
                textBoxNIP.Text = TGL_DAFTAR + nodaftar;

                #endregion
            }
            koneksi.Close(); dt = null;
        }

        private void buttonKonfirm_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM DATA_GURUPELAJARAN WHERE NIP = '" + textBoxNIP.Text + "' AND KD_PELAJARAN =  '" + textBoxMapel.Text + "' ";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Data Udah Ada Gan Gabisa Dimasukin Lagi");
            }
            else
            {
                OleDbConnection koneksi_3 = new OleDbConnection(db);
                koneksi_3.Open();
                string query_2 = "";
                string query_3 = "";
                query_2 = "INSERT INTO DATA_GURUPELAJARAN (NIP, KD_PELAJARAN) VALUES ('"
                        + textBoxNIP.Text.Replace("'", "''") + "', '" //namaguru
                        + textBoxMapel.Text + "')"; //kodemapel
                query_3 = "UPDATE MASTER_GURU SET NIP = '"+textBoxNIP.Text +"' WHERE ID ="+textBoxID.Text+"";

                OleDbCommand komen_2 = new OleDbCommand();
                komen_2.CommandText = query_2;
                komen_2.Connection = koneksi_3;
                komen_2.ExecuteNonQuery();
                OleDbCommand komen_3 = new OleDbCommand();
                komen_3.CommandText = query_3;
                komen_3.Connection = koneksi_3;
                komen_3.ExecuteNonQuery();
                koneksi_3.Close();
                MessageBox.Show("Data Berhasil Disimpan");
                DataMapelGuru();
            }
            koneksi.Close();
        }

        private void comboBoxMataPelajaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(db);
            con.Open();
            string query = "SELECT * FROM MASTER_PELAJARAN WHERE NAMA_PELAJARAN = '" + comboBoxMataPelajaran.Text + "' ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textBoxMapel.Text = dt.Rows[0]["KD_PELAJARAN"].ToString();
            }
            con.Close();
        }



        //HALAMAN Setting Teacher Site//
        private void dataGridViewMapelGuru_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlGuru.SelectTab(Tab_PageTeachSite);

            string IDCari = dataGridViewMapelGuru.CurrentRow.Cells["NIP"].Value.ToString();

            string query = "";
            query = "SELECT * FROM MASTER_GURU WHERE NIP = '" + IDCari + "'";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable(); ;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                #region AmbilDataDariTabel
                string NAMA_LENGKAP = dt.Rows[0]["NAMA_LENGKAP"].ToString();
                string NIP = dt.Rows[0]["NIP"].ToString();


                textBoxNamaGuru_2.Text = NAMA_LENGKAP;
                textBoxNIPGuru_2.Text = NIP;
                #endregion
            }
            koneksi.Close(); dt = null;
        }

        private void buttonKonfirmTsite_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM DATA_GURULOGIN WHERE NIP = '" + textBoxNIPGuru_2.Text + "' ";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            koneksi.Close();
            if (dt.Rows.Count > 0)
            {
                OleDbConnection koneksi_2 = new OleDbConnection(db);
                koneksi_2.Open();
                string query_2 = "";
                query_2 = "UPDATE DATA_GURULOGIN SET PASS = '" + textBoxPassGuru.Text + "' WHERE NIP = '"+ textBoxNIPGuru_2.Text + "' ";
                OleDbCommand komen_2 = new OleDbCommand();
                komen_2.CommandText = query_2;
                komen_2.Connection = koneksi_2;
                komen_2.ExecuteNonQuery();
                MessageBox.Show("Password Berhasil Dirubah");
                koneksi_2.Close();
            }
            else
            {
                OleDbConnection koneksi_3 = new OleDbConnection(db);
                koneksi_3.Open();
                string query_3 = "";
                query_3 = "INSERT INTO DATA_GURULOGIN (NIP, PASS) VALUES ('" + textBoxNIPGuru_2.Text.Replace("'", "''") + "', '" + textBoxPassGuru.Text.Replace("'", "''") + "')";
                OleDbCommand komen_3 = new OleDbCommand();
                komen_3.CommandText = query_3;
                komen_3.Connection = koneksi_3;
                komen_3.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                koneksi_3.Close();
            }
        }


        //HALAMAN Wali Kelas //
        private void dataGridViewMapelGuru_2_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlGuru.SelectTab(Tab_PembagianWali);

            string IDCari = dataGridViewMapelGuru_2.CurrentRow.Cells["NIP"].Value.ToString();

            string query = "";
            query = "SELECT * FROM MASTER_GURU WHERE NIP = '" + IDCari + "'";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable(); ;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                #region AmbilDataDariTabel
                string NAMA_LENGKAP = dt.Rows[0]["NAMA_LENGKAP"].ToString();
                string NIP = dt.Rows[0]["NIP"].ToString();


                textBoxNamaWali.Text = NAMA_LENGKAP;
                textBoxNIPWali.Text = NIP;
                #endregion
            }
            koneksi.Close(); dt = null;
        }

        private void buttonKonfirmWali_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM DATA_WALIKELAS WHERE NIP = '" + textBoxNIPWali.Text + "' ";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            koneksi.Close();
            if (dt.Rows.Count > 0)
            {
                OleDbConnection koneksi_2 = new OleDbConnection(db);
                koneksi_2.Open();
                string query_2 = "";
                query_2 = "UPDATE DATA_WALIKELAS SET KELAS = '" + comboBoxDaftarKelas.Text + "' WHERE NIP = '" + textBoxNIPWali.Text + "' ";
                OleDbCommand komen_2 = new OleDbCommand();
                komen_2.CommandText = query_2;
                komen_2.Connection = koneksi_2;
                komen_2.ExecuteNonQuery();
                MessageBox.Show("Password Berhasil Dirubah");
                koneksi_2.Close();
                DataWali();
            }
            else
            {
                OleDbConnection koneksi_3 = new OleDbConnection(db);
                koneksi_3.Open();
                string query_3 = "";
                query_3 = "INSERT INTO DATA_WALIKELAS (NIP, KELAS) VALUES ('" + textBoxNIPWali.Text.Replace("'", "''") + "', '" + comboBoxDaftarKelas.Text.Replace("'", "''") + "')";
                OleDbCommand komen_3 = new OleDbCommand();
                komen_3.CommandText = query_3;
                komen_3.Connection = koneksi_3;
                komen_3.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                koneksi_3.Close();
                DataWali();
            }
        }


        //Data-Data Ada Dimari//
        public void DataGuru()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_GURU ORDER BY Nama_Lengkap";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDataGuru.DataSource = dt;
            koneksi.Close();
        }

        public void DataMapelGuru()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_GURUPELAJARAN ORDER BY Nama_Lengkap";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMapelGuru.DataSource = dt;
            dataGridViewMapelGuru_2.DataSource = dt;
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
                comboBoxDaftarKelas.Items.Add(dt.Rows[i]["KELAS"].ToString());
            }
            koneksi.Close();
        }

        public void DataPelajaran()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_PELAJARAN";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxMataPelajaran.Items.Add(dt.Rows[i]["NAMA_PELAJARAN"].ToString());
            }
            koneksi.Close();
        }

        public void DataWali()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_WALIKELAS ORDER BY KELAS";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewWaliKelas.DataSource = dt;
            koneksi.Close();
        }



        private void Guru_Load(object sender, EventArgs e)
        {
            DataGuru();
            DataKelas();
            DataPelajaran();
            DataMapelGuru();
            DataWali();
        }

        private void buttonTampilSemuaData_Click(object sender, EventArgs e)
        {
            DataGuru();
        }


    }
}
