using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TeacherSite
{
    public partial class HalamanTSGuru : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";

        public HalamanTSGuru()
        {
            InitializeComponent();
            
        }


        //HALAMAN GURU - JADWAL //
        private void button_SemuaData_Click(object sender, EventArgs e)
        {
            DataJadwal();
        }

        private void button_CariHari_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT HARI, JAMKE, Jam, KELAS, NAMA_PELAJARAN, Nama_Lengkap FROM vw_DATA_JADWAL WHERE NIP = '" + labelNIP.Text + "' AND HARI='" + comboBox_LihatJadwalHari.Text + "' ORDER BY KELAS ASC, HARI DESC, JAMKE ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }

        private void button_CariKelas_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT HARI, JAMKE, Jam, KELAS, NAMA_PELAJARAN, Nama_Lengkap FROM vw_DATA_JADWAL WHERE NIP = '" + labelNIP.Text + "' AND KELAS='" + comboBox_LihatJadwalKelas.Text + "' ORDER BY KELAS ASC, HARI DESC, JAMKE ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }
        



        //DATA-DATA//
        public void DataJadwal()
        {
            labelNIP.Text = HalamanLogin.passingText;
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT HARI, JAMKE, Jam, KELAS, NAMA_PELAJARAN, Nama_Lengkap FROM vw_DATA_JADWAL WHERE NIP = '" + labelNIP.Text + "' ORDER BY KELAS ASC, HARI DESC, JAMKE ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewJadwal.DataSource = dt;
            koneksi.Close();
        }

        public void DataKelas()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT KELAS FROM vw_DATA_JADWAL WHERE NIP = '" + labelNIP.Text + "' GROUP BY KELAS";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_LihatJadwalKelas.Items.Add(dt.Rows[i]["KELAS"].ToString());
                comboBox_InputNilaiKelas.Items.Add(dt.Rows[i]["KELAS"].ToString());
                comboBox_KelasDataNilaiSiswa.Items.Add(dt.Rows[i]["KELAS"].ToString());
            }
            koneksi.Close();
        }


        private void HalamanTSGuru_Load(object sender, EventArgs e)
        {
            DataJadwal();
            DataKelas();
            labelNIP.Text = HalamanLogin.passingText;
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM MASTER_GURU WHERE NIP='" + labelNIP.Text + "'";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                labelNama.Text = dt.Rows[i]["Nama_Lengkap"].ToString();
            }

            string query_2 = "SELECT * FROM MASTER_TAHUNAJARAN WHERE AKTIF='1'";
            OleDbCommand cmd_2 = new OleDbCommand();
            cmd_2.CommandText = query_2;
            cmd_2.Connection = koneksi;

            OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);

            for (int i = 0; i < dt_2.Rows.Count; i++)
            {
                label_TA.Text = dt_2.Rows[i]["TAHUN"].ToString();
                label_SMST.Text = dt_2.Rows[i]["SEMESTER"].ToString();
            }

            koneksi.Close();
        }

        private void button_InputNilaiDataSiswa_Click(object sender, EventArgs e)
        {
            if(comboBox_InputNilaiKelas.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Pilih dulu Kelas nya gan");
            }
            else
            {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT NIS, NAMA_LENGKAP, KELAS FROM MASTER_SISWA WHERE KELAS='" + comboBox_InputNilaiKelas.Text + "' ORDER BY NAMA_LENGKAP ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_InputNilai_Jadwal.DataSource = dt;
            koneksi.Close();
            }
        }

        private void comboBox_InputNilaiKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_InputNilaiMapel.Items.Clear();
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();

            string query = "SELECT NAMA_PELAJARAN FROM vw_DATA_JADWAL WHERE NIP = '" + labelNIP.Text + "' AND KELAS = '" + comboBox_InputNilaiKelas.Text + "' GROUP BY NAMA_PELAJARAN";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox_InputNilaiMapel.Items.Add(dt.Rows[i]["NAMA_PELAJARAN"].ToString());
            }

            string query_2 = "SELECT NIS, NAMA_LENGKAP, KELAS FROM MASTER_SISWA WHERE KELAS='" + comboBox_InputNilaiKelas.Text + "' ORDER BY NAMA_LENGKAP ASC";
            OleDbCommand cmd_2 = new OleDbCommand();
            cmd_2.CommandText = query_2;
            cmd_2.Connection = koneksi;

            OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);
            dataGridView_InputNilai_Jadwal.DataSource = dt_2;
            koneksi.Close();
        }

        private void dataGridView_InputNilai_Jadwal_DoubleClick(object sender, EventArgs e)
        {
            if (comboBox_InputNilaiMapel.Text == "")
            {
                MessageBox.Show("Pilih Dulu Mata Pelajarannya");
            }
            else
            {
                tabControl_InputNilai.SelectTab(tabPage_Input);

                string NIS = dataGridView_InputNilai_Jadwal.CurrentRow.Cells["NIS"].Value.ToString();
                string NAMA = dataGridView_InputNilai_Jadwal.CurrentRow.Cells["NAMA_LENGKAP"].Value.ToString();
                string KELAS = dataGridView_InputNilai_Jadwal.CurrentRow.Cells["KELAS"].Value.ToString();
                string MAPEL = comboBox_InputNilaiMapel.Text;
                string TA = label_TA.Text;
                string SEMESTER = label_SMST.Text;

                textBox_InputNama.Text = NAMA;
                textBox_InputNIS.Text = NIS;
                textBox_InputKelas.Text = KELAS;
                textBox_InputMapel.Text = MAPEL;
                textBox_InputSemester.Text = SEMESTER;
                textBox_InputTA.Text = TA;

                OleDbConnection koneksi = new OleDbConnection(db);
                koneksi.Open();
                #region FOTOSISWA
                string query = "";
                query = "SELECT * FROM MASTER_SISWA WHERE NIS = '" + NIS + "'";
                OleDbCommand komen = new OleDbCommand();
                komen.CommandText = query;
                komen.Connection = koneksi;
                OleDbDataAdapter da = new OleDbDataAdapter(komen);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string FOTO = dt.Rows[0]["FOTO_SISWA"].ToString();

                    pictureBox_siswa.Image = Image.FromFile(FOTO);
                    pictureBox_siswa.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_siswa.BorderStyle = BorderStyle.Fixed3D;
                }
                #endregion

                string query_2 = "";
                query_2 = "SELECT * FROM MASTER_PELAJARAN WHERE NAMA_PELAJARAN = '" + comboBox_InputNilaiMapel.Text + "'";
                OleDbCommand komen_2 = new OleDbCommand();
                komen_2.CommandText = query_2;
                komen_2.Connection = koneksi;
                OleDbDataAdapter da_2 = new OleDbDataAdapter(komen_2);
                DataTable dt_2 = new DataTable();
                da_2.Fill(dt_2);
                if (dt_2.Rows.Count > 0)
                {
                    string KD_PELAJARAN = dt_2.Rows[0]["KD_PELAJARAN"].ToString();
                    textBox_InputKDMAPEL.Text = KD_PELAJARAN;
                }

                koneksi.Close(); dt = null;
            }
        }

        private void button_SimpanNilai_Click(object sender, EventArgs e)
        {
            #region WarningDataKosong
            if (textBoxUh1.Text == "")
            {
                MessageBox.Show("Data Nilai Ulangan Harian 1 masih kosong");
            }
            else if (textBoxUh2.Text == "")
            {
                MessageBox.Show("Data Nilai Ulangan Harian 2 masih kosong");
            }
            else if (textBoxTugas1.Text == "")
            {
                MessageBox.Show("Data Nilai Tugas 1 masih kosong");
            }
            else if (textBoxTugas2.Text == "")
            {
                MessageBox.Show("Data Nilai Tugas 2 masih kosong");
            }
            else if (textBoxPerilaku.Text == "")
            {
                MessageBox.Show("Data Nilai Perilaku masih kosong");
            }
            else if (textBoxKehadiran.Text == "")
            {
                MessageBox.Show("Data Nilai Kehadiran masih kosong");
            }
            else if (textBoxUts.Text == "")
            {
                MessageBox.Show("Data Nilai UTS masih kosong");
            }
            else if (textBoxUas.Text == "")
            {
                MessageBox.Show("Data Nilai UAS masih kosong");
            }
            else
            {
            #endregion

                #region WarningDataLebih100
                if (int.Parse(textBoxUh1.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxUh2.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxTugas1.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxTugas2.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxPerilaku.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxKehadiran.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxUts.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else if (int.Parse(textBoxUas.Text) > 100)
                {
                    MessageBox.Show("Data Nilai tidak boleh lebih dari 100");
                }
                else
                {
                #endregion
                    int uh1 = int.Parse(textBoxUh1.Text);
                    int uh2 = int.Parse(textBoxUh2.Text);
                    int tugas1 = int.Parse(textBoxTugas1.Text);
                    int tugas2 = int.Parse(textBoxTugas2.Text);
                    int perilaku = int.Parse(textBoxPerilaku.Text);
                    int kehadiran = int.Parse(textBoxKehadiran.Text);
                    int uts = int.Parse(textBoxUts.Text);
                    int uas = int.Parse(textBoxUas.Text);

                    int total = (((uh1 + uh2) / 2) * 60 / 100) + (((tugas1 + tugas2) / 2) * 5 / 100) + (perilaku * 5 / 100) + (kehadiran * 10 / 100) + (uts * 10 / 100) + (uas * 10 / 100);
                    textBoxTotal.Text = total.ToString();
                    if (int.Parse(textBoxTotal.Text) >= 70)
                    {
                        textBoxKet.Text = "TERLAMPAUI";

                        OleDbConnection connect = new OleDbConnection(db);
                        connect.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connect;

                        string queryCari = "";
                        queryCari = "SELECT * FROM DATA_NILAI WHERE "
                        + "NIS = '" + textBox_InputNIS.Text + "' AND "
                        + "KD_PELAJARAN = '" + textBox_InputKDMAPEL.Text + "' AND "
                        + "SEMESTER = '" + textBox_InputSemester.Text + "' AND "
                        + "TAHUN_AJARAN = '" + textBox_InputTA.Text + "' ";
                        command.CommandText = queryCari;
                        OleDbDataAdapter da = new OleDbDataAdapter(command);
                        DataTable dt = new DataTable(queryCari);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Data Sudah Ada");
                        }

                        else
                        {
                            string query = "";
                            query = ("INSERT INTO DATA_NILAI ("
                            + "NIS, "
                            + "KD_PELAJARAN, "
                            + "NILAI, "
                            + "KETERANGAN, "
                            + "SEMESTER, "
                            + "TAHUN_AJARAN) VALUES ('"

                            + textBox_InputNIS.Text + "', '"
                            + textBox_InputKDMAPEL.Text + "', '"
                            + textBoxTotal.Text + "', '"
                            + textBoxKet.Text + "', '"
                            + textBox_InputSemester.Text + "', '"
                            + textBox_InputTA.Text + "')");

                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = query;
                            cmd.Connection = connect;

                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Data Tersimpan");
                        }
                        //DataNilaiSiswa();
                    }
                    else
                    {
                        textBoxKet.Text = "BELUM TERLAMPAUI";
                    }
                }
            }
        }

        private void comboBox_KelasDataNilaiSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_DataNilaiSiswaMapel.Items.Clear();
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_NILAI WHERE KELAS = '" + comboBox_KelasDataNilaiSiswa.Text + "' ORDER BY NAMA_LENGKAP ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_DataNilaiSiswa.DataSource = dt;

            string query_2 = "SELECT NAMA_PELAJARAN FROM vw_DATA_JADWAL WHERE NIP = '" + labelNIP.Text + "' AND KELAS = '" + comboBox_KelasDataNilaiSiswa.Text + "' GROUP BY NAMA_PELAJARAN";
            OleDbCommand cmd_2 = new OleDbCommand();
            cmd_2.CommandText = query_2;
            cmd_2.Connection = koneksi;

            OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);

            for (int i = 0; i < dt_2.Rows.Count; i++)
            {
                comboBox_DataNilaiSiswaMapel.Items.Add(dt_2.Rows[i]["NAMA_PELAJARAN"].ToString());
            }

            koneksi.Close();
        }

        private void comboBox_DataNilaiSiswaMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT * FROM vw_DATA_NILAI WHERE KELAS = '" + comboBox_KelasDataNilaiSiswa.Text + "' AND NAMA_PELAJARAN = '" + comboBox_DataNilaiSiswaMapel.Text + "' ORDER BY NAMA_LENGKAP ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_DataNilaiSiswa.DataSource = dt;
            koneksi.Close();
        }




    }
}
