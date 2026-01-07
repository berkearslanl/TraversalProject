using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Duyurular
    {
        public int DuyurularID { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public DateTime Tarih { get; set; }
    }
}
