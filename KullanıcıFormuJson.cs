using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonuWinForm
{
    public class KullanıcıFormuJson
    {
        public static List<KullanıcıFormuJson> uyeler = new List<KullanıcıFormuJson>();

        private string _isim;
        private string _soyisim;
        private int _tcKimlikNo;
        private int _telefon;

        public string Isim { get { return _isim; } set { _isim = value; } }
        public string Soyisim { get { return _soyisim; } set { _soyisim = value; } }
        public int TcKimlikNo { get { return _tcKimlikNo; } set { _tcKimlikNo = value; } }
        public int Telefon { get { return _telefon; } set { _telefon = value; } }
       

        public void tabloyaEkle(DataTable tablo)
        {
            tablo.Rows.Add(new object[] {_isim, _soyisim, _tcKimlikNo, _telefon });
        }
    }
}
