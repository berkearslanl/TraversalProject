using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AltHakkimizda
    {
        [Key]
        public int AltHakkimizdaID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}
