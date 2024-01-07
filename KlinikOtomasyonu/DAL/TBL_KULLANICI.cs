using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikOtomasyonu.DAL
{
    public class TBL_KULLANICI
    {
        public int ID { get; set; }
        public string KULLANICI_KODU { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
    }
}
