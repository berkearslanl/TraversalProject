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
    public class iletisimManager:IiletisimService
    {
        IiletisimDal _iletisimDal;

        public iletisimManager(IiletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public void TEkle(iletisim t)
        {
            _iletisimDal.Ekle(t);
        }

        public iletisim TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(iletisim t)
        {
            _iletisimDal.Guncelle(t);
        }

        public iletisim TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<iletisim> TListele()
        {
            return _iletisimDal.Listele();
        }

        public void TSil(iletisim t)
        {
            _iletisimDal.Sil(t);
        }
    }
}
