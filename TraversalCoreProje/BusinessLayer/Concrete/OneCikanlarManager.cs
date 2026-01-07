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
    public class OneCikanlarManager:IOneCikanlarService
    {
        IOneCikanlarDal _oneCikanlarDal;

        public OneCikanlarManager(IOneCikanlarDal oneCikanlarDal)
        {
            _oneCikanlarDal = oneCikanlarDal;
        }

        public void TEkle(OneCikanlar t)
        {
            _oneCikanlarDal.Ekle(t);
        }

        public OneCikanlar TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(OneCikanlar t)
        {
            _oneCikanlarDal.Guncelle(t);
        }

        public OneCikanlar TIdyeGoreGetir(int id)
        {
            return _oneCikanlarDal.getir(x => x.OneCikanID == id);
        }

        public List<OneCikanlar> TListele()
        {
            return _oneCikanlarDal.Listele();
        }

        public void TSil(OneCikanlar t)
        {
            _oneCikanlarDal.Sil(t);
        }
    }
}
