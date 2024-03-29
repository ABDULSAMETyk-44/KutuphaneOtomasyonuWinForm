using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelgirisbuton_Click(object sender, EventArgs e)
        {
            //string gelenAd=personeladbuton.Text;
            //string gelenSifre=parolagirisbuton.Text;

            // linq sorgusu
            //var personel= db.Personeller.Where(x=> x.personel_ad.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            //if (personel == null)
            //{
            //    MessageBox.Show(text: "KULLANICI ADI VEYA ŞİFRE HATALI!");
            //}
            //else
            //{
            //    MessageBox.Show(text: "GİRİŞ BAŞARILI");
            //    IslemPaneli Panel = new IslemPaneli();
            //    Panel.Show();
            //    this.Hide();

            //}
            IslemPaneli Panel = new IslemPaneli(this);
            Panel.Show();
            this.Hide();


        }

       
    }
}
