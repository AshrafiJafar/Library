namespace Library.Models.Command
{
    public class DeletePersonCommand
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
