using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.entities
{
    public class Chemical : Product
    {
      
        public string LabelName { get; set; }
        public Adress MyAdress { get; set; }
    }
}
