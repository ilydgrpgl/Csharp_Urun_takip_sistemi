using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class frmyonlendirme : Form
    {
        public frmyonlendirme()
        {
            InitializeComponent();
        }

        private void Pnl_Click(object sender, EventArgs e)
        {
            frmurun frmurun = new frmurun();
            frmurun.Show();
            this.Hide();
        }

       

        private void panel1_Click(object sender, EventArgs e)
        {
            frmkategori frmkategori = new frmkategori();
            frmkategori.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmİstatistik frm= new frmİstatistik(); 
            frm.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmadmin frmadmin = new frmadmin();
            frmadmin.Show();
            this.Hide();
        }
    }
}
