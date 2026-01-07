using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.Dtos.RotalarDtos
{
    public class RotalarAddDto
    {
        public string Sehir { get; set; }
        public string GeceGunduz { get; set; }
        public double Fiyat { get; set; }
        public int Kapasite { get; set; }
    }
}
