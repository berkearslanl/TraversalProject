using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfRezervasyonDal : GenericRepository<Rezervasyon>, IRezervasyonDal
    {
        public List<Rezervasyon> gecmisRezervasyonListesi(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervasyons.Include(x => x.varisNoktalari).Include(x=>x.AppUser).Where(x => x.Durum == "Geçmiş rezervasyon" && x.AppUserID == id).ToList();
            }
        }

        public List<Rezervasyon> kabulEdilenRezervasyonListesi(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervasyons.Include(x => x.varisNoktalari).Include(x => x.AppUser).Where(x => x.Durum == "Onaylandı" && x.AppUserID == id).ToList();
            }
        }

        public List<Rezervasyon> onayBekleyenRezervasyonListesi(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervasyons.Include(x => x.varisNoktalari).Include(x => x.AppUser).Where(x => x.Durum == "Onay bekliyor" && x.AppUserID==id).ToList();
            }
        }
    }
}
