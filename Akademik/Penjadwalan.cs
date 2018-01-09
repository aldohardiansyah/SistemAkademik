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
    public partial class Penjadwalan : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public Penjadwalan()
        {
            InitializeComponent();
        }

        //Data Data Ada Dimari//
        public void DataJam()
        {
            comboBoxJadwalJam.Items.Clear();
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_JAMKBM ORDER BY ID";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxJadwalJam.Items.Add(dt.Rows[i]["ID"].ToString());
            }
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
                comboBoxJadwalKelas.Items.Add(dt.Rows[i]["KELAS"].ToString());
                comboBox_LihatJadwalKelas.Items.Add(dt.Rows[i]["KELAS"].ToString());
            }
            koneksi.Close();
        }

        public void DataJadwal()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_JADWAL ORDER BY KELAS ASC, HARI DESC, JAMKE ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }

        public void DataGuru()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_GURU";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_LihatJadwalGuru.Items.Add(dt.Rows[i]["Nama_Lengkap"].ToString());
            }
        }


        //HALAMAN TAMBAH JADWAL//
        private void comboBoxJadwalHari_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxJadwalJam.Text = "";
            labelJamKe.Text = "";
            comboBoxJadwalJam.Items.Clear();
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM DATA_HARIKBM WHERE HARI = '" + comboBoxJadwalHari.Text + "' ORDER BY JAMKE";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxJadwalJam.Items.Add(dt.Rows[i]["JAMKE"].ToString());
            }
            koneksi.Close();
        }

        private void comboBoxJadwalJam_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_JAMKBM WHERE ID = "+ comboBoxJadwalJam.Text +" ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelJamKe.Text = dt.Rows[i]["JAM"].ToString();
            }
            koneksi.Close();
        }

        private void comboBoxJadwalKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxJadwalMapel.Text = "";
            labelKodeMapel.Text = "";
            comboBoxJadwalMapel.Items.Clear();
            comboBoxJadwalGuru.Items.Clear();
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_KELAS WHERE KELAS = '" + comboBoxJadwalKelas.Text + "' ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelKDJurusan.Text = dt.Rows[i]["KD_JURUSAN"].ToString();
            }

            string query_2 = "SELECT * FROM MASTER_PELAJARAN WHERE JURUSAN = '" + labelKDJurusan.Text + "' OR JURUSAN = 'Umum' ";
            OleDbCommand cmd_2 = new OleDbCommand();
            cmd_2.CommandText = query_2;
            cmd_2.Connection = koneksi;

            OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);

            for (int i = 0; i < dt_2.Rows.Count; i++)
            {
                comboBoxJadwalMapel.Items.Add(dt_2.Rows[i]["NAMA_PELAJARAN"].ToString());
            }

            koneksi.Close();
        }

        private void comboBoxJadwalMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxJadwalGuru.Text = "";
            comboBoxJadwalGuru.Items.Clear();
            comboBoxJadwalGuru.Items.Clear();
            labelKodeGuru.Text = "";
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_PELAJARAN WHERE NAMA_PELAJARAN = '" + comboBoxJadwalMapel.Text + "' ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelKodeMapel.Text = dt.Rows[i]["KD_PELAJARAN"].ToString();
            }

            string query_2 = "SELECT * FROM vw_DATA_GURUPELAJARAN WHERE KD_PELAJARAN = '" + labelKodeMapel.Text + "' ";
            OleDbCommand cmd_2 = new OleDbCommand();
            cmd_2.CommandText = query_2;
            cmd_2.Connection = koneksi;

            OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);

            for (int i = 0; i < dt_2.Rows.Count; i++)
            {
                comboBoxJadwalGuru.Items.Add(dt_2.Rows[i]["NAMA_LENGKAP"].ToString());
            }

            koneksi.Close();

        }

        private void comboBoxJadwalGuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelKodeGuru.Text = "";
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_GURUPELAJARAN WHERE NAMA_LENGKAP = '" + comboBoxJadwalGuru.Text + "' ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelKodeGuru.Text = dt.Rows[i]["NIP"].ToString();
            }
        }

        private void buttonTambahJadwal_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM DATA_JADWAL WHERE HARI = '" + comboBoxJadwalHari.Text + "' AND JAMKE = '" + comboBoxJadwalJam.Text + "' AND NIP = '" + labelKodeGuru.Text + "' AND KD_PELAJARAN = '" + labelKodeMapel.Text + "'";            
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            koneksi.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Jadwal Guru Bentrok");
            }
            else
            {
                OleDbConnection koneksi_ck = new OleDbConnection(db);
                koneksi_ck.Open();
                string query_ck = "SELECT * FROM DATA_JADWAL WHERE HARI = '" + comboBoxJadwalHari.Text + "' AND JAMKE = '" + comboBoxJadwalJam.Text + "' AND KELAS = '" + comboBoxJadwalKelas.Text + "' ";
                OleDbCommand komen_ck = new OleDbCommand();
                komen_ck.CommandText = query_ck;
                komen_ck.Connection = koneksi;
                OleDbDataAdapter da_ck = new OleDbDataAdapter(komen_ck);
                DataTable dt_ck = new DataTable();
                da_ck.Fill(dt_ck);
                koneksi_ck.Close();
                if (dt_ck.Rows.Count > 0)
                {
                    OleDbConnection koneksi_2 = new OleDbConnection(db);
                    koneksi_2.Open();
                    string query_2 = "";
                    query_2 = "UPDATE DATA_JADWAL SET HARI = '" + comboBoxJadwalHari.Text + "', KELAS = '" + comboBoxJadwalKelas.Text + "', NIP = '" + labelKodeGuru.Text + "',  JAMKE = '" + comboBoxJadwalJam.Text + "', KD_PELAJARAN = '" + labelKodeMapel.Text + "' WHERE HARI = '" + comboBoxJadwalHari.Text + "' AND JAMKE = '" + comboBoxJadwalJam.Text + "' AND KELAS = '" + comboBoxJadwalKelas.Text + "' ";
                    OleDbCommand komen_2 = new OleDbCommand();
                    komen_2.CommandText = query_2;
                    komen_2.Connection = koneksi_2;
                    komen_2.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil DIRUBAH");
                    koneksi_2.Close();
                }
                else
                {
                    OleDbConnection koneksi_3 = new OleDbConnection(db);
                    koneksi_3.Open();
                    string query_3 = "";
                    query_3 = "INSERT INTO DATA_JADWAL (HARI, KELAS, JAMKE, NIP, KD_PELAJARAN) VALUES ('" + comboBoxJadwalHari.Text.Replace("'", "''") + "', '" + comboBoxJadwalKelas.Text.Replace("'", "''") + "', '" + comboBoxJadwalJam.Text.Replace("'", "''") + "', '" + labelKodeGuru.Text.Replace("'", "''") + "', '" + labelKodeMapel.Text.Replace("'", "''") + "')";
                    OleDbCommand komen_3 = new OleDbCommand();
                    komen_3.CommandText = query_3;
                    komen_3.Connection = koneksi_3;
                    komen_3.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil DISIMPAN");
                    koneksi_3.Close();
                }
            }
            
        }


        //HALAMAN LIHAT DATA//
        private void button_SemuaData_Click(object sender, EventArgs e)
        {
            comboBox_LihatJadwalHari.Text = "";
            comboBox_LihatJadwalKelas.Text = "";
            comboBox_LihatJadwalGuru.Text = "";
            DataJadwal();
        }

        private void comboBox_LihatJadwalHari_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_LihatJadwalKelas.Text = "";
            comboBox_LihatJadwalGuru.Text = "";
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_JADWAL WHERE HARI = '" + comboBox_LihatJadwalHari.Text + "' ORDER BY KELAS ASC, HARI DESC, JAMKE ASC ";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }
        private void comboBox_LihatJadwalKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_LihatJadwalHari.Text = "";
            comboBox_LihatJadwalGuru.Text = "";
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_JADWAL WHERE KELAS = '" + comboBox_LihatJadwalKelas.Text + "' ORDER BY HARI DESC, JAMKE ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }
        private void comboBox_LihatJadwalGuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_LihatJadwalHari.Text = "";
            comboBox_LihatJadwalKelas.Text = "";
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_JADWAL WHERE Nama_Lengkap = '" + comboBox_LihatJadwalGuru.Text + "' ORDER BY KELAS ASC, HARI DESC, JAMKE ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }


 


        private void Penjadwalan_Load(object sender, EventArgs e)
        {
            DataJam();
            DataKelas();
            DataJadwal();
            DataGuru();
        }


        


    }
}
