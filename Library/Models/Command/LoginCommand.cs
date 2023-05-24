using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class LoginCommand
    {
        [Required(ErrorMessage = "Password is required")]
        public string UserName { get; set; } = null!;


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!; 
        public string? ReturnUrl { get; set; }
    }
}
