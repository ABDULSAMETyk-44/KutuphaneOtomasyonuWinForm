namespace KutuphaneOtomasyonuWinForm
{
    partial class emanetFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetFormu));
            this.emanetSüresiUzat = new System.Windows.Forms.Button();
            this.emanetGüncelle = new System.Windows.Forms.Button();
            this.emanetSil = new System.Windows.Forms.Button();
            this.emanetEkle = new System.Windows.Forms.Button();
            this.emanet_tc_textBox = new System.Windows.Forms.TextBox();
            this.emanet_tc_label = new System.Windows.Forms.Label();
            this.emanet_tel_no_textBox = new System.Windows.Forms.TextBox();
            this.emanet_tel_no_label = new System.Windows.Forms.Label();
            this.emanetalankisitextBox = new System.Windows.Forms.TextBox();
            this.emanetalankisilabel = new System.Windows.Forms.Label();
            this.emanetkitapaditextBox = new System.Windows.Forms.TextBox();
            this.emanetkitapadilabel = new System.Windows.Forms.Label();
            this.buttonDosyaKaydetEmanet = new System.Windows.Forms.Button();
            this.buttonDosyadanOkuEmanet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emanetSüresiUzat
            // 
            this.emanetSüresiUzat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emanetSüresiUzat.BackgroundImage")));
            this.emanetSüresiUzat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanetSüresiUzat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetSüresiUzat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.emanetSüresiUzat.Location = new System.Drawing.Point(12, 126);
            this.emanetSüresiUzat.Name = "emanetSüresiUzat";
            this.emanetSüresiUzat.Size = new System.Drawing.Size(209, 32);
            this.emanetSüresiUzat.TabIndex = 17;
            this.emanetSüresiUzat.Text = "Süresini Uzat";
            this.emanetSüresiUzat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.emanetSüresiUzat.UseVisualStyleBackColor = true;
            // 
            // emanetGüncelle
            // 
            this.emanetGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emanetGüncelle.BackgroundImage")));
            this.emanetGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanetGüncelle.Location = new System.Drawing.Point(12, 88);
            this.emanetGüncelle.Name = "emanetGüncelle";
            this.emanetGüncelle.Size = new System.Drawing.Size(209, 32);
            this.emanetGüncelle.TabIndex = 16;
            this.emanetGüncelle.Text = "Güncelle";
            this.emanetGüncelle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.emanetGüncelle.UseVisualStyleBackColor = true;
            // 
            // emanetSil
            // 
            this.emanetSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emanetSil.BackgroundImage")));
            this.emanetSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanetSil.Location = new System.Drawing.Point(12, 50);
            this.emanetSil.Name = "emanetSil";
            this.emanetSil.Size = new System.Drawing.Size(209, 32);
            this.emanetSil.TabIndex = 15;
            this.emanetSil.Text = "Sil";
            this.emanetSil.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.emanetSil.UseVisualStyleBackColor = true;
            // 
            // emanetEkle
            // 
            this.emanetEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emanetEkle.BackgroundImage")));
            this.emanetEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanetEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetEkle.Location = new System.Drawing.Point(12, 12);
            this.emanetEkle.Name = "emanetEkle";
            this.emanetEkle.Size = new System.Drawing.Size(209, 32);
            this.emanetEkle.TabIndex = 14;
            this.emanetEkle.Text = "Ekle ";
            this.emanetEkle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.emanetEkle.UseVisualStyleBackColor = true;
            this.emanetEkle.Click += new System.EventHandler(this.emanetEkle_Click);
            // 
            // emanet_tc_textBox
            // 
            this.emanet_tc_textBox.Location = new System.Drawing.Point(64, 409);
            this.emanet_tc_textBox.Name = "emanet_tc_textBox";
            this.emanet_tc_textBox.Size = new System.Drawing.Size(100, 22);
            this.emanet_tc_textBox.TabIndex = 31;
            // 
            // emanet_tc_label
            // 
            this.emanet_tc_label.AutoSize = true;
            this.emanet_tc_label.Location = new System.Drawing.Point(74, 390);
            this.emanet_tc_label.Name = "emanet_tc_label";
            this.emanet_tc_label.Size = new System.Drawing.Size(90, 16);
            this.emanet_tc_label.TabIndex = 30;
            this.emanet_tc_label.Text = "T.C. Kimlik No";
            // 
            // emanet_tel_no_textBox
            // 
            this.emanet_tel_no_textBox.Location = new System.Drawing.Point(64, 365);
            this.emanet_tel_no_textBox.Name = "emanet_tel_no_textBox";
            this.emanet_tel_no_textBox.Size = new System.Drawing.Size(100, 22);
            this.emanet_tel_no_textBox.TabIndex = 29;
            // 
            // emanet_tel_no_label
            // 
            this.emanet_tel_no_label.AutoSize = true;
            this.emanet_tel_no_label.Location = new System.Drawing.Point(84, 346);
            this.emanet_tel_no_label.Name = "emanet_tel_no_label";
            this.emanet_tel_no_label.Size = new System.Drawing.Size(74, 16);
            this.emanet_tel_no_label.TabIndex = 28;
            this.emanet_tel_no_label.Text = "Telefon No";
            // 
            // emanetalankisitextBox
            // 
            this.emanetalankisitextBox.Location = new System.Drawing.Point(64, 321);
            this.emanetalankisitextBox.Name = "emanetalankisitextBox";
            this.emanetalankisitextBox.Size = new System.Drawing.Size(100, 22);
            this.emanetalankisitextBox.TabIndex = 27;
            // 
            // emanetalankisilabel
            // 
            this.emanetalankisilabel.AutoSize = true;
            this.emanetalankisilabel.Location = new System.Drawing.Point(86, 302);
            this.emanetalankisilabel.Name = "emanetalankisilabel";
            this.emanetalankisilabel.Size = new System.Drawing.Size(58, 16);
            this.emanetalankisilabel.TabIndex = 26;
            this.emanetalankisilabel.Text = "Alan Kişi";
            // 
            // emanetkitapaditextBox
            // 
            this.emanetkitapaditextBox.Location = new System.Drawing.Point(64, 277);
            this.emanetkitapaditextBox.Name = "emanetkitapaditextBox";
            this.emanetkitapaditextBox.Size = new System.Drawing.Size(100, 22);
            this.emanetkitapaditextBox.TabIndex = 25;
            this.emanetkitapaditextBox.TextChanged += new System.EventHandler(this.emanetkitapaditextBox_TextChanged);
            // 
            // emanetkitapadilabel
            // 
            this.emanetkitapadilabel.AutoSize = true;
            this.emanetkitapadilabel.Location = new System.Drawing.Point(84, 258);
            this.emanetkitapadilabel.Name = "emanetkitapadilabel";
            this.emanetkitapadilabel.Size = new System.Drawing.Size(60, 16);
            this.emanetkitapadilabel.TabIndex = 24;
            this.emanetkitapadilabel.Text = "Kitap Adı";
            // 
            // buttonDosyaKaydetEmanet
            // 
            this.buttonDosyaKaydetEmanet.Location = new System.Drawing.Point(12, 181);
            this.buttonDosyaKaydetEmanet.Name = "buttonDosyaKaydetEmanet";
            this.buttonDosyaKaydetEmanet.Size = new System.Drawing.Size(209, 23);
            this.buttonDosyaKaydetEmanet.TabIndex = 33;
            this.buttonDosyaKaydetEmanet.Text = "Dosya Kaydet";
            this.buttonDosyaKaydetEmanet.UseVisualStyleBackColor = true;
            this.buttonDosyaKaydetEmanet.Click += new System.EventHandler(this.buttonDosyaKaydetEmanet_Click);
            // 
            // buttonDosyadanOkuEmanet
            // 
            this.buttonDosyadanOkuEmanet.Location = new System.Drawing.Point(12, 219);
            this.buttonDosyadanOkuEmanet.Name = "buttonDosyadanOkuEmanet";
            this.buttonDosyadanOkuEmanet.Size = new System.Drawing.Size(209, 23);
            this.buttonDosyadanOkuEmanet.TabIndex = 32;
            this.buttonDosyadanOkuEmanet.Text = "Dosyadan Oku";
            this.buttonDosyadanOkuEmanet.UseVisualStyleBackColor = true;
            this.buttonDosyadanOkuEmanet.Click += new System.EventHandler(this.buttonDosyadanOkuEmanet_Click);
            // 
            // emanetFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDosyaKaydetEmanet);
            this.Controls.Add(this.buttonDosyadanOkuEmanet);
            this.Controls.Add(this.emanet_tc_textBox);
            this.Controls.Add(this.emanet_tc_label);
            this.Controls.Add(this.emanet_tel_no_textBox);
            this.Controls.Add(this.emanet_tel_no_label);
            this.Controls.Add(this.emanetalankisitextBox);
            this.Controls.Add(this.emanetalankisilabel);
            this.Controls.Add(this.emanetkitapaditextBox);
            this.Controls.Add(this.emanetkitapadilabel);
            this.Controls.Add(this.emanetSüresiUzat);
            this.Controls.Add(this.emanetGüncelle);
            this.Controls.Add(this.emanetSil);
            this.Controls.Add(this.emanetEkle);
            this.Name = "emanetFormu";
            this.Text = "emanetFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emanetSüresiUzat;
        private System.Windows.Forms.Button emanetGüncelle;
        private System.Windows.Forms.Button emanetSil;
        private System.Windows.Forms.Button emanetEkle;
        private System.Windows.Forms.TextBox emanet_tc_textBox;
        private System.Windows.Forms.Label emanet_tc_label;
        private System.Windows.Forms.TextBox emanet_tel_no_textBox;
        private System.Windows.Forms.Label emanet_tel_no_label;
        private System.Windows.Forms.TextBox emanetalankisitextBox;
        private System.Windows.Forms.Label emanetalankisilabel;
        private System.Windows.Forms.TextBox emanetkitapaditextBox;
        private System.Windows.Forms.Label emanetkitapadilabel;
        private System.Windows.Forms.Button buttonDosyaKaydetEmanet;
        private System.Windows.Forms.Button buttonDosyadanOkuEmanet;
    }
}