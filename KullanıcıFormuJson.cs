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
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TcKimlikNo { get; set; }
        public string Telefon { get; set; }

        public void tabloyaEkle(DataTable dtKisiler)
        {
        
            DataRow newRow = dtKisiler.NewRow();
            newRow["ID"] = Id.ToString();
            newRow["İsim"] = Isim;
            newRow["Soyisim"] = Soyisim;    
            newRow["TC"] = TcKimlikNo;
            newRow["Telefon"] = Telefon;
            dtKisiler.Rows.Add(newRow);

        }
    }
}
