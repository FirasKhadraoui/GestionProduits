using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.entities
{
    public class Product
    {
        public int productid { get; set; }

        [Required(ErrorMessage ="champs name c'est un champ obligatoire")]
        [StringLength(25,ErrorMessage ="taille maximal 25 interface utilisateur")]
        [MaxLength(50,ErrorMessage ="longeur maximal 50")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double price { get; set; }

        [Range(0,int.MaxValue)]
        public int quantity { get; set; }

        [Display(Name="Date de production")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public virtual ICollection<Provider> Providers { get; set;  }
        public virtual ICollection<Facture> factures { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categorie categorie { get; set; }
        public string Image { get; set; }
      

    }
}
