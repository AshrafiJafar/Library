using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class DatailsTeacherCommand
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "First Name couldn't be more than 50 character!")]
        [Required(ErrorMessage = "First Name couldn't empty")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [MaxLength(80)]
        [Required]
        public string LastName { get; set; }


        [Display(Name = "Birthdate")]
        [Required]
        public DateTime BirthDate { get; set; }


        [Display(Name = "National Code")]
        [MaxLength(10)]
        [Required]
        public string NationalCode { get; set; }


        [Display(Name = "Address")]
        [MaxLength(500)]
        [Required]
        public string Address { get; set; }



        [Display(Name = "Mobile")]
        [MaxLength(13)]
        [Required]
        public string Mobile { get; set; }



        [Display(Name = "Phone Number")]
        [MaxLength(13)]
        [Required]
        public string PhoneNumber { get; set; }


        [Display(Name = "Height")]
        [Range(50, 250)]
        [Required]
        public int Height { get; set; }


        [Display(Name = "Weight")]
        [Range(50, 150)]
        [Required]
        public int Weight { get; set; }


        [Display(Name = "NumberOfChilds")]
        [Required]
        public int NumberOfChilds { get; set; }


        [Display(Name = "SportTypes")]
        [Required]
        public ICollection<SportType> Sports { get; set; }


        [Display(Name = "TeachersTimes")]
        [Required]
        public ICollection<TeachersTime> TeachersTimes { get; set; }

        public int SubjectId { get; set; }

        [Display(Name = "Introduction")]
        [MaxLength(500)]
        [Required]
        public string Introduction { get; set; }


    }
}
