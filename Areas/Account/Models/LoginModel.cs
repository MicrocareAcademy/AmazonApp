using System.ComponentModel.DataAnnotations;

namespace AmazonApp.Areas.Account.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "UserName")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please Enter Password!")]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
