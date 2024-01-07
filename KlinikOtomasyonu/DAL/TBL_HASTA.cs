using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikOtomasyonu.DAL
{
    public class TBL_HASTA
    {
        public int ID { get; set; }
        public string DOSYA_NO { get; set; }
        public string DOKTOR { get; set; }
        public string HASTA_ADI { get; set; }
        public string HASTA_SOYADI { get; set; }
        public string HASTA_TC { get; set; }
        public string HASTA_POLIKLINIK { get; set; }
        public DateTime? HASTA_SEVKTARIHI { get; set; }
    }

}
