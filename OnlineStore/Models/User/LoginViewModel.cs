using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models.User
{
    public class LoginViewModel
    {
        [Display(Name = "Please enter your Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Please enter your Password")]
        [DataType(DataType.Password)]
        [Required( ErrorMessage = "Password empty")]
        public string Password { get; set; }
        
    }
}