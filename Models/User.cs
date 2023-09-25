using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myWallet.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        [Required(ErrorMessage = "User Name Required")]
        [MinLength(8, ErrorMessage = "User Name must be 8 character")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        [Required(ErrorMessage = "Password Required")]
        [StringLength(8, ErrorMessage = "Password must be 8 character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }
    }
}
