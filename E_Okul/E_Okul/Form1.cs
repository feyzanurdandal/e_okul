using E_Okul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_ogr_Click(object sender, EventArgs e)
        {
            frm_ogr_notlar frm_Ogr_Notlar = new frm_ogr_notlar();
            frm_Ogr_Notlar.numara = textBox1.Text;
            frm_Ogr_Notlar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoşgeldiniz frm_Ogretmen = new Hoşgeldiniz();
            frm_Ogretmen.numara_ogrt = textBox2.Text;
            frm_Ogretmen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
