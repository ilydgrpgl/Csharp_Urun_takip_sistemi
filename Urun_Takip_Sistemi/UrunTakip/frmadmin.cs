using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        // Data Source = DESKTOP - TJS301G; Initial Catalog = Dburun; Integrated Security = True
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJS301G;Initial Catalog=Dburun;Integrated Security=True");
        private void Btngirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from TblAdmin where Kullanici=@p1 and Sifre=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", Txtkullaniciad.Text);
            cmd.Parameters.AddWithValue("@p2", Txtsifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) // dr işlemi okuma yapıyorsa,  kullanıcı ad ve sifre dogru ise

            {
                frmyonlendirme frm = new frmyonlendirme();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Kullanıcı adı veya şifre hatalı");
            }
            baglanti.Close();   

        }
    }
}
