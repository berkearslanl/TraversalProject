using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfYorumlarDal : GenericRepository<Yorumlar>, IYorumlarDal
    {
        public List<Yorumlar> YorumListesiniRotaSehriyleGetir()
        {
            using (var c = new Context())
            {
                return c.Yorumlars.Include(x => x.VarisNoktalari).ToList();
            }
        }

        public List<Yorumlar> YorumListesiniRotaSehriyleveKullaniciylaGetir(int id)
        {
            using (var c = new Context())
            {
                return c.Yorumlars.Where(x=>x.VarisNoktasiID==id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
