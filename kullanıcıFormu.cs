using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class kullanıcıFormu : Form
    {
        DataTable dtKisiler;

        public kullanıcıFormu()
        {
            InitializeComponent();
            dtKisiler = new DataTable();

            dtKisiler.Columns.Add("İsim");
            dtKisiler.Columns.Add("Soyisim");
            dtKisiler.Columns.Add("TC");
            dtKisiler.Columns.Add("Telefon");

            dgvKisiler.DataSource = dtKisiler;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ekleKullanici_Click(object sender, EventArgs e)
        {
            KullanıcıFormuJson nesne=new KullanıcıFormuJson();
            nesne.Isim = kullanıcıisimtextBox.Text;
            nesne.Soyisim = kullanıcısoyisimtextBox.Text;
            nesne.TcKimlikNo = Convert.ToInt32(kullanıcı_tel_no_textBox.Text);
            nesne.Telefon=Convert.ToInt32(kullanıcı_tel_no_textBox.Text);

            KullanıcıFormuJson.uyeler.Add( nesne );
        }

        private void kullanıcıisimtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDosyaEkleKullanıcı_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonConvert.SerializeObject(KullanıcıFormuJson.uyeler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void buttonDosyadanOkuKullanıcı_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                KullanıcıFormuJson.uyeler = JsonConvert.DeserializeObject<List<KullanıcıFormuJson>>(data);
                foreach (var kitap in KullanıcıFormuJson.uyeler)
                {
                    kitap.tabloyaEkle(dtKisiler);
                }
            }
        }
    }
}
