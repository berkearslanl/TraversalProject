using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Referanslar
    {
        [Key]
        public int ReferansID { get; set; }
        public string Kullanici { get; set; }
        public string Yorum { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
