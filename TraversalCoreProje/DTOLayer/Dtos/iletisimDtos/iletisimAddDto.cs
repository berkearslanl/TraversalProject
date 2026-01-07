using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.Dtos.iletisimDtos
{
    public class iletisimAddDto
    {
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string icerik { get; set; }
        public DateTime Tarih { get; set; }
        public bool Durum { get; set; }
    }
}
