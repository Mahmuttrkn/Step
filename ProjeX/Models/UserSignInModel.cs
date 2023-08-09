using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Please Mail")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please Password")]
        public string password { get; set; }

        //[Required(ErrorMessage = "Please confirmpassword")]
        //public string confirmpassword { get; set; }
    }
}
