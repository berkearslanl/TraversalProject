using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rehberler
    {
        [Key]
        public int RehberID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Sosyal1 { get; set; }
        public string Sosyal2 { get; set; }
        public string AciklamaDetay { get; set; }
        public bool Durum { get; set; }

        public List<VarisNoktalari> VarisNoktalaris { get; set; }
    }
}
