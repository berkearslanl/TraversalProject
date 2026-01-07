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
    public class RehberlerManager:IRehberlerService
    {
        IRehberDal _rehberDal;

        public RehberlerManager(IRehberDal rehberDal)
        {
            _rehberDal = rehberDal;
        }

        public void TEkle(Rehberler t)
        {
            _rehberDal.Ekle(t);
        }

        public Rehberler TGetir(int id)
        {
            return _rehberDal.getir(x=>x.RehberID==id);
        }

        public void TGuncelle(Rehberler t)
        {
            _rehberDal.Guncelle(t);
        }

        public Rehberler TIdyeGoreGetir(int id)
        {
            return _rehberDal.idyeGoreGetir(id);
        }

        public List<Rehberler> TListele()
        {
            return _rehberDal.Listele();
        }

        public void TSil(Rehberler t)
        {
            _rehberDal.Sil(t);
        }
    }
}
