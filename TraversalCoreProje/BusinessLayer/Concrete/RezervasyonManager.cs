using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RezervasyonManager:IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public List<Rezervasyon> gecmisRezervasyonListesi(int id)
        {
            return _rezervasyonDal.gecmisRezervasyonListesi(id);
        }

        public List<Rezervasyon> kabulEdilenRezervasyonListesi(int id)
        {
            return _rezervasyonDal.kabulEdilenRezervasyonListesi(id);
        }

        public List<Rezervasyon> onayBekleyenRezervasyonListesi(int id)
        {
            return _rezervasyonDal.onayBekleyenRezervasyonListesi(id);
        }

        public void TEkle(Rezervasyon t)
        {
            _rezervasyonDal.Ekle(t);
        }

        public Rezervasyon TGetir(int id)
        {
            return _rezervasyonDal.getir(x=>x.AppUserID==id);
        }

        public void TGuncelle(Rezervasyon t)
        {
            _rezervasyonDal.Guncelle(t);
        }

        public Rezervasyon TIdyeGoreGetir(int id)
        {
            return _rezervasyonDal.idyeGoreGetir(id);
        }

        public List<Rezervasyon> TListele()
        {
            return _rezervasyonDal.Listele();
        }

        public void TSil(Rezervasyon t)
        {
            _rezervasyonDal.Sil(t);
        }
    }
}
