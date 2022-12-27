namespace Library.Models
{
    public class TeachersTime
    {
        public long Id { get; set; }
        public DateTime Day { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set;}
    }
}
