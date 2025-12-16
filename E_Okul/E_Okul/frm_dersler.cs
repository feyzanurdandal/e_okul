using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_Randevu_Sistemi
{
    public partial class frm_dersler : Form
    {
        public frm_dersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.tbl_derslerTableAdapter ds = new DataSet1TableAdapters.tbl_derslerTableAdapter();

        private void frm_dersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txt_ad.Text);
            MessageBox.Show("Ders eklendi");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txt_ad.Text,byte.Parse(txt_id.Text));
            MessageBox.Show("Ders güncellendi");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txt_id.Text));    
            MessageBox.Show("Ders silindi");
            dataGridView1.DataSource = ds.DersListesi();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txt id nin text i eşittir datagridin satırları içerisindeki yni seçmiş
            //olduğumuz satırdaki e deki yani seçmiş olduğumuz olayın olduğu satırın indeksini aldık
            //bu indeksteki hücreler içerisindeki sıfırıncı hücrenin değerini yazdırıyoruz 0. hücreyi seçtik çünkü kulüp id burada sql tablosunda
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


        }
    }
}
