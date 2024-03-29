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
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.butonLogOut = new System.Windows.Forms.Button();
            this.emanetButton = new System.Windows.Forms.Button();
            this.kitapButton = new System.Windows.Forms.Button();
            this.kullanicilarButonu = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.dgvEmanet = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Controls.Add(this.searchButton);
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
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(83, 551);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(100, 22);
            this.searchtextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(12, 538);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(64, 49);
            this.searchButton.TabIndex = 1;
            this.searchButton.UseVisualStyleBackColor = true;
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
            this.butonLogOut.Click += new System.EventHandler(this.butonLogOut_Click);
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
            // dgvEmanet
            // 
            this.dgvEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanet.Location = new System.Drawing.Point(248, 60);
            this.dgvEmanet.Name = "dgvEmanet";
            this.dgvEmanet.RowHeadersWidth = 51;
            this.dgvEmanet.RowTemplate.Height = 24;
            this.dgvEmanet.Size = new System.Drawing.Size(518, 354);
            this.dgvEmanet.TabIndex = 33;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.dgvEmanet);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button kullanicilarButonu;
        private System.Windows.Forms.Button butonLogOut;
        private System.Windows.Forms.Button emanetButton;
        private System.Windows.Forms.Button kitapButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dgvEmanet;
    }
}