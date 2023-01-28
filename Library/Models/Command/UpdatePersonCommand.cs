using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class UpdatePersonCommand
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string NationalCode { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Weight { get; set; }
    }
}
