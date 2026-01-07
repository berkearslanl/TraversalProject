using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda2
    {
        [Key]
        public int Hakkimizda2ID { get; set; }
        public string Baslik1 { get; set; }
        public string Baslik2 { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
    }
}
