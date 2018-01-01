using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Akademik
{
    public partial class HalamanUtama : Form
    {
        

        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void MASTER_Click(object sender, EventArgs e)
        {
            MASTER page = new MASTER();
            page.MdiParent = this;
            page.Show();
        }

        private void MASTER_SISWA_Click(object sender, EventArgs e)
        {
            Siswa page = new Siswa();
            page.MdiParent = this;
            page.Show();
        }

        private void MASTER_GURU_Click(object sender, EventArgs e)
        {
            Guru page = new Guru();
            page.MdiParent = this;
            page.Show();
        }

        private void PSB_PENDAFTARAN_Click(object sender, EventArgs e)
        {
            PSB page = new PSB();
            page.MdiParent = this;
            page.Show();
        }

        private void PSB_PANITIAUJIAN_Click(object sender, EventArgs e)
        {
            PanitiaUjian page = new PanitiaUjian();
            page.MdiParent = this;
            page.Show();
        }

        private void KEUANGAN_SISWABARU_Click(object sender, EventArgs e)
        {
            Keuangan page = new Keuangan();
            page.MdiParent = this;
            page.Show();
        }

        private void PENJADWALAN_Click(object sender, EventArgs e)
        {
            Penjadwalan page = new Penjadwalan();
            page.MdiParent = this;
            page.Show();
        }




        
    }
}
