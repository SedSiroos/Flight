using System;
using System.Collections.Generic;
using Flight.Entity.Domain;
using Microsoft.EntityFrameworkCore;

namespace Flight.Entity
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {
        }

        public DbSet<Domain.Flight> Flights { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Airplane> AirPlanNames { get; set; }
        public DbSet<AirLine> CompanyAirLines { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(new List<City>()
            {
                new() {Id=1,CreatedOn = DateTime.Now, Name = "تهران"},
                new()  {Id=2,CreatedOn = DateTime.Now, Name = "مشهد"},
                new()  {Id=3,CreatedOn = DateTime.Now, Name = "رشت"},
                new()  {Id=4,CreatedOn = DateTime.Now, Name = "اهواز"},
            });

            modelBuilder.Entity<AirLine>().HasData(new List<AirLine>()
            {
                new AirLine(){Id=1,CreatedDate = DateTime.Now,Name = "ملکی ایرلاین"},
                new AirLine(){Id=2,CreatedDate = DateTime.Now,Name = "ایران ایر"},
                new AirLine(){Id=3,CreatedDate = DateTime.Now,Name = "ماهان"}
            });

            modelBuilder.Entity<Airplane>().HasData(new List<Airplane>()
            {
                new Airplane(){Id=1,CreatedOn = DateTime.Now,Name = "C130"},
                new Airplane(){Id=2,CreatedOn = DateTime.Now,Name = "فوکر 100"},
                new Airplane(){Id=3,CreatedOn = DateTime.Now,Name = "هواپیمای تستی"}
            });

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
                .HasIndex(x => x.Name).IsUnique();
           
            modelBuilder.Entity<Inventory>()
                .HasIndex(x => x.OrderId).IsUnique();
        }
    }
}

