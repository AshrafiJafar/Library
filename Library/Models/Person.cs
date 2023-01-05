using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("People")]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string? PhoneNumber { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Balance { get; set; }

    }
}
