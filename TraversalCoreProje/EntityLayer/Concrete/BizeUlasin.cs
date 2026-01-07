using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BizeUlasin
    {
        public int bizeUlasinID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string icerik { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
    }
}
