namespace Composite
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }

        public void DisplayDetail()
        {
            System.Console.WriteLine($"\tEmployee {Name} in Deprartment {Dept}");
        }
    }

}