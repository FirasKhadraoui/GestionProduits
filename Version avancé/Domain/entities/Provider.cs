using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.entities
{
    public class Provider
    {
        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="le champ confirmPassword est different de Password")]
        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Product> products { get; set; }
        public bool IsApproved { get; set; }

        [DataType(DataType.Password)]
        [MinLength (8)]
        [Required]
        private string Password { get; set; }
        public string Password2
        {
            get => Password; set
            {
                if(value.Length>5 && value.Length<20)
                {
                    Password = value;
                }
                else{
                    Console.WriteLine("error ");
                }
            }


        }
        
        
        public static void SetIsApproved(Provider P)
        {
            if (String.Compare(P.Password, P.ConfirmPassword) == 0)
            {
                P.IsApproved = true;
            }
            else
            {
                P.IsApproved = false;
            }


        }
        public static void SetIsApproved2(string password, string confirmPassword, bool isApproved)
        {
            if(String.Compare(password, confirmPassword)==0)
            {
                isApproved = true;
            }
            else
            {
                isApproved = false;
            }
        }
        public bool Login(string pass,string UserName)
        {
            bool res=true;
            if(String.Compare(Password2, Password2) == 0)
            {
return res;
            }
            else{
                return res;
            }
            
        }
    }
}
