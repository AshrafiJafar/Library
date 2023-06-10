namespace Library.Models
{
    public class SportType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<SportType> List => new List<SportType>()
        {
            new SportType{Id=0,Name="Fitness"},
            new SportType{Id=1,Name="BodyBilding"},
            new SportType{Id=2,Name="Aerobik"},
        };

    }
}
