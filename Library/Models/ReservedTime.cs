namespace Library.Models
{
    public class ReservedTime
    {
        public long Id { get; set; }
        public int? TeacherId { get; set; }
        public int PersonId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int ShelfId { get; set; }
        public Person Person { get; set; }
        public Teacher Teacher { get; set; }
        public Shelf Shelf { get; set; }
    }
}
