using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public string KisiSayisi { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }

        //varis noktasi ile ilişki
        public int VarisNoktasiID { get; set; }
        [ForeignKey("VarisNoktasiID")]
        public VarisNoktalari varisNoktalari { get; set; }

    }
}
