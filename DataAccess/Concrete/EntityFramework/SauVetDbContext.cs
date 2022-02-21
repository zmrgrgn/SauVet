using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class SauVetDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O2C8OK9; Database=SauVet; Trusted_Connection=true");
        }
        public DbSet<BelediyeBilgi> BelediyeBilgi { get; set; }
        public DbSet<HayvanKayit> HayvanKayit { get; set; }
        public DbSet<HayvanSahiplendirme> HayvanSahiplendirme { get; set; }
        public DbSet<HayvanTedavi> HayvanTedavi { get; set; }
        public DbSet<Hekim> Hekim { get; set; }
        public DbSet<Mama> Mama { get; set; }
        public DbSet<VatandasBilgi> VatandasBilgi { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
