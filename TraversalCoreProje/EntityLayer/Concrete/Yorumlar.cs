using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorumlar
    {
        [Key]
        public int YorumId { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime Tarih { get; set; }
        public string Yorum { get; set; }
        public bool Durum { get; set; }

        //rotalar ile ilişki
        public int VarisNoktasiID { get; set; }
        [ForeignKey("VarisNoktasiID")]
        public VarisNoktalari VarisNoktalari { get; set; }

        //kullanıcılar ile ilişki

        public int AppUserID { get; set; }
        [ForeignKey("AppUserID")]
        public AppUser AppUser { get; set; }
    }
}
