using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class RegisterPersonCommand
    {
        [Required(ErrorMessage = "First Name couldn't be empty")]
        [MaxLength(50, ErrorMessage = "First Name couldn't be more than 50 character!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Birthdate")]
        [Required]
        public DateTime BirthDate { get; set; }

        [Display(Name = "National Code")]
        [MaxLength(10)]
        [Required]
        public string NationalCode { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }

        [Required]
        [MaxLength(13)]
        public string Mobile { get; set; }


        [Display(Name = "Phone Number")]
        [MaxLength(13)]
        public string? PhoneNumber { get; set; }

        [Required]
        [Range(50,250)]
        public int Height { get; set; }

        [Required]
        [Range(50, 150)]
        public int Weight { get; set; }
    }
}
