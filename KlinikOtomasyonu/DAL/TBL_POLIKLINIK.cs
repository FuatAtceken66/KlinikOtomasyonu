using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikOtomasyonu.DAL
{
    public class TBL_POLIKLINIK
    {
        public int ID { get; set; }
        public string POLIKLINIK { get; set; }
        public bool? GECERLIMI { get; set; }
    }

}
