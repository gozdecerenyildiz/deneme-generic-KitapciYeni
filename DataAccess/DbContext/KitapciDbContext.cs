using Entity.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DbContext
{
    public class KitapciDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=KitapciDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<KitapTur> KitapTur { get; set; }
        public DbSet<KitapYazar> KitapYazar { get; set; }
    }
}
