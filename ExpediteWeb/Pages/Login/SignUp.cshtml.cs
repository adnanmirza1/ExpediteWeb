using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExpediteWeb.Pages.Login
{
    public class SignUpModel : PageModel
    {
        public void OnGet()
        {

        }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage ="Invalid Email Address,")]
        public string email{get; set;}

        [Required]
        [MinLength(8,ErrorMessage ="Password must be 8 characters long.")]
        public string password { get; set; }

        [Required]
        public string rpassword { get; set; }
    }
}