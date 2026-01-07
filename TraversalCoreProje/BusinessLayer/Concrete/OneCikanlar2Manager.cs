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
    public class OneCikanlar2Manager:IOneCikanlar2Service
    {
        IOneCikanlar2Dal _oneCikanlar2Dal;

        public OneCikanlar2Manager(IOneCikanlar2Dal oneCikanlar2Dal)
        {
            _oneCikanlar2Dal = oneCikanlar2Dal;
        }

        public void TEkle(OneCikanlar2 t)
        {
            _oneCikanlar2Dal.Ekle(t);
        }

        public OneCikanlar2 TGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void TGuncelle(OneCikanlar2 t)
        {
            _oneCikanlar2Dal.Guncelle(t);
        }

        public OneCikanlar2 TIdyeGoreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public List<OneCikanlar2> TListele()
        {
            return _oneCikanlar2Dal.Listele();
        }

        public void TSil(OneCikanlar2 t)
        {
            _oneCikanlar2Dal.Sil(t);
        }
    }
}
