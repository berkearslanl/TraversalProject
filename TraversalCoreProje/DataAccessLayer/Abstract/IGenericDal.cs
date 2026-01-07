using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //her entity için tek tek yazmak yerine generic bir yapı kurup T ile sınıflara ulaştık
    public interface IGenericDal<T>
    {
        void Ekle(T t);
        void Sil(T t);
        void Guncelle(T t);
        List<T> Listele();
        T getir(Expression<Func<T, bool>> filtrele);//şarta göre bulma
        List<T> sartliListele(Expression<Func<T, bool>> filtrele);//şarta göre listeleme
        T idyeGoreGetir(int id);
    }
}
