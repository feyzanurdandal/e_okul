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
using Hastane_Yonetim_Randevu_Sistemi;

namespace E_Okul
{
    public partial class Hoşgeldiniz : Form
    {
        public Hoşgeldiniz()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Feyza;Initial Catalog=e_okul;Integrated Security=True"); //sql tablosu ile bağlantımızı kurduk
        public string numara_ogrt;
        private void frm_ogretmen_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OGRTADSOYAD from tbl_ogretmenler where OGRTID=@P1", baglanti); //öğretmen ad soyad çekmek için yeni bir sql sorgusu yazdık
            komut.Parameters.AddWithValue("@P1", numara_ogrt); //p1 parametresini numara değişkeninden aldık çünkü ogrt id ile birbirlerine bağlılar
            baglanti.Open(); //bağlantıyı açtık data reader kullanabilmek için
            SqlDataReader dr = komut.ExecuteReader(); //sql data reader ile sorguyu çalıştırdık 
            while (dr.Read()) //veri okuma işlemi
            {
                this.Text = dr[0].ToString(); //formun başlığını öğretmen adı soyadı olarak ayarladık
            }
            baglanti.Close(); //bağlantıyı kapattık
        }

        private void btn_kulup_Click(object sender, EventArgs e)
        {
            FrmKulup frm = new FrmKulup();
            frm.Show();
        }

        private void btn_ders_Click(object sender, EventArgs e)
        {
            frm_dersler frm = new frm_dersler();
            frm.Show();
        }

        private void btn_ogr_islemler_Click(object sender, EventArgs e)
        {
            frm_ogrenci frm = new frm_ogrenci();
            frm.Show();
        }

        private void btn_sınavnotlar_Click(object sender, EventArgs e)
        {
            frm_sinav_notlar frm = new frm_sinav_notlar();
            frm.Show();
        }
    }
}
