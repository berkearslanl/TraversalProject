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
    public class AltHakkimizdaManager:IAltHakkimizdaService
    {
        IAltHakkimizdaDal _altHakkimizdaDal;

        public AltHakkimizdaManager(IAltHakkimizdaDal altHakkimizdaDal)
        {
            _altHakkimizdaDal = altHakkimizdaDal;
        }

        public void TEkle(AltHakkimizda t)
        {
            _altHakkimizdaDal.Ekle(t);
        }

        public AltHakkimizda TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(AltHakkimizda t)
        {
            _altHakkimizdaDal.Guncelle(t);
        }

        public AltHakkimizda TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<AltHakkimizda> TListele()
        {
            return _altHakkimizdaDal.Listele();
        }

        public void TSil(AltHakkimizda t)
        {
            _altHakkimizdaDal.Sil(t);
        }
    }
}
