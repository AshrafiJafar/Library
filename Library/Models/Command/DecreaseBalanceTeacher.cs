namespace Library.Models.Command
{
    public class DecreaseBalanceTeacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Balance { get; set; }
    }
}
