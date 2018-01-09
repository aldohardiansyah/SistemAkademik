using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;

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
            comboBoxKelasBaru.Items.Clear();
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
            DataSiswa_2();
            DataSiswa();
            comboBoxKelasBaru.Items.Clear();
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
            koneksi.Close();
        }

        public void DataSiswa_2()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            String query = "SELECT * FROM  MASTER_SISWA WHERE NOT KELAS = 'Belum Ada Kelas' ORDER BY KELAS, NAMA_LENGKAP";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
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
            DataSiswa_2();
        }

        private void button_Cetak_Click(object sender, EventArgs e) //fungsi di button nya copy isinya aja//
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }


        void PrintImage(object o, PrintPageEventArgs e) //fungsi tambahan sendiri copy aja semua//
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void dataGridViewDaftarSiswa_DoubleClick(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            tabControlSiswa.SelectTab(tabPage_KartuSiswa);

            string IDCari = dataGridViewDaftarSiswa.CurrentRow.Cells["NIS"].Value.ToString();

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
                string FOTO = dt.Rows[0]["FOTO_SISWA"].ToString();
                string ALAMAT = dt.Rows[0]["ALAMAT"].ToString();
                string EMAIL = dt.Rows[0]["EMAIL"].ToString();




                textBox_NamaSiswa.Text = NAMA_LENGKAP;
                textBox_NISSiswa.Text = NIS;
                textBox_KelasSiswa.Text = KELAS;
                textBox_AlamatSiswa.Text = ALAMAT;
                textBox_EmailSiswa.Text = EMAIL;
                pictureBox_Siswa.Image = Image.FromFile(FOTO);
                pictureBox_Siswa.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_Siswa.BorderStyle = BorderStyle.Fixed3D;

                #endregion
            }
        }




    }
}
