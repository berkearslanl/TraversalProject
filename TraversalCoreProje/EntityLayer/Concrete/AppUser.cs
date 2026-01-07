using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string ResimUrl { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string instagram { get; set; }
        public string github { get; set; }
        public string linkedin { get; set; }
        public string Cinsiyet { get; set; }
        public List<Rezervasyon> rezervasyons { get; set; }
        public List<Yorumlar> yorumlars { get; set; }
    }
}
