using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
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
        DataTable dtKitap = new DataTable();
        List<KitapFormJson> kitapListesi = new List<KitapFormJson>();
        private int Id = 0;
        private int idFlag = -1;
        
        
        public kitapFormu()
        {
            InitializeComponent();
            dtKitap.Columns.Add("ID");
            dtKitap.Columns.Add("Kitap Adı");
            dtKitap.Columns.Add("Yayınevi");
            dtKitap.Columns.Add("isim");           
            dtKitap.Columns.Add("Yazar");
            dtKitap.Columns.Add("Adet");
            
            dgvKitap.DataSource = dtKitap;

        }

        private void HandleResetForİnputs()
        {
            kitapadtextBox.Text = "";
            kitapyazartextBox.Text = "";
            kitapyayinevitextBox.Text = "";
            kitapadettextBox.Text = "";
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            KitapFormJson nesne = new KitapFormJson();
            nesne.KitapAdi = kitapadtextBox.Text;
            nesne.ID = ++Id;
            nesne.Yazar = kitapyazartextBox.Text;
            nesne.Yayinevi = kitapyayinevitextBox.Text;
            nesne.Adet = Convert.ToInt32(kitapadettextBox.Text);
            nesne.tabloyaEkle(dtKitap);
            kitapListesi.Add(nesne);
            HandleResetForİnputs();
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

        private void kitapSil_Click(object sender, EventArgs e)
        {
            if (dgvKitap.SelectedRows.Count > 0)
            {
                string selectedId = dgvKitap.SelectedRows[0].Cells["ID"].Value.ToString();
                int rowIndex = -1;
                foreach (DataRow row in dtKitap.Rows)
                {
                    if (row["ID"].ToString() == selectedId)
                    {
                        rowIndex = row.Table.Rows.IndexOf(row);
                        break;
                    }
                }
                if (rowIndex != -1)
                {
                    dgvKitap.Rows.RemoveAt(rowIndex);
                    int index = kitapListesi.FindIndex(kitap => kitap.ID == Convert.ToInt32(selectedId));
                    kitapListesi.RemoveAt(index);

                    string yazilacak = JsonConvert.SerializeObject(kitapListesi);

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "JSon Dosyası|*.json";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {

                        string dosyaYolu = dialog.FileName;
                        File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

                    }
                }

                dtKitap.AcceptChanges();

            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void kitapGüncelle_Click(object sender, EventArgs e)
        {
            if (dgvKitap.SelectedRows.Count > 0)
            {
                btn_degisiklik_kaydet.Visible= true;
                kitapEkle.Visible = false;
                string selectedId = dgvKitap.SelectedRows[0].Cells["ID"].Value.ToString();
                int index = kitapListesi.FindIndex(kitap => kitap.ID == Convert.ToInt32(selectedId));
                KitapFormJson eskiKitap = kitapListesi[index];
                kitapadtextBox.Text = eskiKitap.KitapAdi;
                kitapadettextBox.Text = eskiKitap.Adet.ToString();
                kitapyayinevitextBox.Text = eskiKitap.Yayinevi;
                kitapyazartextBox.Text = eskiKitap.Yazar;
                idFlag = Convert.ToInt32(selectedId);
            }
        }

        private void btn_degisiklik_kaydet_Click(object sender, EventArgs e)
        {
            int index = kitapListesi.FindIndex(kitap => kitap.ID == Convert.ToInt32(idFlag));
            KitapFormJson yeniKitap = kitapListesi[index];
            yeniKitap.KitapAdi = kitapadtextBox.Text;
            yeniKitap.ID = idFlag;
            yeniKitap.Yazar = kitapyazartextBox.Text;
            yeniKitap.Yayinevi = kitapyayinevitextBox.Text;
            yeniKitap.Adet = Convert.ToInt32(kitapadettextBox.Text);

            DataRow row = dtKitap.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["ID"]) == idFlag);
            if (row != null)
            {
                row["ID"] = yeniKitap.ID;
                row["Kitap Adı"] = yeniKitap.KitapAdi;
                row["Yayınevi"] = yeniKitap.Yayinevi;
                row["isim"] = yeniKitap.KitapAdi;
                row["Yazar"] = yeniKitap.Yazar;
                row["Adet"] = yeniKitap.Adet;
            }

            idFlag = -1;

            // Dosyaya yazma işlemi buraya taşınabilir.

            dtKitap.AcceptChanges();
            HandleResetForİnputs();


            string yazilacak = JsonConvert.SerializeObject(kitapListesi);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
            btn_degisiklik_kaydet.Visible = false;
            kitapEkle.Visible = true;
            HandleResetForİnputs();


        }
    }
    }

