using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IYorumlarService:IGenericService<Yorumlar>
    {
        List<Yorumlar> TRotayaGoreIdGetir(int id);
        List<Yorumlar> YorumListesiniRotaSehriyleGetir();
        public List<Yorumlar> TYorumListesiniRotaSehriyleveKullaniciylaGetir(int id);
    }
}
