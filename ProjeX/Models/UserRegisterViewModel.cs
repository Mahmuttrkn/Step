using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeX.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Please Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Password")]
        [Compare("Password",ErrorMessage ="Password Fail")]
        public string ConfirmPassword { get; set; }
    }
}
