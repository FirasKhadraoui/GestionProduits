using System;
using System.Collections.Generic;
using System.Text;
using Domain.entities;
namespace Service
{
    public static class ProductExtension
    {


        public static void UpperName(this ManageProduct manageproduct ,Product product)
        {
            product.Name = product.Name.ToUpper();
        }
         public static bool  InCategory(this ManageProduct manageproduct , Product product, Categorie category)
        {
            return product.categorie.name == category.name;
        }
    }
}
