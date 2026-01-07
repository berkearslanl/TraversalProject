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
    public class YorumlarManager:IYorumlarService
    {
        IYorumlarDal _yorumlarDal;

        public YorumlarManager(IYorumlarDal yorumlarDal)
        {
            _yorumlarDal = yorumlarDal;
        }

        public void TEkle(Yorumlar t)
        {
            _yorumlarDal.Ekle(t);
        }

        public Yorumlar TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(Yorumlar t)
        {
            _yorumlarDal.Guncelle(t);
        }

        public Yorumlar TIdyeGoreGetir(int id)
        {
            return _yorumlarDal.idyeGoreGetir(id);
        }
        public List<Yorumlar> TRotayaGoreIdGetir(int id)
        {
            return _yorumlarDal.sartliListele(x => x.VarisNoktasiID == id);
        }

        public List<Yorumlar> TListele()
        {
            return _yorumlarDal.Listele();
        }

        public void TSil(Yorumlar t)
        {
            _yorumlarDal.Sil(t);
        }

        public List<Yorumlar> YorumListesiniRotaSehriyleGetir()
        {
            return _yorumlarDal.YorumListesiniRotaSehriyleGetir();
        }

        public List<Yorumlar> TYorumListesiniRotaSehriyleveKullaniciylaGetir(int id)
        {
            return _yorumlarDal.YorumListesiniRotaSehriyleveKullaniciylaGetir(id);
        }
    }
}
