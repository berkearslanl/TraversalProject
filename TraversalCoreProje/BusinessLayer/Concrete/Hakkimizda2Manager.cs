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
    public class Hakkimizda2Manager:IHakkimizda2Service
    {
        IHakkimizda2Dal _hakkimizda2Dal;

        public Hakkimizda2Manager(IHakkimizda2Dal hakkimizda2Dal)
        {
            _hakkimizda2Dal = hakkimizda2Dal;
        }

        public void TEkle(Hakkimizda2 t)
        {
            _hakkimizda2Dal.Ekle(t);
        }

        public Hakkimizda2 TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Hakkimizda2 t)
        {
            _hakkimizda2Dal.Guncelle(t);
        }

        public Hakkimizda2 TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hakkimizda2> TListele()
        {
            return _hakkimizda2Dal.Listele();
        }

        public void TSil(Hakkimizda2 t)
        {
            _hakkimizda2Dal.Sil(t);
        }
    }
}
