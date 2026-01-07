using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IVarisNoktalariService:IGenericService<VarisNoktalari>
    {
        List<VarisNoktalari> TSartaGoreListele(Expression<Func<VarisNoktalari, bool>> filtrele);
        public VarisNoktalari TrehberleBirlikteRotaGetir(int id);
        public List<VarisNoktalari> Tson4rotalistele();
    }
}
