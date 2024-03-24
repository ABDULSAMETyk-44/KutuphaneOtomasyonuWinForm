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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 387);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adet";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Yayınevi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yazar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kitap Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 354);
            this.dataGridView1.TabIndex = 24;
            // 
            // kitapFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitapGüncelle);
            this.Controls.Add(this.kitapSil);
            this.Controls.Add(this.kitapEkle);
            this.Name = "kitapFormu";
            this.Text = "kitapFormu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kitapGüncelle;
        private System.Windows.Forms.Button kitapSil;
        private System.Windows.Forms.Button kitapEkle;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}