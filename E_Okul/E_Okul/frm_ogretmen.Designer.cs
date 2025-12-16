namespace E_Okul
{
    partial class Hoşgeldiniz
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
            this.selam_lbl = new System.Windows.Forms.Label();
            this.btn_ders = new System.Windows.Forms.Button();
            this.btn_sınavnotlar = new System.Windows.Forms.Button();
            this.btn_kulup = new System.Windows.Forms.Button();
            this.btn_ogr_islemler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selam_lbl
            // 
            this.selam_lbl.AutoSize = true;
            this.selam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selam_lbl.Location = new System.Drawing.Point(133, 28);
            this.selam_lbl.Name = "selam_lbl";
            this.selam_lbl.Size = new System.Drawing.Size(0, 25);
            this.selam_lbl.TabIndex = 0;
            // 
            // btn_ders
            // 
            this.btn_ders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ders.Location = new System.Drawing.Point(76, 39);
            this.btn_ders.Name = "btn_ders";
            this.btn_ders.Size = new System.Drawing.Size(188, 64);
            this.btn_ders.TabIndex = 1;
            this.btn_ders.Text = "Ders İşlemleri";
            this.btn_ders.UseVisualStyleBackColor = true;
            this.btn_ders.Click += new System.EventHandler(this.btn_ders_Click);
            // 
            // btn_sınavnotlar
            // 
            this.btn_sınavnotlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sınavnotlar.Location = new System.Drawing.Point(76, 121);
            this.btn_sınavnotlar.Name = "btn_sınavnotlar";
            this.btn_sınavnotlar.Size = new System.Drawing.Size(188, 64);
            this.btn_sınavnotlar.TabIndex = 2;
            this.btn_sınavnotlar.Text = "Sınav Notları";
            this.btn_sınavnotlar.UseVisualStyleBackColor = true;
            this.btn_sınavnotlar.Click += new System.EventHandler(this.btn_sınavnotlar_Click);
            // 
            // btn_kulup
            // 
            this.btn_kulup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kulup.Location = new System.Drawing.Point(76, 202);
            this.btn_kulup.Name = "btn_kulup";
            this.btn_kulup.Size = new System.Drawing.Size(188, 64);
            this.btn_kulup.TabIndex = 3;
            this.btn_kulup.Text = "Kulüp İşlemleri";
            this.btn_kulup.UseVisualStyleBackColor = true;
            this.btn_kulup.Click += new System.EventHandler(this.btn_kulup_Click);
            // 
            // btn_ogr_islemler
            // 
            this.btn_ogr_islemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogr_islemler.Location = new System.Drawing.Point(76, 285);
            this.btn_ogr_islemler.Name = "btn_ogr_islemler";
            this.btn_ogr_islemler.Size = new System.Drawing.Size(188, 64);
            this.btn_ogr_islemler.TabIndex = 4;
            this.btn_ogr_islemler.Text = "Öğrenci İşlemleri";
            this.btn_ogr_islemler.UseVisualStyleBackColor = true;
            this.btn_ogr_islemler.Click += new System.EventHandler(this.btn_ogr_islemler_Click);
            // 
            // Hoşgeldiniz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(339, 392);
            this.Controls.Add(this.btn_ogr_islemler);
            this.Controls.Add(this.btn_kulup);
            this.Controls.Add(this.btn_sınavnotlar);
            this.Controls.Add(this.btn_ders);
            this.Controls.Add(this.selam_lbl);
            this.Name = "Hoşgeldiniz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ogretmen";
            this.Load += new System.EventHandler(this.frm_ogretmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selam_lbl;
        private System.Windows.Forms.Button btn_ders;
        private System.Windows.Forms.Button btn_sınavnotlar;
        private System.Windows.Forms.Button btn_kulup;
        private System.Windows.Forms.Button btn_ogr_islemler;
    }
}