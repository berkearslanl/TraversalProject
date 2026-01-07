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
    public class HaberBulteniManager:IHaberBulteniService
    {
        IHaberBulteniDal _haberBulteniDal;

        public HaberBulteniManager(IHaberBulteniDal haberBulteniDal)
        {
            _haberBulteniDal = haberBulteniDal;
        }

        public void TEkle(HaberBülteni t)
        {
            _haberBulteniDal.Ekle(t);
        }

        public HaberBülteni TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(HaberBülteni t)
        {
            _haberBulteniDal.Guncelle(t);
        }

        public HaberBülteni TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<HaberBülteni> TListele()
        {
            return _haberBulteniDal.Listele();
        }

        public void TSil(HaberBülteni t)
        {
            _haberBulteniDal.Sil(t);
        }
    }
}
