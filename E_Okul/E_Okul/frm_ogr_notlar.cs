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

namespace E_Okul
{
    public partial class frm_ogr_notlar : Form
    {
        public frm_ogr_notlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Feyza;Initial Catalog=e_okul;Integrated Security=True"); //sql tablosu ile bağlantımızı kurduk
        public string numara; //öğrenci numarasını parametre olarak alıcaz textboxtan kuren kullanıcaz
        private void frm_ogr_notlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select DERSAD,SINAV1,SINAV2,PROJE,ORTALAMA,DURUM from tbl_notlar inner join tbl_dersler on tbl_notlar.DERSID=tbl_dersler.DERSID where OGRID=@P1", baglanti); //sql sorgumuzu yazdık notlar tablosu ile dersler tablosunu dersid üzerinden birleştirip öğrenci id sine göre filtreledik inner join birleştirmeye yarıyor idler üzerinden birleştirdi
            komut.Parameters.AddWithValue("@P1", numara); //sorguyu yazarken komut nesnesiyle yazmıştık bu sorgu p1 parametresini alıcak bunu da numara değişkeninden alacak
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut); //sql sorgusunu çalıştırmak için sql data adapter nesnesi oluşturduk
            DataTable dt = new DataTable(); //verileri geçici olarak tutmak için datatable nesnesi oluşturduk
            da.Fill(dt); //data adapter ile datatable ı doldurduk
            dataGridView1.DataSource = dt; //datagridview in veri kaynağını datatable olarak ayarladık

            SqlCommand komut2 = new SqlCommand("select OGRAD,OGRSOYAD from ogr_bilgi where OGRID=@P1", baglanti); //öğrenci ad soyad çekmek için yeni bir sql sorgusu yazdık
            komut2.Parameters.AddWithValue("@P1", numara); //p1 parametresini numara değişkeninden aldık çünkü ogr id ile birbirlerine bağlılar
            baglanti.Open(); //bağlantıyı açtık data reader kullanabilmek için
            SqlDataReader dr = komut2.ExecuteReader(); //sql data reader ile sorguyu çalıştırdık 
            while (dr.Read()) //veri okuma işlemi
            {
                this.Text = dr[0] + " " + dr[1]; //formun başlığını öğrenci adı soyadı olarak ayarladık
            }
            baglanti.Close(); //bağlantıyı kapattık


        }
    }
}
