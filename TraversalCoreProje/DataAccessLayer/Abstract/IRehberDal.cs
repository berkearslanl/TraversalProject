using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //ıgenericdal'dan miras aldık ve oradaki t sınıfını burda doldurduk.(tek tek metot oluşturmak yerine sınıfı eşleştiriyoruz)
    public interface IRehberDal:IGenericDal<Rehberler>
    {
    }
}
