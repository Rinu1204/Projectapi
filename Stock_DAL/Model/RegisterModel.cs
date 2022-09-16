using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Stock_DAL.Model
{
    public class RegisterModel
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Username is required"),StringLength (maximumLength:50,MinimumLength =10)]
        public string? Username { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Address is required"), StringLength(maximumLength:150, MinimumLength = 10)]
        public string? Address { get; set; }
        [Phone]
        [Required(ErrorMessage = "MobileNumber is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage = "Entered phone format is not valid.")]
        public long? MobileNumber { get; set; }
        [RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[@$!%?&])[A-Za-z\d@$!%?&]{8,10}$", ErrorMessage = "Entered phone format is not valid.")]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [CompareAttribute("Password", ErrorMessage = "Password doesn't match.")]
        public string? ConfirmPassword { get; set; }
        [JsonIgnore]
        public Order? Order { get; set; }
    }
}
