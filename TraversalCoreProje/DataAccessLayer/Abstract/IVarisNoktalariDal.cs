using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IVarisNoktalariDal:IGenericDal<VarisNoktalari>
    {
        public VarisNoktalari rehberleBirlikteRotaGetir(int id);
        public List<VarisNoktalari> son4rotalistele();
    }
}
