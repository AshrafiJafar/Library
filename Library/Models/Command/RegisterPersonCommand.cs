using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class RegisterPersonCommand
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Birthdate")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "National Code")]
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
