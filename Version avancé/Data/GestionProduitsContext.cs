using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.entities;
using System.Linq;
using Data.Configurations;
namespace Data
{
    public class GestionProduitsContext : DbContext
    {
        public GestionProduitsContext(DbContextOptions<GestionProduitsContext> options) : base(options)
            {}

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
               .UseSqlServer(@"Server=localhost;Database=GestionProduitDb;Trusted_Connection=True;");

            

        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetProperties())
               .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Name") ))
                   {
                           property.SetColumnName("MyName");
                    }
                      modelBuilder.ApplyConfiguration(new ProductConfiguration());
                      modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
                      modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Facture> Facture { get; set; }
        public DbSet<Client> Client { get; set; }


    }
}
