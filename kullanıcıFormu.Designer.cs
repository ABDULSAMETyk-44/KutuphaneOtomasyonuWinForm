namespace KutuphaneOtomasyonuWinForm
{
    partial class kullanıcıFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcıFormu));
            this.kisiGüncelle = new System.Windows.Forms.Button();
            this.silKullanici = new System.Windows.Forms.Button();
            this.ekleKullanici = new System.Windows.Forms.Button();
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.kullanıcıisimlabel = new System.Windows.Forms.Label();
            this.kullanıcıisimtextBox = new System.Windows.Forms.TextBox();
            this.kullanıcısoyisimtextBox = new System.Windows.Forms.TextBox();
            this.kullanıcısoyisimlabel = new System.Windows.Forms.Label();
            this.kullanıcı_tc_textBox = new System.Windows.Forms.TextBox();
            this.kullanıcı_tc_label = new System.Windows.Forms.Label();
            this.kullanıcı_tel_no_textBox = new System.Windows.Forms.TextBox();
            this.kullanıcı_tel_no_label = new System.Windows.Forms.Label();
            this.buttonDosyaKaydetKullanıcı = new System.Windows.Forms.Button();
            this.buttonDosyadanOkuKullanıcı = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // kisiGüncelle
            // 
            this.kisiGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kisiGüncelle.BackgroundImage")));
            this.kisiGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kisiGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisiGüncelle.Location = new System.Drawing.Point(12, 93);
            this.kisiGüncelle.Name = "kisiGüncelle";
            this.kisiGüncelle.Size = new System.Drawing.Size(209, 38);
            this.kisiGüncelle.TabIndex = 6;
            this.kisiGüncelle.Text = "Kişi Güncelle";
            this.kisiGüncelle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kisiGüncelle.UseVisualStyleBackColor = true;
            // 
            // silKullanici
            // 
            this.silKullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("silKullanici.BackgroundImage")));
            this.silKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.silKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silKullanici.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.silKullanici.Location = new System.Drawing.Point(12, 50);
            this.silKullanici.Name = "silKullanici";
            this.silKullanici.Size = new System.Drawing.Size(209, 37);
            this.silKullanici.TabIndex = 5;
            this.silKullanici.Text = "Sil     ";
            this.silKullanici.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.silKullanici.UseVisualStyleBackColor = true;
            // 
            // ekleKullanici
            // 
            this.ekleKullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ekleKullanici.BackgroundImage")));
            this.ekleKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ekleKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleKullanici.Location = new System.Drawing.Point(12, 12);
            this.ekleKullanici.Name = "ekleKullanici";
            this.ekleKullanici.Size = new System.Drawing.Size(209, 32);
            this.ekleKullanici.TabIndex = 4;
            this.ekleKullanici.Text = "        Ekle    ";
            this.ekleKullanici.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ekleKullanici.UseVisualStyleBackColor = true;
            this.ekleKullanici.Click += new System.EventHandler(this.ekleKullanici_Click);
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Location = new System.Drawing.Point(257, 12);
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.RowHeadersWidth = 51;
            this.dgvKisiler.RowTemplate.Height = 24;
            this.dgvKisiler.Size = new System.Drawing.Size(518, 354);
            this.dgvKisiler.TabIndex = 7;
            // 
            // kullanıcıisimlabel
            // 
            this.kullanıcıisimlabel.AutoSize = true;
            this.kullanıcıisimlabel.Location = new System.Drawing.Point(96, 236);
            this.kullanıcıisimlabel.Name = "kullanıcıisimlabel";
            this.kullanıcıisimlabel.Size = new System.Drawing.Size(31, 16);
            this.kullanıcıisimlabel.TabIndex = 8;
            this.kullanıcıisimlabel.Text = "İsim";
            this.kullanıcıisimlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // kullanıcıisimtextBox
            // 
            this.kullanıcıisimtextBox.Location = new System.Drawing.Point(65, 255);
            this.kullanıcıisimtextBox.Name = "kullanıcıisimtextBox";
            this.kullanıcıisimtextBox.Size = new System.Drawing.Size(100, 22);
            this.kullanıcıisimtextBox.TabIndex = 9;
            this.kullanıcıisimtextBox.TextChanged += new System.EventHandler(this.kullanıcıisimtextBox_TextChanged);
            // 
            // kullanıcısoyisimtextBox
            // 
            this.kullanıcısoyisimtextBox.Location = new System.Drawing.Point(65, 299);
            this.kullanıcısoyisimtextBox.Name = "kullanıcısoyisimtextBox";
            this.kullanıcısoyisimtextBox.Size = new System.Drawing.Size(100, 22);
            this.kullanıcısoyisimtextBox.TabIndex = 11;
            // 
            // kullanıcısoyisimlabel
            // 
            this.kullanıcısoyisimlabel.AutoSize = true;
            this.kullanıcısoyisimlabel.Location = new System.Drawing.Point(85, 280);
            this.kullanıcısoyisimlabel.Name = "kullanıcısoyisimlabel";
            this.kullanıcısoyisimlabel.Size = new System.Drawing.Size(55, 16);
            this.kullanıcısoyisimlabel.TabIndex = 10;
            this.kullanıcısoyisimlabel.Text = "Soyisim";
            // 
            // kullanıcı_tc_textBox
            // 
            this.kullanıcı_tc_textBox.Location = new System.Drawing.Point(65, 340);
            this.kullanıcı_tc_textBox.Name = "kullanıcı_tc_textBox";
            this.kullanıcı_tc_textBox.Size = new System.Drawing.Size(100, 22);
            this.kullanıcı_tc_textBox.TabIndex = 13;
            // 
            // kullanıcı_tc_label
            // 
            this.kullanıcı_tc_label.AutoSize = true;
            this.kullanıcı_tc_label.Location = new System.Drawing.Point(75, 321);
            this.kullanıcı_tc_label.Name = "kullanıcı_tc_label";
            this.kullanıcı_tc_label.Size = new System.Drawing.Size(90, 16);
            this.kullanıcı_tc_label.TabIndex = 12;
            this.kullanıcı_tc_label.Text = "T.C. Kimlik No";
            this.kullanıcı_tc_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // kullanıcı_tel_no_textBox
            // 
            this.kullanıcı_tel_no_textBox.Location = new System.Drawing.Point(65, 384);
            this.kullanıcı_tel_no_textBox.Name = "kullanıcı_tel_no_textBox";
            this.kullanıcı_tel_no_textBox.Size = new System.Drawing.Size(100, 22);
            this.kullanıcı_tel_no_textBox.TabIndex = 15;
            // 
            // kullanıcı_tel_no_label
            // 
            this.kullanıcı_tel_no_label.AutoSize = true;
            this.kullanıcı_tel_no_label.Location = new System.Drawing.Point(75, 365);
            this.kullanıcı_tel_no_label.Name = "kullanıcı_tel_no_label";
            this.kullanıcı_tel_no_label.Size = new System.Drawing.Size(74, 16);
            this.kullanıcı_tel_no_label.TabIndex = 14;
            this.kullanıcı_tel_no_label.Text = "Telefon No";
            // 
            // buttonDosyaKaydetKullanıcı
            // 
            this.buttonDosyaKaydetKullanıcı.Location = new System.Drawing.Point(12, 150);
            this.buttonDosyaKaydetKullanıcı.Name = "buttonDosyaKaydetKullanıcı";
            this.buttonDosyaKaydetKullanıcı.Size = new System.Drawing.Size(209, 23);
            this.buttonDosyaKaydetKullanıcı.TabIndex = 29;
            this.buttonDosyaKaydetKullanıcı.Text = "Dosya Kaydet";
            this.buttonDosyaKaydetKullanıcı.UseVisualStyleBackColor = true;
            this.buttonDosyaKaydetKullanıcı.Click += new System.EventHandler(this.buttonDosyaEkleKullanıcı_Click);
            // 
            // buttonDosyadanOkuKullanıcı
            // 
            this.buttonDosyadanOkuKullanıcı.Location = new System.Drawing.Point(12, 188);
            this.buttonDosyadanOkuKullanıcı.Name = "buttonDosyadanOkuKullanıcı";
            this.buttonDosyadanOkuKullanıcı.Size = new System.Drawing.Size(209, 23);
            this.buttonDosyadanOkuKullanıcı.TabIndex = 28;
            this.buttonDosyadanOkuKullanıcı.Text = "Dosyadan Oku";
            this.buttonDosyadanOkuKullanıcı.UseVisualStyleBackColor = true;
            this.buttonDosyadanOkuKullanıcı.Click += new System.EventHandler(this.buttonDosyadanOkuKullanıcı_Click);
            // 
            // kullanıcıFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDosyaKaydetKullanıcı);
            this.Controls.Add(this.buttonDosyadanOkuKullanıcı);
            this.Controls.Add(this.kullanıcı_tel_no_textBox);
            this.Controls.Add(this.kullanıcı_tel_no_label);
            this.Controls.Add(this.kullanıcı_tc_textBox);
            this.Controls.Add(this.kullanıcı_tc_label);
            this.Controls.Add(this.kullanıcısoyisimtextBox);
            this.Controls.Add(this.kullanıcısoyisimlabel);
            this.Controls.Add(this.kullanıcıisimtextBox);
            this.Controls.Add(this.kullanıcıisimlabel);
            this.Controls.Add(this.dgvKisiler);
            this.Controls.Add(this.kisiGüncelle);
            this.Controls.Add(this.silKullanici);
            this.Controls.Add(this.ekleKullanici);
            this.Name = "kullanıcıFormu";
            this.Text = "kullanıcıFormu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kisiGüncelle;
        private System.Windows.Forms.Button silKullanici;
        private System.Windows.Forms.Button ekleKullanici;
        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.Label kullanıcıisimlabel;
        private System.Windows.Forms.TextBox kullanıcıisimtextBox;
        private System.Windows.Forms.TextBox kullanıcısoyisimtextBox;
        private System.Windows.Forms.Label kullanıcısoyisimlabel;
        private System.Windows.Forms.TextBox kullanıcı_tc_textBox;
        private System.Windows.Forms.Label kullanıcı_tc_label;
        private System.Windows.Forms.TextBox kullanıcı_tel_no_textBox;
        private System.Windows.Forms.Label kullanıcı_tel_no_label;
        private System.Windows.Forms.Button buttonDosyaKaydetKullanıcı;
        private System.Windows.Forms.Button buttonDosyadanOkuKullanıcı;
    }
}