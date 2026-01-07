using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class VarisNoktalari
    {
        [Key]
        public int VarisNoktasiID { get; set; }
        public string Sehir { get; set; }
        public string GeceGunduz { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public int Kapasite { get; set; }
        public bool Durum { get; set; }
        public string KapakResim { get; set; }
        public string DetayAciklama1 { get; set; }
        public string DetayAciklama2 { get; set; }
        public string Resim2 { get; set; }
        public DateTime Tarih { get; set; }

        //yorumlar ile ilişki
        public List<Yorumlar> Yorumlars { get; set; }

        //rezervasyon ile ilişki
        public List<Rezervasyon> Rezervasyons { get; set; }

        public int? RehberID { get; set; }
        [ForeignKey("RehberID")]
        public Rehberler Rehberler { get; set; }
    }
}
