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
    public class HakkimizdaManager:IHakkimizdaService
    {
        IHakkimizdaDal _hakkimizdaDal;

        public HakkimizdaManager(IHakkimizdaDal hakkimizdaDal)
        {
            _hakkimizdaDal = hakkimizdaDal;
        }

        public void TEkle(Hakkimizda t)
        {
            _hakkimizdaDal.Ekle(t);
        }

        public Hakkimizda TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Hakkimizda t)
        {
            _hakkimizdaDal.Guncelle(t);
        }

        public Hakkimizda TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hakkimizda> TListele()
        {
            return _hakkimizdaDal.Listele();
        }

        public void TSil(Hakkimizda t)
        {
            _hakkimizdaDal.Sil(t);
        }
    }
}
