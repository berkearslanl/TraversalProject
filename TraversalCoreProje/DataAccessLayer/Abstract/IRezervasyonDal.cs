using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRezervasyonDal:IGenericDal<Rezervasyon>
    {
        List<Rezervasyon> onayBekleyenRezervasyonListesi(int id);
        List<Rezervasyon> kabulEdilenRezervasyonListesi(int id);
        List<Rezervasyon> gecmisRezervasyonListesi(int id);
    }
}
