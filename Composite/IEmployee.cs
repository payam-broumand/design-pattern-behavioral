namespace Composite
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }

        void DisplayDetail();
    } 
}