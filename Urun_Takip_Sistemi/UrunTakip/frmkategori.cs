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
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJS301G;Initial Catalog=Dburun;Integrated Security=True");
        private void Btnlistele_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select * from Tblkategori" ,baglanti);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); // veri tablosunu köprüden gelen değerlerle doldur.. KÖĞRÜDEKİ DEĞERDE CMD YANI YAZDIĞIMIZ KOMUTTAN GELİYOR.
            dataGridView1.DataSource = dt;
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("insert into Tblkategori (AD)  values(@p1)", baglanti); // kullanıcıdan aldığımız için @ sembolü
            cmd2.Parameters.AddWithValue("@p1", Txtad.Text);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kategoriniz basarili bir sekilde eklendi");
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("delete from Tblkategori where ID=@p1", baglanti);
            cmd3.Parameters.AddWithValue("@p1", TxtID.Text);
            cmd3.ExecuteNonQuery();
           baglanti.Close();
            MessageBox.Show("kategoriniz basarili bir sekilde silindi");

        }

        private void Btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
         
            SqlCommand cmd4 = new SqlCommand("update Tblkategori set AD=@p1 where ID=@p2", baglanti);
            cmd4.Parameters.AddWithValue("@p1",Txtad.Text);
            cmd4.Parameters.AddWithValue("@p2",TxtID.Text);
            cmd4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kategoriniz basarili bir sekilde güncelledni");


        }

        private void Btnara_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select *from Tblkategori where AD=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", Txtad.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); 
            dataGridView1.DataSource = dt;
        }
    }
}
