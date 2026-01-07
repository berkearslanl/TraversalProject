using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.Dtos.DuyurularDtos
{
    public class DuyurularUpdateDto
    {
        public int DuyurularId { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public DateTime Tarih { get; set; }
    }
}
