using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HealthyFoods.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HealthyFoods.DAL
{
    public class HealthContext : DbContext
    {

        public HealthContext() : base("HealthContext")
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Nut> Nuts { get; set; }
        public DbSet<Bean> Beans { get; set; }
        public DbSet<MeatFishEgg> MeatFishEggs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}