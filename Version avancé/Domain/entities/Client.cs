using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Domain.entities
{
    public class Client
    {
        [Key]
        public int CIN { get; set; }
        public DateTime date_naissance { get; set; }
        public string mail { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual ICollection<Facture> factures { get; set; }
    }
}
