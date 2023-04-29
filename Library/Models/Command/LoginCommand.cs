using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class LoginCommand
    {
        [Required(ErrorMessage = "Password is required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
        public string? ReturnUrl { get; set; }
    }
}
