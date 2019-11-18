using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Meteo.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Meteo.DAL
{
    public class PomiaryContext : DbContext
    {
        public PomiaryContext() : base("PomiaryContext") 
        { 

        }
        public DbSet<Pomiary> Pomiary { get; set; }
        public DbSet<Parametry> Parametry { get; set; }
        public DbSet<ParametryDoba> ParametryDoby { get; set; }
        public DbSet<ParametryGodzina> ParametryGodziny { get; set; }
        public DbSet<ParametryTydzien> ParametryTygodnia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}