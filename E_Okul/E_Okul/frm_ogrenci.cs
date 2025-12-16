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
    public partial class frm_ogrenci : Form
    {
        public frm_ogrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbl_ogr_bilgiTableAdapter ds = new DataSet1TableAdapters.tbl_ogr_bilgiTableAdapter();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ogr_listele();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Feyza;Initial Catalog=e_okul;Integrated Security=True"); //sql tablosu ile bağlantımızı kurduk


        private void frm_ogrenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_okulDataSet.kulup_bilgi' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = ds.ogr_listele();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kulup_bilgi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_kulup.DisplayMember = "KULUPAD";
            cmb_kulup.ValueMember = "KULUPID";
            cmb_kulup.DataSource = dt;
            baglanti.Close();

        }
        string cinsiyet = "";
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            if (radio_k.Checked == true) 
                { cinsiyet = "Kadın"; }
            else if (radio_e.Checked == true) 
                { cinsiyet = "Erkek"; }
            else 
                { MessageBox.Show("Cinsiyet seçimi yapınız"); }


            ds.ogr_ekle(txt_ad.Text, txt_soyad.Text, cinsiyet, byte.Parse(cmb_kulup.Text));

            dataGridView1.DataSource = ds.ogr_ekle(txt_ad.Text, txt_soyad.Text, cinsiyet, byte.Parse(cmb_kulup.SelectedValue.ToString()));

            MessageBox.Show("öğrenci eklendi");
            ds.ogr_listele();



        }

        private void cmb_kulup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_id.Text = cmb_kulup.SelectedValue.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            ds.ogr_sil(int.Parse(txt_id.Text));
            MessageBox.Show("Öğrenci silindi");
            ds.ogr_listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.ogr_guncelle(txt_ad.Text, txt_soyad.Text, cinsiyet,
                byte.Parse(cmb_kulup.SelectedValue.ToString()),int.Parse(txt_id.Text));
            MessageBox.Show("Öğrenci güncellendi");
            ds.ogr_listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txt id nin text i eşittir datagridin satırları içerisindeki yni seçmiş
            //olduğumuz satırdaki e deki yani seçmiş olduğumuz olayın olduğu satırın indeksini aldık
            //bu indeksteki hücreler içerisindeki sıfırıncı hücrenin değerini yazdırıyoruz 0. hücreyi seçtik çünkü kulüp id burada sql tablosunda
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[e.RowIndex ].Cells[2].Value.ToString();



            //BURAYI DÜZELT
            // Tablodaki 5. sütunda (Cells[4]) olan Kulüp ID'sini al.
            string kulupID = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            if(cmb_kulup.DataSource != null)
            {
                if (int.TryParse(kulupID, out int idToSelect))
                {
                    cmb_kulup.SelectedValue = idToSelect;
                }
            }

            // ComboBox'a "Git ve bu ID numarasına (kulupID) sahip olan öğeyi seç" de.
            //cmb_kulup.SelectedValue = int.Parse(kulupID);






            // Tablodaki 4. sütunda (Cells[3]) olan Cinsiyet metnini al.
            cinsiyet = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (cinsiyet == "Kadın")
            {
                radio_k.Checked = true; // Kadın butonunu işaretle
            }
            else if (cinsiyet == "Erkek")
            {
                radio_e.Checked = true; // Erkek butonunu işaretle
            }
        }

        private void radio_k_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_k.Checked == true)
            { cinsiyet = "Kadın"; }
          
        }

        private void radio_e_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_e.Checked == true)
            { cinsiyet = "Erkek"; }
            
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.ograra(textBox1.Text);
        }
    }
}
