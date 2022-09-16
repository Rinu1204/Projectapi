using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Model
{
    internal class Login
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string? Email { get; set; }


        [RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[@$!%?&])[A-Za-z\d@$!%?&]{8,10}$", ErrorMessage = "Entered phone format is not valid.")]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
