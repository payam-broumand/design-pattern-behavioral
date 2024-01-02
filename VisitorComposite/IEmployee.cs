using System.Transactions;

namespace VisitorComposite
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }
        void DisplayDetails();
        double Expereice { get; set; }

        void Accept(IEmployeeVisitor visitor);
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public double Expereice { get; set; }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }


        public void DisplayDetails()
        {
            System.Console.WriteLine($"\t\t{Name} in Dept {Dept} with Exp: {Expereice}");
        }
    }

}