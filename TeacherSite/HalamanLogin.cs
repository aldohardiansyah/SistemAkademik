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
    public partial class HalamanLogin : Form
    {
        string db = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\KadudApp\Akademik\Akademik_db.mdb";
        public static string passingText;

        public HalamanLogin()
        {
            InitializeComponent();
        }

        private void button_TSLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection koneksi = new OleDbConnection(db);
            koneksi.Open();
            string query = "";
            query = " SELECT * FROM DATA_GURULOGIN WHERE "
            + "NIP = '" + textBox_TSNIP.Text + "' AND "
            + "PASS = '" + textBox_TSPassGuru.Text + "'";
            OleDbCommand komen = new OleDbCommand();
            komen.CommandText = query;
            komen.Connection = koneksi;
            OleDbDataAdapter da = new OleDbDataAdapter(komen);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                OleDbConnection koneksi_2 = new OleDbConnection(db);
                koneksi_2.Open();
                string query_3 = "";
                query_3 = "SELECT * FROM DATA_WALIKELAS WHERE "
                + "NIP = '" + textBox_TSNIP.Text + "'";
                OleDbCommand komen_2 = new OleDbCommand();
                komen_2.CommandText = query_3;
                komen_2.Connection = koneksi_2;
                OleDbDataAdapter da_2 = new OleDbDataAdapter(komen_2);
                DataTable dt_2 = new DataTable();
                da_2.Fill(dt_2);
                if (dt_2.Rows.Count > 0)
                {
                    passingText = textBox_TSNIP.Text;
                    HalamanTSWali halaman = new HalamanTSWali();
                    halaman.Show();

                    textBox_TSNIP.Clear();
                    textBox_TSPassGuru.Clear();
                    koneksi_2.Close();
                }
                else
                {
                    passingText = textBox_TSNIP.Text;
                    HalamanTSGuru halaman = new HalamanTSGuru();
                    halaman.Show();

                    textBox_TSNIP.Clear();
                    textBox_TSPassGuru.Clear();
                    koneksi_2.Close();
                }
            }

            else
            {
                MessageBox.Show("NIP Guru dan Password salah!");
                textBox_TSNIP.Clear();
                textBox_TSPassGuru.Clear();
            }

            koneksi.Close();
        }


    }
}
