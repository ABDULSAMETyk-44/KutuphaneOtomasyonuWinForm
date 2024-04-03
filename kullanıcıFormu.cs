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
        DataTable dtKisiler = new DataTable();
        List<KullanıcıFormuJson> kullanicilar;
        private int kullaniciId = 0;
        private int idFlag = -1;

        public kullanıcıFormu()
        {
            InitializeComponent();
            kullanicilar = new List<KullanıcıFormuJson>();

            dtKisiler.Columns.Add("ID");
            dtKisiler.Columns.Add("İsim");
            dtKisiler.Columns.Add("Soyisim");
            dtKisiler.Columns.Add("TC");
            dtKisiler.Columns.Add("Telefon");
            dgvKisiler.DataSource = dtKisiler;

        }


        private void HandleResetForInputs()
        {
            kullanıcıisimtextBox.Text = "";
            kullanıcısoyisimtextBox.Text = "";
            kullanıcı_tel_no_textBox.Text = "";
            kullanıcı_tc_textBox.Text = "";
        }

        private void EkleKullanici_Click(object sender, EventArgs e)
        {
            KullanıcıFormuJson nesne = new KullanıcıFormuJson();
            nesne.Id = ++kullaniciId;
            nesne.Isim = kullanıcıisimtextBox.Text;
            nesne.Soyisim = kullanıcısoyisimtextBox.Text;
            nesne.TcKimlikNo = kullanıcı_tc_textBox.Text;
            nesne.Telefon = kullanıcı_tel_no_textBox.Text;
            nesne.tabloyaEkle(dtKisiler);
            kullanicilar.Add(nesne);
            HandleResetForInputs();
        }



        private void buttonDosyaEkleKullanıcı_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonConvert.SerializeObject(kullanicilar);

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
                kullanicilar = JsonConvert.DeserializeObject<List<KullanıcıFormuJson>>(data);
                foreach (var kitap in kullanicilar)
                {
                    kitap.tabloyaEkle(dtKisiler);
                }
            }
        }

        private void silKullanici_Click(object sender, EventArgs e)
        {
            if (dgvKisiler.SelectedRows.Count > 0)
            {
                string selectedId = dgvKisiler.SelectedRows[0].Cells["ID"].Value.ToString();
                int rowIndex = -1;
                foreach (DataRow row in dtKisiler.Rows)
                {
                    if (row["ID"].ToString() == selectedId)
                    {
                        rowIndex = row.Table.Rows.IndexOf(row);
                        break;
                    }
                }
                if (rowIndex != -1)
                {
                    dtKisiler.Rows.RemoveAt(rowIndex);
                    int index = kullanicilar.FindIndex(kullanici => kullanici.Id == Convert.ToInt32(selectedId));
                    kullanicilar.RemoveAt(index);

                    string yazilacak = JsonConvert.SerializeObject(kullanicilar);

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "JSon Dosyası|*.json";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {

                        string dosyaYolu = dialog.FileName;
                        File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

                    }
                }

                dtKisiler.AcceptChanges();

            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void kisiGüncelle_Click(object sender, EventArgs e)
        {
            if (dgvKisiler.SelectedRows.Count > 0)
            {
                buttonDosyaKaydetKullanıcı.Visible = false;
                degislik_kaydet_btn.Visible = true;

                string selectedId = dgvKisiler.SelectedRows[0].Cells["ID"].Value.ToString();
                int index = kullanicilar.FindIndex(kullanici => kullanici.Id == Convert.ToInt32(selectedId));
                KullanıcıFormuJson eskiKullanici = kullanicilar[index];
                kullanıcıisimtextBox.Text = eskiKullanici.Isim;
                kullanıcısoyisimtextBox.Text = eskiKullanici.Soyisim;
                kullanıcı_tel_no_textBox.Text = eskiKullanici.Telefon;
                kullanıcı_tc_textBox.Text = eskiKullanici.TcKimlikNo;
                idFlag = Convert.ToInt32(selectedId);

            }
        }

        private void degislik_kaydet_btn_Click(object sender, EventArgs e)
        {
            int index = kullanicilar.FindIndex(kullanici => kullanici.Id == idFlag);
            KullanıcıFormuJson guncelKullanici = new KullanıcıFormuJson();
            guncelKullanici.Id = idFlag;
            guncelKullanici.Telefon = kullanıcı_tel_no_textBox.Text;
            guncelKullanici.TcKimlikNo = kullanıcı_tc_textBox.Text;
            guncelKullanici.Soyisim = kullanıcısoyisimtextBox.Text;
            guncelKullanici.Isim = kullanıcıisimtextBox.Text;
            kullanicilar[index] = guncelKullanici;

            DataRow row = dtKisiler.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["ID"]) == idFlag);
            if (row != null)
            {
                row["İsim"] = guncelKullanici.Isim;
                row["Soyisim"] = guncelKullanici.Soyisim;
                row["TC"] = guncelKullanici.TcKimlikNo;
                row["Telefon"] = guncelKullanici.Telefon;
            }

            idFlag = -1;

            // Dosyaya yazma işlemi buraya taşınabilir.

            dtKisiler.AcceptChanges();
            HandleResetForInputs();


            string yazilacak = JsonConvert.SerializeObject(kullanicilar);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
            buttonDosyaKaydetKullanıcı.Visible = true;
            degislik_kaydet_btn.Visible = false;
            HandleResetForInputs();
        }
    }
}