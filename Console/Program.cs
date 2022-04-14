using System;
using Domain.entities;
using System.Collections.Generic;
using Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GP.Data.Infrastructure;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var serviceCollection = new ServiceCollection();
            //serviceCollection.AddTransient<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<ICategoryService, CategoryService>()
                .AddTransient<IUnitOfWork, UnitOfWork>()
                .AddTransient(typeof(IRepositoryBase<>) , typeof(RepositoryBase<>));
             
                
                

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var serviceCategorie = serviceProvider.GetService<ICategoryService>();




            Categorie cat1 = new Categorie() { name = "categorie1" };
            serviceCategorie.Add(cat1);
            serviceCategorie.Commit();

            //Provider P1 = new Provider()
            //{
            //    Password2 = "12345528",
            //    ConfirmPassword = "12345",

            //};
            ////  Provider.SetIsApproved2(P1.Password,P1.ConfirmPassword,P1.IsApproved);
            ////   System.Console.WriteLine(P1.IsApproved);
            //// Provider.SetIsApproved(P1);
            //// System.Console.WriteLine(P1.IsApproved);
            //Categorie fruit = new Categorie() { name = "Fruit" };
            //Categorie Alimentaire = new Categorie() { name = "Alimentaire" };

            ////Products
            //Categorie cat1 = new Categorie() { name = "CAT1" };
            //Categorie cat2 = new Categorie() { name = "CAT2" };
            //Categorie cat3 = new Categorie() { name = "CAT3" };
            //Provider prov1 = new Provider() { UserName = "PROV1" };
            //Provider prov2 = new Provider() { UserName = "PROV2" };
            //Provider prov3 = new Provider() { UserName = "PROV3" };
            //Provider prov4 = new Provider() { UserName = "PROV4" };
            //Provider prov5 = new Provider() { UserName = "PROV5" };
            //Product prod1 = new Product() { Name = "prod1", categorie = cat1, Providers = new List<Provider>() { prov1, prov2 } };
            //Product prod2 = new Product() { Name = "PROD2", categorie = cat1, Providers = new List<Provider>() { prov1 } };
            //Product prod3 = new Product() { Name = "PROD3", Providers = new List<Provider>() { prov3, prov4, prov5 } };
            //cat1.products = new List<Product>() { prod1, prod2 };

            //prov1.products = new List<Product>() { prod1, prod2 };
            //prov2.products = new List<Product>() { prod1 };
            //prov3.products = new List<Product>() { prod3 };
            //List<Product> products = new List<Product>();
            //products.Add(prod1);
            //products.Add(prod2);
            //products.Add(prod3);

            //ManageProduct manageProduct = new ManageProduct(products);
            //manageProduct.UpperName(prod1);
            //System.Console.WriteLine(prod1.Name);


            //// foreach (Product product in products)
            //// {
            ////     product.getDetails();
            ////}
            //// products.RemoveAt(1);

            ///*** Donnees d'initialisation **/
            ////Categories
            ////    Categorie fruit = new Categorie() { name = "Fruit" };
            ////    Categorie Alimentaire = new Categorie() { name = "Alimentaire" };

            ////    //Products
            ////    Product acide = new Chemical()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Name = "ACIDE CITRIQUE",
            ////        Description = "Monohydrate - E330 - USP32",
            ////        categorie = Alimentaire,
            ////        price = 90,
            ////        quantity = 30,
            ////        City = "Sousse"
            ////    };
            ////  //  Product cacao = new Chemical()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Name = "POUDRE DE CACAO NATURELLE",
            ////        Description = "10% -12%",
            ////       // Description = Alimentaire,
            ////       /// Price = 419,
            ////      //  Quantity = 80,
            ////        City = "Sfax"
            ////    };

            ////    Product dioxyde = new Chemical()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Name = "DIOXYDE DE TITANE",
            ////        Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
            ////        MyCategory = Alimentaire,
            ////        Price = 200,
            ////        Quantity = 50,
            ////        City = "Tunis"
            ////    };
            ////    Product amidon = new Chemical()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Name = "AMIDON DE MAÏS",
            ////        Description = "Amidon de maïs natif",
            ////        MyCategory = Alimentaire,
            ////        Price = 70,
            ////        Quantity = 30,
            ////        City = "Tunis"
            ////    };
            ////    Product blackberry = new Biological()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Name = "Blackberry",
            ////        Description = "",
            ////        MyCategory = fruit,
            ////        Price = 60,
            ////        ProductId = 0,
            ////        Quantity = 0

            ////    };

            ////    Product apple = new Biological()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Description = "",
            ////        MyCategory = fruit,
            ////        Name = "Apple",
            ////        Price = 100.00,
            ////        ProductId = 0,
            ////        Quantity = 100

            ////    };

            ////    Product avocado = new Biological()
            ////    {
            ////        DateProd = new DateTime(2000, 12, 12),
            ////        Description = "",
            ////        category = fruit,
            ////        Name = "Avocado",
            ////        Price = 100.00,
            ////        ProductId = 0,
            ////        Quantity = 100

            ////    };

            ////    List<Product> products = new List<Product>() { acide, cacao, dioxyde, amidon, blackberry, apple, avocado };
            ////    ManageProduct manageProduct = new ManageProduct(products);

            ////    Provider sater = new Provider() { Id = 1, UserName = "Medical Provider" };
            ////    Provider sudMedical = new Provider() { Id = 2, UserName = "Fruit-SA Provider" };
            ////    Provider palliserSa = new Provider() { Id = 3, UserName = "Fruit-CP  Provider" };
            ////    Provider prov4 = new Provider() { Id = 4, UserName = "Chemical Med-Provider" };
            ////    Provider prov5 = new Provider() { Id = 5, UserName = "Bio Provider" };
            ////    List<Provider> providers = new List<Provider>() { sater, sudMedical, palliserSa, prov4, prov5 };
            ////    ManageProvider manageProvider = new ManageProvider(providers);
            ////}
        }
         static void InitData(ServiceProvider serviceProvider )
        {
            var serviceProduct = serviceProvider.GetService<IProductService>();
            //var serviceProvider = serviceProvider.GetService<IProviderService>();

            var serviceFacture = serviceProvider.GetService<IFactureService>();
            var serviceClient = serviceProvider.GetService<IClientService>();
            var serviceprovider = serviceProvider.GetService<IProviderService>();
            

            Categorie fruit = new Categorie() { name = "Fruit" };
            Categorie Alimentaire = new Categorie() { name = "Alimentaire" };

            Adress ad1 = new Adress { City = "sousse", StreetAdress = "22" };
            //Products
            Product acide = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "ACIDE CITRIQUE",
                Description = "Monohydrate - E330 - USP32",
                categorie = Alimentaire,
                price = 90,
                quantity = 30,
                MyAdress = ad1
            };
            serviceProduct.Add(acide);

        Adress ad2 = new Adress { City = "sfax", StreetAdress = "22" };
        Product cacao = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "POUDRE DE CACAO NATURELLE",
                Description = "10% -12%",
                categorie = Alimentaire,
                price = 419,
                quantity = 80,
                MyAdress = ad2
        };
            serviceProduct.Add(cacao);

            Adress ad3 = new Adress { City = "Tunis", StreetAdress = "22" };
            Product dioxyde = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "DIOXYDE DE TITANE",
                Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
                categorie = Alimentaire,
                price = 200,
                quantity = 50,
                MyAdress = ad3
            };
            serviceProduct.Add(dioxyde);
            Adress ad4 = new Adress { City = "Tunis", StreetAdress = "22" };
            Product amidon = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "AMIDON DE MAÏS",
                Description = "Amidon de maïs natif",
                categorie = Alimentaire,
                price = 70,
                quantity = 30,
                MyAdress = ad4
            };

            Product blackberry = new Biological()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "Blackberry",
                Description = "",
                categorie = fruit,
                price = 60,
                productid = 0,
                quantity = 0

            };

            Product apple = new Biological()
            {
                DateProd = new DateTime(2000, 12, 12),
                Description = "",
                categorie = fruit,
                Name = "Apple",
                price = 100.00,
                productid = 0,
                quantity = 100

            };

            Product avocado = new Biological()
            {
                DateProd = new DateTime(2000, 12, 12),
                Description = "",
                categorie = fruit,
                Name = "Avocado",
                price = 100.00,
                productid = 0,
                quantity = 100

            };

            List<Product> products = new List<Product>() { acide, cacao, dioxyde, amidon, blackberry, apple, avocado };
            ManageProduct manageProduct = new ManageProduct(products);

            Provider sater = new Provider() { Id = 1, UserName = "Medical Provider" };
            Provider sudMedical = new Provider() { Id = 2, UserName = "Fruit-SA Provider" };
            Provider palliserSa = new Provider() { Id = 3, UserName = "Fruit-CP  Provider" };
            Provider prov4 = new Provider() { Id = 4, UserName = "Chemical Med-Provider" };
            Provider prov5 = new Provider() { Id = 5, UserName = "Bio Provider" };
            List<Provider> providers = new List<Provider>() { sater, sudMedical, palliserSa, prov4, prov5 };
            //ManageProvider manageProvider = new ManageProvider(providers);

        }
    }
}