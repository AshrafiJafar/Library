namespace Library.Models
{
    public class Teacher : Person
    {
        public ICollection<SportType> Sports { get; set; }
        public ICollection<TeachersTime> TeachersTimes { get; set; }
    }
}
