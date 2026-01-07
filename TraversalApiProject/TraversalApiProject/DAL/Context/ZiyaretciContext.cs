using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class ZiyaretciContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-5Q1ARH5E;initial catalog=TraversalDbApi;integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet<Ziyaretci> ziyaretcis { get; set; }
    }
}
