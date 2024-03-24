namespace KutuphaneOtomasyonuWinForm
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonLogOut = new System.Windows.Forms.Button();
            this.emanetButton = new System.Windows.Forms.Button();
            this.kitapButton = new System.Windows.Forms.Button();
            this.kullanicilarButonu = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.butonLogOut);
            this.panel1.Controls.Add(this.emanetButton);
            this.panel1.Controls.Add(this.kitapButton);
            this.panel1.Controls.Add(this.kullanicilarButonu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 650);
            this.panel1.TabIndex = 0;
            // 
            // butonLogOut
            // 
            this.butonLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonLogOut.BackgroundImage")));
            this.butonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonLogOut.Location = new System.Drawing.Point(3, 593);
            this.butonLogOut.Name = "butonLogOut";
            this.butonLogOut.Size = new System.Drawing.Size(209, 57);
            this.butonLogOut.TabIndex = 6;
            this.butonLogOut.Text = "Çıkış Yap";
            this.butonLogOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.butonLogOut.UseVisualStyleBackColor = true;
            // 
            // emanetButton
            // 
            this.emanetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emanetButton.BackgroundImage")));
            this.emanetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emanetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetButton.Location = new System.Drawing.Point(3, 150);
            this.emanetButton.Name = "emanetButton";
            this.emanetButton.Size = new System.Drawing.Size(209, 57);
            this.emanetButton.TabIndex = 5;
            this.emanetButton.Text = "Emanet";
            this.emanetButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.emanetButton.UseVisualStyleBackColor = true;
            this.emanetButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // kitapButton
            // 
            this.kitapButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kitapButton.BackgroundImage")));
            this.kitapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kitapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapButton.Location = new System.Drawing.Point(3, 76);
            this.kitapButton.Name = "kitapButton";
            this.kitapButton.Size = new System.Drawing.Size(209, 57);
            this.kitapButton.TabIndex = 4;
            this.kitapButton.Text = "Kitap";
            this.kitapButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kitapButton.UseVisualStyleBackColor = true;
            this.kitapButton.Click += new System.EventHandler(this.kitapButton_Click);
            // 
            // kullanicilarButonu
            // 
            this.kullanicilarButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullanicilarButonu.BackgroundImage")));
            this.kullanicilarButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kullanicilarButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicilarButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanicilarButonu.Location = new System.Drawing.Point(3, 3);
            this.kullanicilarButonu.Name = "kullanicilarButonu";
            this.kullanicilarButonu.Size = new System.Drawing.Size(209, 57);
            this.kullanicilarButonu.TabIndex = 0;
            this.kullanicilarButonu.Text = "Kullanıcılar";
            this.kullanicilarButonu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kullanicilarButonu.UseVisualStyleBackColor = true;
            this.kullanicilarButonu.Click += new System.EventHandler(this.kullanicilarButonu_Click);
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(215, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(585, 43);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 354);
            this.dataGridView1.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 551);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button kullanicilarButonu;
        private System.Windows.Forms.Button butonLogOut;
        private System.Windows.Forms.Button emanetButton;
        private System.Windows.Forms.Button kitapButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}