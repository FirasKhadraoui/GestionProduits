using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Domain.entities
{ [Owned]
   public class Adress

    {
        public string City { get; set; }
        public string StreetAdress { get; set; }

    }
}
