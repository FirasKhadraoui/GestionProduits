using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Client
    {
        [Key]
        public int Cin { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public DateTime DateNaissance { get; set; }

        public virtual ICollection<Facture> Factures { get; set; }
    }
}
