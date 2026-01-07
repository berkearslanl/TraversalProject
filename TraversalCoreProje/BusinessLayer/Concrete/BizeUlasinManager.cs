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
    public class BizeUlasinManager : IBizeUlasinService
    {
        IBizeUlasDal _bizeUlasDal;

        public BizeUlasinManager(IBizeUlasDal bizeUlasDal)
        {
            _bizeUlasDal = bizeUlasDal;
        }

        public void TEkle(BizeUlasin t)
        {
            _bizeUlasDal.Ekle(t);
        }

        public BizeUlasin TGetir(int id)
        {
            return _bizeUlasDal.getir(x => x.bizeUlasinID == id);
        }

        public void TGuncelle(BizeUlasin t)
        {
            _bizeUlasDal.Guncelle(t);
        }

        public BizeUlasin TIdyeGoreGetir(int id)
        {
            return _bizeUlasDal.idyeGoreGetir(id);
        }

        public List<BizeUlasin> TListele()
        {
            return _bizeUlasDal.Listele();
        }

        public void TSil(BizeUlasin t)
        {
            _bizeUlasDal.Sil(t);
        }
    }
}
