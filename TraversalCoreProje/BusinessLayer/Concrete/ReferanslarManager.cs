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
    public class ReferanslarManager:IReferanslarService
    {
        IReferanslarDal _referanslarDal;

        public ReferanslarManager(IReferanslarDal referanslarDal)
        {
            _referanslarDal = referanslarDal;
        }

        public void TEkle(Referanslar t)
        {
            _referanslarDal.Ekle(t);
        }

        public Referanslar TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Referanslar t)
        {
            _referanslarDal.Guncelle(t);
        }

        public Referanslar TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Referanslar> TListele()
        {
            return _referanslarDal.Listele();
        }

        public void TSil(Referanslar t)
        {
            _referanslarDal.Sil(t);
        }
    }
}
