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
        public DataTable dtEmanet;

        Form1 form =new Form1();
        public IslemPaneli()
        {
            InitializeComponent();
        }
        public IslemPaneli(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            dtEmanet = new DataTable();
            dtEmanet.Columns.Add("Kitap Adı");
            dtEmanet.Columns.Add("Alan Kişi");
            dtEmanet.Columns.Add("Telefon No");
            dtEmanet.Columns.Add("TC");

            dgvEmanet.DataSource = dtEmanet;
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
            emanetFormu emanetPanel = new emanetFormu(this);
            emanetPanel.ShowDialog();
        }

        private void kitapButton_Click(object sender, EventArgs e)
        {
            kitapFormu kitapPanel =new kitapFormu();
            kitapPanel.ShowDialog();
        }

        private void butonLogOut_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
