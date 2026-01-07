using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TEkle(T t);
        void TSil(T t);
        void TGuncelle(T t);
        List<T> TListele();
        T TGetir(int id);
        T TIdyeGoreGetir(int id);
        //List<T> TSartaGoreListele(Expression<Func<T, bool>> filtrele);
    }
}
