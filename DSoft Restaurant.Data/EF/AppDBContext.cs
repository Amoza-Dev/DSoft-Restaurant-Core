using DSoft_Restaurant.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoft_Restaurant.Data.EF
{
    public class AppDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"SERVER=.\SQLEXPRESS;Initial Catalog=DSoftRestaurantDB;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<TBItems> Items { get; set; }
        public DbSet<TBZones>  Zones { get; set; }
        public DbSet<TBTables> Tables { get; set; }
        public DbSet<TBEmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<TBEmployees> Employees { get; set; }
        public DbSet<TBGroupExpenses> GroupExpenses { get; set; }
        public DbSet<TBExpenses> Expenses { get; set; }
        public DbSet<TBDeliveryEmployee> DeliveryEmployees { get; set; }
        public DbSet<TBDeliveryCompany> DeliveryCompany { get; set; }
        public DbSet<TBItemDeliveryPrice> ItemDeliveryPrices { get; set; }
        public DbSet<TBCategory> Categoroy { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TBItemDeliveryPrice>()
                .HasOne(d => d.TBItems)
                .WithMany(i => i.ItemDeliveryPrices)
                .HasForeignKey(d => d.ItemId);  

            modelBuilder.Entity<TBItemDeliveryPrice>()
                .HasOne(d => d.DeliverCompany)
                .WithMany(i => i.ItemDeliveryPrices)
                .HasForeignKey(d => d.DeliveryCompanyId);  

            modelBuilder.Entity<TBItems>()
                .HasOne(d => d.tBCategory)
                .WithMany(i => i.items)
                .HasForeignKey(d => d.CategoryId);

            modelBuilder.Entity<TBTables>()
                .HasOne(d => d.TBZones)
                .WithMany(i => i.tBTables)
                .HasForeignKey(d => d.ZoneID);

            modelBuilder.Entity<TBEmployees>()
                .HasOne(d => d.TBEmployeeCategory)
                .WithMany(i => i.TBEmployees)
                .HasForeignKey(d => d.CategoryID);

            modelBuilder.Entity<TBExpenses>()
                .HasOne(d => d.TBGroupExpenses)
                .WithMany(i => i.Expenses)
                .HasForeignKey(d => d.GroupID);
        }
    }
}
