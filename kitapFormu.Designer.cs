namespace KutuphaneOtomasyonuWinForm
{
    partial class kitapFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapFormu));
            this.kitapGüncelle = new System.Windows.Forms.Button();
            this.kitapSil = new System.Windows.Forms.Button();
            this.kitapEkle = new System.Windows.Forms.Button();
            this.kitapadettextBox = new System.Windows.Forms.TextBox();
            this.kitapadetlabel = new System.Windows.Forms.Label();
            this.kitapyayinevitextBox = new System.Windows.Forms.TextBox();
            this.kitapyayinevilabel = new System.Windows.Forms.Label();
            this.kitapyazartextBox = new System.Windows.Forms.TextBox();
            this.kitapyazarlabel = new System.Windows.Forms.Label();
            this.kitapadtextBox = new System.Windows.Forms.TextBox();
            this.kitapadlabel = new System.Windows.Forms.Label();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.buttonDosyadanOkuKitap = new System.Windows.Forms.Button();
            this.buttonDosyaKaydetKitap = new System.Windows.Forms.Button();
            this.btn_degisiklik_kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapGüncelle
            // 
            this.kitapGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kitapGüncelle.BackgroundImage")));
            this.kitapGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kitapGüncelle.Location = new System.Drawing.Point(12, 88);
            this.kitapGüncelle.Name = "kitapGüncelle";
            this.kitapGüncelle.Size = new System.Drawing.Size(209, 32);
            this.kitapGüncelle.TabIndex = 12;
            this.kitapGüncelle.Text = "Güncelle";
            this.kitapGüncelle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kitapGüncelle.UseVisualStyleBackColor = true;
            this.kitapGüncelle.Click += new System.EventHandler(this.kitapGüncelle_Click);
            // 
            // kitapSil
            // 
            this.kitapSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kitapSil.BackgroundImage")));
            this.kitapSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kitapSil.Location = new System.Drawing.Point(12, 50);
            this.kitapSil.Name = "kitapSil";
            this.kitapSil.Size = new System.Drawing.Size(209, 32);
            this.kitapSil.TabIndex = 11;
            this.kitapSil.Text = "Sil";
            this.kitapSil.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kitapSil.UseVisualStyleBackColor = true;
            this.kitapSil.Click += new System.EventHandler(this.kitapSil_Click);
            // 
            // kitapEkle
            // 
            this.kitapEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kitapEkle.BackgroundImage")));
            this.kitapEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapEkle.Location = new System.Drawing.Point(12, 12);
            this.kitapEkle.Name = "kitapEkle";
            this.kitapEkle.Size = new System.Drawing.Size(209, 32);
            this.kitapEkle.TabIndex = 10;
            this.kitapEkle.Text = "Ekle ";
            this.kitapEkle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kitapEkle.UseVisualStyleBackColor = true;
            this.kitapEkle.Click += new System.EventHandler(this.kitapEkle_Click);
            // 
            // kitapadettextBox
            // 
            this.kitapadettextBox.Location = new System.Drawing.Point(67, 367);
            this.kitapadettextBox.Name = "kitapadettextBox";
            this.kitapadettextBox.Size = new System.Drawing.Size(100, 22);
            this.kitapadettextBox.TabIndex = 23;
            // 
            // kitapadetlabel
            // 
            this.kitapadetlabel.AutoSize = true;
            this.kitapadetlabel.Location = new System.Drawing.Point(96, 348);
            this.kitapadetlabel.Name = "kitapadetlabel";
            this.kitapadetlabel.Size = new System.Drawing.Size(35, 16);
            this.kitapadetlabel.TabIndex = 22;
            this.kitapadetlabel.Text = "Adet";
            // 
            // kitapyayinevitextBox
            // 
            this.kitapyayinevitextBox.Location = new System.Drawing.Point(67, 325);
            this.kitapyayinevitextBox.Name = "kitapyayinevitextBox";
            this.kitapyayinevitextBox.Size = new System.Drawing.Size(100, 22);
            this.kitapyayinevitextBox.TabIndex = 21;
            // 
            // kitapyayinevilabel
            // 
            this.kitapyayinevilabel.AutoSize = true;
            this.kitapyayinevilabel.Location = new System.Drawing.Point(87, 306);
            this.kitapyayinevilabel.Name = "kitapyayinevilabel";
            this.kitapyayinevilabel.Size = new System.Drawing.Size(59, 16);
            this.kitapyayinevilabel.TabIndex = 20;
            this.kitapyayinevilabel.Text = "Yayınevi";
            // 
            // kitapyazartextBox
            // 
            this.kitapyazartextBox.Location = new System.Drawing.Point(67, 283);
            this.kitapyazartextBox.Name = "kitapyazartextBox";
            this.kitapyazartextBox.Size = new System.Drawing.Size(100, 22);
            this.kitapyazartextBox.TabIndex = 19;
            // 
            // kitapyazarlabel
            // 
            this.kitapyazarlabel.AutoSize = true;
            this.kitapyazarlabel.Location = new System.Drawing.Point(96, 264);
            this.kitapyazarlabel.Name = "kitapyazarlabel";
            this.kitapyazarlabel.Size = new System.Drawing.Size(42, 16);
            this.kitapyazarlabel.TabIndex = 18;
            this.kitapyazarlabel.Text = "Yazar";
            // 
            // kitapadtextBox
            // 
            this.kitapadtextBox.Location = new System.Drawing.Point(67, 239);
            this.kitapadtextBox.Name = "kitapadtextBox";
            this.kitapadtextBox.Size = new System.Drawing.Size(100, 22);
            this.kitapadtextBox.TabIndex = 17;
            this.kitapadtextBox.TextChanged += new System.EventHandler(this.kitapadtextBox_TextChanged);
            // 
            // kitapadlabel
            // 
            this.kitapadlabel.AutoSize = true;
            this.kitapadlabel.Location = new System.Drawing.Point(87, 220);
            this.kitapadlabel.Name = "kitapadlabel";
            this.kitapadlabel.Size = new System.Drawing.Size(60, 16);
            this.kitapadlabel.TabIndex = 16;
            this.kitapadlabel.Text = "Kitap Adı";
            // 
            // dgvKitap
            // 
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Location = new System.Drawing.Point(249, 30);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.RowHeadersWidth = 51;
            this.dgvKitap.RowTemplate.Height = 24;
            this.dgvKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitap.Size = new System.Drawing.Size(518, 354);
            this.dgvKitap.TabIndex = 24;
            // 
            // buttonDosyadanOkuKitap
            // 
            this.buttonDosyadanOkuKitap.Location = new System.Drawing.Point(12, 174);
            this.buttonDosyadanOkuKitap.Name = "buttonDosyadanOkuKitap";
            this.buttonDosyadanOkuKitap.Size = new System.Drawing.Size(209, 23);
            this.buttonDosyadanOkuKitap.TabIndex = 26;
            this.buttonDosyadanOkuKitap.Text = "Dosyadan Oku";
            this.buttonDosyadanOkuKitap.UseVisualStyleBackColor = true;
            this.buttonDosyadanOkuKitap.Click += new System.EventHandler(this.buttonDosyadanOkuKitap_Click);
            // 
            // buttonDosyaKaydetKitap
            // 
            this.buttonDosyaKaydetKitap.Location = new System.Drawing.Point(12, 136);
            this.buttonDosyaKaydetKitap.Name = "buttonDosyaKaydetKitap";
            this.buttonDosyaKaydetKitap.Size = new System.Drawing.Size(209, 23);
            this.buttonDosyaKaydetKitap.TabIndex = 27;
            this.buttonDosyaKaydetKitap.Text = "Dosya Kaydet";
            this.buttonDosyaKaydetKitap.UseVisualStyleBackColor = true;
            this.buttonDosyaKaydetKitap.Click += new System.EventHandler(this.buttonDosyaKaydetKitap_Click);
            // 
            // btn_degisiklik_kaydet
            // 
            this.btn_degisiklik_kaydet.Location = new System.Drawing.Point(12, 131);
            this.btn_degisiklik_kaydet.Name = "btn_degisiklik_kaydet";
            this.btn_degisiklik_kaydet.Size = new System.Drawing.Size(209, 33);
            this.btn_degisiklik_kaydet.TabIndex = 28;
            this.btn_degisiklik_kaydet.Text = "Değişikliği Kaydet";
            this.btn_degisiklik_kaydet.UseVisualStyleBackColor = true;
            this.btn_degisiklik_kaydet.Visible = false;
            this.btn_degisiklik_kaydet.Click += new System.EventHandler(this.btn_degisiklik_kaydet_Click);
            // 
            // kitapFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_degisiklik_kaydet);
            this.Controls.Add(this.buttonDosyaKaydetKitap);
            this.Controls.Add(this.buttonDosyadanOkuKitap);
            this.Controls.Add(this.dgvKitap);
            this.Controls.Add(this.kitapadettextBox);
            this.Controls.Add(this.kitapadetlabel);
            this.Controls.Add(this.kitapyayinevitextBox);
            this.Controls.Add(this.kitapyayinevilabel);
            this.Controls.Add(this.kitapyazartextBox);
            this.Controls.Add(this.kitapyazarlabel);
            this.Controls.Add(this.kitapadtextBox);
            this.Controls.Add(this.kitapadlabel);
            this.Controls.Add(this.kitapGüncelle);
            this.Controls.Add(this.kitapSil);
            this.Controls.Add(this.kitapEkle);
            this.Name = "kitapFormu";
            this.Text = "kitapFormu";
            this.Load += new System.EventHandler(this.kitapFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kitapGüncelle;
        private System.Windows.Forms.Button kitapSil;
        private System.Windows.Forms.Button kitapEkle;
        private System.Windows.Forms.TextBox kitapadettextBox;
        private System.Windows.Forms.Label kitapadetlabel;
        private System.Windows.Forms.TextBox kitapyayinevitextBox;
        private System.Windows.Forms.Label kitapyayinevilabel;
        private System.Windows.Forms.TextBox kitapyazartextBox;
        private System.Windows.Forms.Label kitapyazarlabel;
        private System.Windows.Forms.TextBox kitapadtextBox;
        private System.Windows.Forms.Label kitapadlabel;
        private System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.Button buttonDosyadanOkuKitap;
        private System.Windows.Forms.Button buttonDosyaKaydetKitap;
        private System.Windows.Forms.Button btn_degisiklik_kaydet;
    }
}