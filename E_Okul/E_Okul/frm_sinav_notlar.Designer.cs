namespace Hastane_Yonetim_Randevu_Sistemi
{
    partial class frm_sinav_notlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ogr_id = new System.Windows.Forms.Label();
            this.lbl_ders = new System.Windows.Forms.Label();
            this.lbl_sinav1 = new System.Windows.Forms.Label();
            this.lbl_sinav2 = new System.Windows.Forms.Label();
            this.lbl_sinav3 = new System.Windows.Forms.Label();
            this.lbl_prpje = new System.Windows.Forms.Label();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_sinav1 = new System.Windows.Forms.TextBox();
            this.txt_proje = new System.Windows.Forms.TextBox();
            this.txt_sinav2 = new System.Windows.Forms.TextBox();
            this.txt_sinav3 = new System.Windows.Forms.TextBox();
            this.txt_durum = new System.Windows.Forms.TextBox();
            this.txt_ort = new System.Windows.Forms.TextBox();
            this.cmb_ders = new System.Windows.Forms.ComboBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_ogr_id
            // 
            this.lbl_ogr_id.AutoSize = true;
            this.lbl_ogr_id.Location = new System.Drawing.Point(48, 28);
            this.lbl_ogr_id.Name = "lbl_ogr_id";
            this.lbl_ogr_id.Size = new System.Drawing.Size(73, 16);
            this.lbl_ogr_id.TabIndex = 1;
            this.lbl_ogr_id.Text = "Öğrenci ID:";
            // 
            // lbl_ders
            // 
            this.lbl_ders.AutoSize = true;
            this.lbl_ders.Location = new System.Drawing.Point(82, 64);
            this.lbl_ders.Name = "lbl_ders";
            this.lbl_ders.Size = new System.Drawing.Size(39, 16);
            this.lbl_ders.TabIndex = 2;
            this.lbl_ders.Text = "Ders:";
            // 
            // lbl_sinav1
            // 
            this.lbl_sinav1.AutoSize = true;
            this.lbl_sinav1.Location = new System.Drawing.Point(67, 100);
            this.lbl_sinav1.Name = "lbl_sinav1";
            this.lbl_sinav1.Size = new System.Drawing.Size(54, 16);
            this.lbl_sinav1.TabIndex = 3;
            this.lbl_sinav1.Text = "Sınav 1:";
            // 
            // lbl_sinav2
            // 
            this.lbl_sinav2.AutoSize = true;
            this.lbl_sinav2.Location = new System.Drawing.Point(67, 135);
            this.lbl_sinav2.Name = "lbl_sinav2";
            this.lbl_sinav2.Size = new System.Drawing.Size(54, 16);
            this.lbl_sinav2.TabIndex = 4;
            this.lbl_sinav2.Text = "Sınav 2:";
            // 
            // lbl_sinav3
            // 
            this.lbl_sinav3.AutoSize = true;
            this.lbl_sinav3.Location = new System.Drawing.Point(67, 174);
            this.lbl_sinav3.Name = "lbl_sinav3";
            this.lbl_sinav3.Size = new System.Drawing.Size(54, 16);
            this.lbl_sinav3.TabIndex = 5;
            this.lbl_sinav3.Text = "Sınav 3:";
            // 
            // lbl_prpje
            // 
            this.lbl_prpje.AutoSize = true;
            this.lbl_prpje.Location = new System.Drawing.Point(316, 25);
            this.lbl_prpje.Name = "lbl_prpje";
            this.lbl_prpje.Size = new System.Drawing.Size(42, 16);
            this.lbl_prpje.TabIndex = 6;
            this.lbl_prpje.Text = "Proje:";
            // 
            // lbl_ort
            // 
            this.lbl_ort.AutoSize = true;
            this.lbl_ort.Location = new System.Drawing.Point(293, 58);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(65, 16);
            this.lbl_ort.TabIndex = 7;
            this.lbl_ort.Text = "Ortalama:";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Location = new System.Drawing.Point(309, 97);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(49, 16);
            this.lbl_durum.TabIndex = 8;
            this.lbl_durum.Text = "Durum:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(123, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 22);
            this.txt_id.TabIndex = 9;
            // 
            // txt_sinav1
            // 
            this.txt_sinav1.Location = new System.Drawing.Point(123, 94);
            this.txt_sinav1.Name = "txt_sinav1";
            this.txt_sinav1.Size = new System.Drawing.Size(121, 22);
            this.txt_sinav1.TabIndex = 10;
            // 
            // txt_proje
            // 
            this.txt_proje.Location = new System.Drawing.Point(359, 25);
            this.txt_proje.Name = "txt_proje";
            this.txt_proje.Size = new System.Drawing.Size(124, 22);
            this.txt_proje.TabIndex = 11;
            // 
            // txt_sinav2
            // 
            this.txt_sinav2.Location = new System.Drawing.Point(123, 132);
            this.txt_sinav2.Name = "txt_sinav2";
            this.txt_sinav2.Size = new System.Drawing.Size(121, 22);
            this.txt_sinav2.TabIndex = 12;
            // 
            // txt_sinav3
            // 
            this.txt_sinav3.Location = new System.Drawing.Point(123, 168);
            this.txt_sinav3.Name = "txt_sinav3";
            this.txt_sinav3.Size = new System.Drawing.Size(121, 22);
            this.txt_sinav3.TabIndex = 13;
            // 
            // txt_durum
            // 
            this.txt_durum.Location = new System.Drawing.Point(359, 97);
            this.txt_durum.Name = "txt_durum";
            this.txt_durum.Size = new System.Drawing.Size(124, 22);
            this.txt_durum.TabIndex = 14;
            // 
            // txt_ort
            // 
            this.txt_ort.Location = new System.Drawing.Point(359, 60);
            this.txt_ort.Name = "txt_ort";
            this.txt_ort.Size = new System.Drawing.Size(124, 22);
            this.txt_ort.TabIndex = 15;
            // 
            // cmb_ders
            // 
            this.cmb_ders.FormattingEnabled = true;
            this.cmb_ders.Location = new System.Drawing.Point(123, 58);
            this.cmb_ders.Name = "cmb_ders";
            this.cmb_ders.Size = new System.Drawing.Size(121, 24);
            this.cmb_ders.TabIndex = 16;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(529, 25);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(110, 51);
            this.btn_hesapla.TabIndex = 17;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(529, 84);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(110, 53);
            this.btn_guncelle.TabIndex = 18;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(645, 84);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(110, 53);
            this.btn_ara.TabIndex = 19;
            this.btn_ara.Text = "Arama";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_sinav_notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.cmb_ders);
            this.Controls.Add(this.txt_ort);
            this.Controls.Add(this.txt_durum);
            this.Controls.Add(this.txt_sinav3);
            this.Controls.Add(this.txt_sinav2);
            this.Controls.Add(this.txt_proje);
            this.Controls.Add(this.txt_sinav1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.lbl_prpje);
            this.Controls.Add(this.lbl_sinav3);
            this.Controls.Add(this.lbl_sinav2);
            this.Controls.Add(this.lbl_sinav1);
            this.Controls.Add(this.lbl_ders);
            this.Controls.Add(this.lbl_ogr_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_sinav_notlar";
            this.Text = "frm_sinav_notlar";
            this.Load += new System.EventHandler(this.frm_sinav_notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ogr_id;
        private System.Windows.Forms.Label lbl_ders;
        private System.Windows.Forms.Label lbl_sinav1;
        private System.Windows.Forms.Label lbl_sinav2;
        private System.Windows.Forms.Label lbl_sinav3;
        private System.Windows.Forms.Label lbl_prpje;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_sinav1;
        private System.Windows.Forms.TextBox txt_proje;
        private System.Windows.Forms.TextBox txt_sinav2;
        private System.Windows.Forms.TextBox txt_sinav3;
        private System.Windows.Forms.TextBox txt_durum;
        private System.Windows.Forms.TextBox txt_ort;
        private System.Windows.Forms.ComboBox cmb_ders;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button button1;
    }
}