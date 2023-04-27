using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UrunTakip
{
    public partial class frmİstatistik : Form
    {
        public frmİstatistik()
        {
            InitializeComponent();
        }
        // Data Source = DESKTOP - TJS301G; Initial Catalog = Dburun; Integrated Security = True
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJS301G;Initial Catalog=Dburun;Integrated Security=True");
        private void frnİstatistik_Load(object sender, EventArgs e)
        {
            // Toplam kategori sayısı
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select count(*) from Tblkategori", baglanti);
            SqlDataReader dr = cmd1.ExecuteReader();// yeni bir komut.bu sefer labele yazdırdığımız için.
            while (dr.Read())
            {
                Lbltoplamkategori.Text = dr[0].ToString();
            }
            baglanti.Close();

            //Toplam urun sayisi
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select count(*) from Tblurunler", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Lbltoplamurunsayisi.Text = dr2[0].ToString();
            }
            baglanti.Close();
            // toplam beyaz eşya sayısı
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select count(*) from Tblurunler where Kategori=(select ID from Tblkategori where AD='Beyaz eşya')", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                Lblbeyazesyasayisi.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // toplam KUCUK EV ALETLERİ sayısı
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select count(*) from Tblurunler where Kategori=(select ID from Tblkategori where AD='Küçük ev aletleri')", baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                Lblkucukevaletlerisayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();
            // Em yüksek stoklu ürün
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select * from Tblurunler where Stok=(select MAX(Stok) from Tblurunler)", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                Lblenyuksekstok.Text = dr5[1].ToString();
            }
            baglanti.Close();
            // Em dusuk stoklu ürün
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select * from Tblurunler where Stok=(select MIN(Stok) from Tblurunler)", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                Lblendusukstok.Text = dr6[1].ToString();
            }
            baglanti.Close();
            
        }
    }
}
