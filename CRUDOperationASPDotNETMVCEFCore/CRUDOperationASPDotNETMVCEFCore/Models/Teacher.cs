using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUDOperationASPDotNETMVCEFCore.Models
{
    public class Teacher
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Skills { get; set; }
        [Range(5,50)]
        public int TotalStudents { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public DateTime AddedOn { get; set; }
    }
}
