using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        //veritabanı bağlantısı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-5Q1ARH5E;database=TraversalDb;integrated security=true;TrustServerCertificate=True;");
        }

        //Entityleri veritabanına gönderme

        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Hakkimizda2> Hakkimizda2s { get; set; }
        public DbSet<OneCikanlar> OneCikanlars { get; set; }
        public DbSet<OneCikanlar2> OneCikanlar2s { get; set; }
        public DbSet<AltHakkimizda> AltHakkimizdas { get; set; }
        public DbSet<HaberBülteni> HaberBültenis { get; set; }
        public DbSet<iletisim> İletisims { get; set; }
        public DbSet<BizeUlasin> bizeUlasins { get; set; }
        public DbSet<Referanslar> Referanslars { get; set; }
        public DbSet<Rehberler> Rehberlers { get; set; }
        public DbSet<VarisNoktalari> VarisNoktalaris { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }
        public DbSet<Duyurular> duyurulars { get; set; }






    }
}
