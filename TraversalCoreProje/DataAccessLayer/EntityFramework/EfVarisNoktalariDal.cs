using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfVarisNoktalariDal : GenericRepository<VarisNoktalari>, IVarisNoktalariDal
    {
        public VarisNoktalari rehberleBirlikteRotaGetir(int id)
        {
            using (var c= new Context())
            {
                return c.VarisNoktalaris.Where(x=>x.VarisNoktasiID==id).Include(x => x.Rehberler).FirstOrDefault();
            }
        }

        public List<VarisNoktalari> son4rotalistele()
        {
            using (var c = new Context())
            {
                var values = c.VarisNoktalaris.Take(4).OrderByDescending(x => x.Tarih).ToList();
                return values;
            }
        }
    }
}
