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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TEkle(AppUser t)
        {
            _appUserDal.Ekle(t);
        }

        public AppUser TGetir(int id)
        {
            return _appUserDal.getir(x=>x.Id==id);
        }

        public void TGuncelle(AppUser t)
        {
            _appUserDal.Guncelle(t);
        }

        public AppUser TIdyeGoreGetir(int id)
        {
            return _appUserDal.idyeGoreGetir(id);
        }

        public List<AppUser> TListele()
        {
            return _appUserDal.Listele();
        }

        public void TSil(AppUser t)
        {
            _appUserDal.Sil(t);
        }
    }
}
