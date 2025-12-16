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

namespace Hastane_Yonetim_Randevu_Sistemi
{
    public partial class frm_sinav_notlar : Form
    {
        public frm_sinav_notlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Feyza;Initial Catalog=e_okul;Integrated Security=True"); //sql tablosu ile bağlantımızı kurduk

        DataSet1TableAdapters.tbl_notlarTableAdapter ds = new DataSet1TableAdapters.tbl_notlarTableAdapter();
        private void btn_ara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txt_id.Text));
        }

        private void frm_sinav_notlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_ders.DisplayMember = "DERSAD";
            cmb_ders.ValueMember = "DERSID";
            cmb_ders.DataSource = dt;
            baglanti.Close();
        }

        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txt id nin text i eşittir datagridin satırları içerisindeki yni seçmiş
            //olduğumuz satırdaki e deki yani seçmiş olduğumuz olayın olduğu satırın indeksini aldık
            //bu indeksteki hücreler içerisindeki sıfırıncı hücrenin değerini yazdırıyoruz 0. hücreyi seçtik çünkü kulüp id burada sql tablosunda
            txt_sinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_sinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_sinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_proje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_ort.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, proje;
            double ortalama;
            string durum;
            sinav1 = Convert.ToInt16(txt_sinav1.Text);
            sinav2 = Convert.ToInt16(txt_sinav2.Text);
            sinav3 = Convert.ToInt16(txt_sinav3.Text);
            proje = Convert.ToInt16(txt_proje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txt_ort.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                txt_durum.Text = "True";
            }
            else
            {
                txt_durum.Text = "False";
            }

            MessageBox.Show("Ortalama ve Durum Hesaplandı");

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmb_ders.SelectedValue.ToString()), int.Parse(txt_id.Text), 
                byte.Parse(txt_sinav1.Text), byte.Parse(txt_sinav2.Text), byte.Parse(txt_sinav3.Text), 
                byte.Parse(txt_proje.Text), decimal.Parse(txt_ort.Text), bool.Parse(txt_durum.Text),notid);

            MessageBox.Show("Not Bilgisi Güncellendi");

            int guncellenenSatirSayisi = ds.NotGuncelle(byte.Parse(cmb_ders.SelectedValue.ToString()), int.Parse(txt_id.Text),
                byte.Parse(txt_sinav1.Text), byte.Parse(txt_sinav2.Text), byte.Parse(txt_sinav3.Text),
                byte.Parse(txt_proje.Text), decimal.Parse(txt_ort.Text), bool.Parse(txt_durum.Text), notid
            );

            if (guncellenenSatirSayisi > 0)
            {
                // Bu kısım çalışıyorsa güncelleme BAŞARILI olmuştur.
                // Sorun 2 (Yanlış Veritabanı) olabilir.
                MessageBox.Show($"Başarılı! {guncellenenSatirSayisi} kayıt güncellendi. {notid} ID'li kayıt.");
            }
            else
            {
                // Bu kısım çalışıyorsa, SQL sorgusu 0 satır bulmuştur.
                // Sorun 1 (WHERE Koşulu Başarısızlığı) olabilir.
                MessageBox.Show($"HATA: Güncellenecek kayıt bulunamadı. Lütfen {notid} ID'sinin veritabanında var olduğundan emin olun.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Form üzerindeki tüm kontrolleri döngüye al
                foreach (Control item in this.Controls)
                {
                    // Eğer kontrol bir TextBox ise...
                    if (item is TextBox)
                    {
                        // İçeriğini temizle
                        item.Text = "";
                    }

                    // Eğer kontrol bir ComboBox ise, seçimi sıfırla
                    if (item is ComboBox)
                    {
                        (item as ComboBox).SelectedIndex = -1;
                    }
                }
            }
        }
    }
}
