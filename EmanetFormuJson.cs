using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonuWinForm
{
    public class EmanetFormuJson
    {
        public static List<EmanetFormuJson> emanetler = new List<EmanetFormuJson>();

        private string _kitapAdi;
        private string _alanKisi;
        private int _tcKimlikNo;
        private int _telefonNo;

        public string KitapAdi { get { return _kitapAdi; } set { _kitapAdi = value; } }
        public string AlanKisi { get { return _alanKisi; } set { _alanKisi = value; } }
        public int TelefonNo { get { return _telefonNo; } set { _telefonNo = value; } }
        public int TcKimlikNo { get { return _tcKimlikNo; } set { _tcKimlikNo = value; } }

        public void tabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {_kitapAdi, _alanKisi, _tcKimlikNo, _telefonNo });

        }
    }
}
