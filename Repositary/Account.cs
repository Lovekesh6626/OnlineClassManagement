using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Repositary
{
    public class Account
    {
      public string FullName { get; set;}
        [Required]
        [EmailAddress]
      public string  Email { get; set; }
        [Required]
       
        public string Password { get; set; }
    }


}