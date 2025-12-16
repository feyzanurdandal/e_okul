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
using System.Data.SqlClient;

namespace E_Okul
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Feyza;Initial Catalog=e_okul;Integrated Security=True"); //sql tablosu ile bağlantımızı kurduk
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from kulup_bilgi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kulup_bilgi (KULUPAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kulüp listeye eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //e parametresi datagrid in hücre görünümlerinin olayları üzerine çalışıyor e-> event
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            //txt id nin text i eşittir datagridin satırları içerisindeki yni seçmiş
            //olduğumuz satırdaki e deki yani seçmiş olduğumuz olayın olduğu satırın indeksini aldık
            //bu indeksteki hücreler içerisindeki sıfırıncı hücrenin değerini yazdırıyoruz 0. hücreyi seçtik çünkü kulüp id burada sql tablosunda
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kulup_bilgi where KULUPID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txt_id.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kulüp silindi");
            liste();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kulup_bilgi set KULUPAD=@p1 where KULUPID=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut.Parameters.AddWithValue("@p2",txt_id.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kulüp güncellendi");
            liste();
        }
    }
}
