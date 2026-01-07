using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class VarisNoktalariManager : IVarisNoktalariService
    {
        IVarisNoktalariDal _varisNoktalariDal;

        public VarisNoktalariManager(IVarisNoktalariDal varisNoktalariDal)
        {
            _varisNoktalariDal = varisNoktalariDal;
        }

        public void TEkle(VarisNoktalari t)
        {
            _varisNoktalariDal.Ekle(t);
        }

        public VarisNoktalari TGetir(int id)
        {
            return _varisNoktalariDal.getir(x => x.VarisNoktasiID == id);
        }

        public void TGuncelle(VarisNoktalari t)
        {
            _varisNoktalariDal.Guncelle(t);
        }

        public VarisNoktalari TIdyeGoreGetir(int id)
        {
            return _varisNoktalariDal.idyeGoreGetir(id);
        }

        public List<VarisNoktalari> TListele()
        {
            return _varisNoktalariDal.Listele();
        }

        public VarisNoktalari TrehberleBirlikteRotaGetir(int id)
        {
            return _varisNoktalariDal.rehberleBirlikteRotaGetir(id);
        }

        public List<VarisNoktalari> TSartaGoreListele(Expression<Func<VarisNoktalari, bool>> filtrele)
        {
            return _varisNoktalariDal.sartliListele(x => x.Durum == true);
        }

        public void TSil(VarisNoktalari t)
        {
            _varisNoktalariDal.Sil(t);
        }

        public List<VarisNoktalari> Tson4rotalistele()
        {
            return _varisNoktalariDal.son4rotalistele();
        }
    }
}
