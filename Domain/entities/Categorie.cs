using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.entities
{
    public class Categorie
    {
        public int CategorieId { get; set; }
       
        public string name { get; set; }
        public virtual ICollection<Product> products { get; set; }

       


    }
}
