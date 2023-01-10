using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Teacher : Person
    {
        public int NumberOfChilds { get; set; }
        public ICollection<SportType> Sports { get; set; }
        public ICollection<TeachersTime> TeachersTimes { get; set; }
    }
}
