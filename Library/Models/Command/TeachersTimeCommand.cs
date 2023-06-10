using System.ComponentModel.DataAnnotations;

namespace Library.Models.Command
{
    public class TeachersTimeCommand
    {
        [Display(Name = "Day")]
        [Required(ErrorMessage = "Day couldn't empty")]
        public string Day { get; set; }

        [Display(Name = "Time")]
        [Required(ErrorMessage = "Time couldn't empty")]
        public DateTime Time { get; set; }

        [Display(Name = "From")]
        public TimeSpan From { get; set; }

        [Display(Name = "To")]
        public TimeSpan To { get; set; }

        [Display(Name = "TeacherId")]
        public int TeacherId { get; set; }

        [Display(Name = "Teacher")]
        public Teacher Teacher { get; set; }

        [Display(Name = "Active")]
        public bool isActive { get; set; }

    }
}
