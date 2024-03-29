using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;
using Newtonsoft.Json;


namespace KutuphaneOtomasyonuWinForm
{
    public partial class kitapFormu : Form
    {
        DataTable dtKitap;
        
        
        public kitapFormu()
        {
            InitializeComponent();

            dtKitap = new DataTable();
            dtKitap.Columns.Add("Kitap Adı");
            dtKitap.Columns.Add("Yayınevi");
            dtKitap.Columns.Add("isim");           
            dtKitap.Columns.Add("Yazar");
            
            dgvKitap.DataSource = dtKitap;
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            KitapFormJson nesne = new KitapFormJson();
            nesne.KitapAdi = kitapadtextBox.Text;
            nesne.Yazar = kitapyazartextBox.Text;
            nesne.Yayinevi = kitapyayinevitextBox.Text;
            nesne.Adet = Convert.ToInt32(kitapadettextBox.Text);

            KitapFormJson.kitaplar.Add(nesne);
            dgvKitap.DataSource = dtKitap;

        }

        private void kitapadtextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonDosyaKaydetKitap_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonConvert.SerializeObject(KitapFormJson.kitaplar);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void kitapFormu_Load(object sender, EventArgs e)
        {

        }

        private void buttonDosyadanOkuKitap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                KitapFormJson.kitaplar = JsonConvert.DeserializeObject<List<KitapFormJson>>(data);
                foreach (var kitap in KitapFormJson.kitaplar)
                {
                kitap.tabloyaEkle(dtKitap);
                }
            }
        }
    }
}
