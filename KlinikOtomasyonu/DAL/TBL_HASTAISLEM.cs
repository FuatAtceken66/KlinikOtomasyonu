using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikOtomasyonu.DAL
{
    public class TBL_HASTAISLEM
    {
        public int ID { get; set; }
        public int? HASTA_ID { get; set; }
        public string POLIKLINIK { get; set; }
        public int? SIRA_NO { get; set; }
        public string YAPILAN_ISLEM { get; set; }
        public string DOKTOR_KODU { get; set; }
        public decimal? MIKTAR { get; set; }
        public decimal? BIRIM_FIYAT { get; set; }
    }

}
