using System;

namespace KutuphaneOtomasyonuWinForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personeladbuton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parolagirisbuton = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelgirisbuton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personeladbuton
            // 
            this.personeladbuton.Location = new System.Drawing.Point(281, 247);
            this.personeladbuton.Name = "personeladbuton";
            this.personeladbuton.Size = new System.Drawing.Size(156, 22);
            this.personeladbuton.TabIndex = 0;
            this.personeladbuton.TextChanged += new System.EventHandler(this.personeladbuton_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // parolagirisbuton
            // 
            this.parolagirisbuton.Location = new System.Drawing.Point(281, 280);
            this.parolagirisbuton.Name = "parolagirisbuton";
            this.parolagirisbuton.Size = new System.Drawing.Size(156, 22);
            this.parolagirisbuton.TabIndex = 2;
            this.parolagirisbuton.TextChanged += new System.EventHandler(this.parolagirisbuton_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // personelgirisbuton
            // 
            this.personelgirisbuton.BackColor = System.Drawing.SystemColors.Info;
            this.personelgirisbuton.Location = new System.Drawing.Point(281, 323);
            this.personelgirisbuton.Name = "personelgirisbuton";
            this.personelgirisbuton.Size = new System.Drawing.Size(121, 23);
            this.personelgirisbuton.TabIndex = 4;
            this.personelgirisbuton.Text = "Giriş";
            this.personelgirisbuton.UseVisualStyleBackColor = false;
            this.personelgirisbuton.Click += new System.EventHandler(this.personelgirisbuton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personelgirisbuton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parolagirisbuton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personeladbuton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void parolagirisbuton_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void personeladbuton_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TextBox personeladbuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parolagirisbuton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button personelgirisbuton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

