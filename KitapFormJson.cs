using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonuWinForm
{
    public class KitapFormJson
    {
            public static List<KitapFormJson> kitaplar = new List<KitapFormJson>();
            private string _kitapadi;
            private string _yazar;
            private string _yayinevi;
            private int _adet;

            public string KitapAdi { get { return _kitapadi; } set { _kitapadi = value; } }
            public string Yazar { get { return _yazar; } set { _yazar = value; } }
            public string Yayinevi { get { return _yayinevi; } set { _yayinevi = value; } }
            public int Adet { get { return _adet; } set { _adet = value; } }

            public KitapFormJson() { }

            public void tabloyaEkle(DataTable tablo)
            {
                tablo.Rows.Add(new object[] { _kitapadi, _yazar, _yayinevi, _adet });
            }
        }
}
