using System;
using Domain.entities;
using System.Collections.Generic;
using System.Linq;
namespace Service
{
    public class ManageProduct
    {
        private IList<Product> products;

        public ManageProduct(IList<Product> products)
        {
            this.products = products;
        }
        public IEnumerable<Product> Get5Chemical(double price)
        {
            var query = (from Product in products
                         where products is Chemical && Product.price <= price    //is fel héritage
                         select Product).Take(5);
            return query;
        }
        public Product GetMaxprice()
        {
            var maxprice = (from Product in products
                            select Product.price).Max();
            var product = (from Product in products
                           where Product.price == maxprice
                           select Product).First();
            return product;       
        }
       public int GetCountProduct(string city)
        {
            var query = (from Product in products
                         where Product is Chemical && ((Chemical) Product).MyAdress.City == city
                         select Product).Count();
            return query;
        }
        public IEnumerable<Product> GetChemicalCity()
        {
            var query = (from Product in products
                         where Product is Chemical orderby ((Chemical)Product).MyAdress.City
                         select Product);
            return query;
        }
        public void GetChemicalgroupbyCity()
        {
            var query = (from Product in products
                         where Product is Chemical
                         orderby ((Chemical)Product).MyAdress.City
                         group ((Chemical)Product) by ((Chemical)Product).MyAdress.City
                         );
          foreach (var grouping in query)
            {
                Console.WriteLine("City" + grouping.Key);
                foreach(var product in grouping)
                {
                    Console.WriteLine("nom du produit" + product.Name);
                }
            }
        }
    }
}
