using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRezervasyonService:IGenericService<Rezervasyon>
    {
        List<Rezervasyon> onayBekleyenRezervasyonListesi(int id);
        List<Rezervasyon> gecmisRezervasyonListesi(int id);
        List<Rezervasyon> kabulEdilenRezervasyonListesi(int id);
    }
}
