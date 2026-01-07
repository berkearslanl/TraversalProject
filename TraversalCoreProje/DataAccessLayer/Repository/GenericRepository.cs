using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Ekle(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public T getir(Expression<Func<T, bool>> filtrele)
        {
            using var c = new Context();
            return c.Set<T>().SingleOrDefault(filtrele);
        }

        public void Guncelle(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }

        public T idyeGoreGetir(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> Listele()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> sartliListele(Expression<Func<T, bool>> filtrele)
        {
            using var c = new Context();
            return c.Set<T>().Where(filtrele).ToList();
        }

        public void Sil(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
    }
}
