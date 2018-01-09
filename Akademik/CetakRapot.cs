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
    public partial class CetakRapot : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";


        public CetakRapot()
        {
            InitializeComponent();
        }

        //DATA-DATA ADA DIMARI//
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
                comboBox_DaftarKelas.Items.Add(dt.Rows[i]["KELAS"].ToString());
            }
            koneksi.Close();
        }

        public void DataSemester()
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
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


        private void CetakRapot_Load(object sender, EventArgs e)
        {
            DataKelas();
            DataSemester();
        }

        private void comboBox_DaftarKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query_2 = "SELECT NIS, NAMA_LENGKAP, KELAS FROM MASTER_SISWA WHERE KELAS='" + comboBox_DaftarKelas.Text + "' ORDER BY NAMA_LENGKAP ASC";
            OleDbCommand cmd_2 = new OleDbCommand();
            cmd_2.CommandText = query_2;
            cmd_2.Connection = koneksi;

            OleDbDataAdapter da_2 = new OleDbDataAdapter(cmd_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);
            dataGridView_DaftarSiswa.DataSource = dt_2;
            koneksi.Close();
        }

        private void dataGridView_DaftarSiswa_DoubleClick(object sender, EventArgs e)
        {
            tabControl_CetakRapot.SelectTab(tabPage_CetakRapot);

            string NIS = dataGridView_DaftarSiswa.CurrentRow.Cells["NIS"].Value.ToString();
            string NAMA = dataGridView_DaftarSiswa.CurrentRow.Cells["NAMA_LENGKAP"].Value.ToString();
            string KELAS = dataGridView_DaftarSiswa.CurrentRow.Cells["KELAS"].Value.ToString();
            string TA = label_TA.Text;
            string SEMESTER = label_SMST.Text;

            label_RapotNama.Text = NAMA;
            label_RapotNIS.Text = NIS;
            label_RapotKelas.Text = KELAS;
            label_RapotSMT.Text = SEMESTER;
            label_RapotTHN.Text = TA;

            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "SELECT NAMA_PELAJARAN, NILAI, KETERANGAN FROM vw_DATA_NILAI WHERE NIS = '" + label_RapotNIS.Text + "' AND SEMESTER = '" + label_RapotSMT.Text + "' AND TAHUN_AJARAN = '" + label_RapotTHN.Text+ "' ORDER BY NAMA_PELAJARAN ASC";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = query;
            cmd.Connection = koneksi;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_RapotNilai.DataSource = dt;
            koneksi.Close();
        }

        private void button_Cetak_Click(object sender, EventArgs e)
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


    }
}
