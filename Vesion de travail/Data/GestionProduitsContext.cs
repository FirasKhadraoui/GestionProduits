using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain.Entities;
using Data.Configurations;


namespace Data
{
    public class GestionProduitsContext : DbContext
    {
        public GestionProduitsContext()
        {
            // this.ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer(@"Server=localhost;Database=GestionProduitDb;Trusted_Connection=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Client> Clients { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(t => t.GetProperties())
            //    .Where(p => p.ClrType == typeof(string)&&p.Name.StartsWith("Name")))
            //{
            //    property.SetColumnName("MyName");
            //}
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new FactureConfiguration());
            modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
        }
    }
}
