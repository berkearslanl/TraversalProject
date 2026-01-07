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
    public class DuyurularManager : IDuyurularService
    {

        private readonly IDuyurularDal _duyurularDal;

        public DuyurularManager(IDuyurularDal duyurularDal)
        {
            _duyurularDal = duyurularDal;
        }

        public void TEkle(Duyurular t)
        {
            _duyurularDal.Ekle(t);
        }

        public Duyurular TGetir(int id)
        {
            return _duyurularDal.getir(x => x.DuyurularID == id);
        }

        public void TGuncelle(Duyurular t)
        {
            _duyurularDal.Guncelle(t);
        }

        public Duyurular TIdyeGoreGetir(int id)
        {
            return _duyurularDal.idyeGoreGetir(id);
        }

        public List<Duyurular> TListele()
        {
            return _duyurularDal.Listele();
        }

        public void TSil(Duyurular t)
        {
            _duyurularDal.Sil(t);
        }
    }
}
