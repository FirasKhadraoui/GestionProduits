using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain.entities
{
   public  class Facture
    {
        [Key]
        public int clientFK { get; set; }
        public DateTime date_achat { get; set; }
        public double prix { get; set; }
        public int productFK { get; set; }
        public virtual Client client { get; set; }
        public virtual Product product { get; set; }
    }
}
