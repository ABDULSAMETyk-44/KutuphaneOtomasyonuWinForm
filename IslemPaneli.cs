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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void kullanicilarButonu_Click(object sender, EventArgs e)
        {
            kullanıcıFormu kullanıcıPanel=new kullanıcıFormu();
            kullanıcıPanel.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            emanetFormu emanetPanel = new emanetFormu();
            emanetPanel.ShowDialog();
        }

        private void kitapButton_Click(object sender, EventArgs e)
        {
            kitapFormu kitapPanel =new kitapFormu();
            kitapPanel.ShowDialog();
        }
    }
}
