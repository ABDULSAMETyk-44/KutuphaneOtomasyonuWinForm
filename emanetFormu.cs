using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace KutuphaneOtomasyonuWinForm
{
    public partial class emanetFormu : Form
    {
        IslemPaneli nesne = new IslemPaneli();
        public emanetFormu()
        {
            InitializeComponent();
        }
        public emanetFormu(IslemPaneli nesne)
        {
            this.nesne = nesne;
            InitializeComponent();
        }
        private void emanetkitapaditextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emanetEkle_Click(object sender, EventArgs e)
        {
            EmanetFormuJson nesne = new EmanetFormuJson();
            nesne.KitapAdi = emanetkitapaditextBox.Text;
            nesne.AlanKisi = emanetalankisitextBox.Text;
            nesne.TelefonNo = Convert.ToInt32(emanet_tel_no_textBox.Text);
            nesne.TcKimlikNo = Convert.ToInt32(emanet_tc_textBox.Text);

            EmanetFormuJson.emanetler.Add(nesne);

        }

        private void buttonDosyaKaydetEmanet_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonConvert.SerializeObject(EmanetFormuJson.emanetler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void buttonDosyadanOkuEmanet_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                EmanetFormuJson.emanetler = JsonConvert.DeserializeObject<List<EmanetFormuJson>>(data);
                foreach (var emanet in EmanetFormuJson.emanetler)
                {
                    emanet.tabloyaEkle(nesne.dtEmanet);
                }
            }
        }
    }
}
