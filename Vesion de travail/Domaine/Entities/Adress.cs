using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;



namespace Domain.Entities
{
    //[Owned] // Sii on utilise data annotations

    [Owned]
    //[ComplexType]
    public class Adress
    {   
        public string City { get; set; }
        public string StreetAdress { get; set; }
    }
}
