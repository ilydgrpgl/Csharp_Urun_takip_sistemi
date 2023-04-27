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
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TJS301G;Initial Catalog=Dburun;Integrated Security=True");
        private void Btnlistele_Click(object sender, EventArgs e)
        {
            SqlCommand cmd= new SqlCommand("SELECT UrunID,UrunAd,Stok,Alisfiyat,Satisfiyat,Ad,Kategori from Tblurunler  Inner join Tblkategori ON Tblurunler.Kategori=Tblkategori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource   = dt;
            dataGridView1.Columns["Kategori"].Visible= false;
        }

        private void frmurun_Load(object sender, EventArgs e)
        {

            SqlCommand cmd2 = new SqlCommand("select * from Tblkategori",baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            Cmbkategori.DisplayMember = "AD"; // KULANICYA GÖZÜKECEK OLAN KISIM
            Cmbkategori.ValueMember = "ID";// ARKA PLANDA ÇALIŞACAK KISIM örnegin bilgisayarlar kategorisisini seçtiğimizde bize arka planda ıd değerini dödürecek ilişkiden dolayı
            Cmbkategori.DataSource = dt2;
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("insert into Tblurunler(UrunAd,Stok,Alisfiyat,Satisfiyat,Kategori ) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            cmd3.Parameters.AddWithValue("@p1", Txtad.Text);
            cmd3.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            cmd3.Parameters.AddWithValue("@p3", Txtalis.Text);
            cmd3.Parameters.AddWithValue("@p4", Txtsatis.Text);
            cmd3.Parameters.AddWithValue("@p5", Cmbkategori.SelectedValue);

            cmd3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ürün kaydı başarili şekilde gerçekleşti.");
            
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("delete from Tblurunler where UrunID=@p1", baglanti);
            cmd4.Parameters.AddWithValue("@p1",Txtıd.Text);
            cmd4.ExecuteNonQuery();// değişiklikleri kaydet
            baglanti.Close();
            MessageBox.Show("ürün silme işlemi başarili şekilde gerçekleşti.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();// cells 0 yani= 0. hücre 1. sütun oluyor
            Txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//e.rowindex tıkladığımız satırın index numarasını al 
            numericUpDown1.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            Txtalis.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           Txtsatis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); 
           Cmbkategori.SelectedValue= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); // kategoriyi listeleye ekleyip yerini değiştirdik.kategoriyi int olarak tutyorduk sonra text oldu olmaz
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("update Tblurunler set UrunAd=@p1,Stok=@p2,Alisfiyat=@p3,Satisfiyat=@p4,Kategori=@p5 where UrunID=@p6",baglanti);
            cmd5.Parameters.AddWithValue("@p1",Txtad.Text);
            cmd5.Parameters.AddWithValue("@p2",numericUpDown1.Value);
            cmd5.Parameters.AddWithValue("@p3",decimal.Parse(Txtalis.Text));
            cmd5.Parameters.AddWithValue("@p4",decimal.Parse(Txtsatis.Text));
            cmd5.Parameters.AddWithValue("@p5",Cmbkategori.SelectedValue);
            cmd5.Parameters.AddWithValue("@p6",Txtıd.Text);
            cmd5.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("ürün billgileri basariyla guncellendi");
        }
    }
}
