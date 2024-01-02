namespace VisitorComposite
{
    public class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public double Expereice { get; set; }
        public void DisplayDetails()
        { 
            Console.WriteLine($"{Name} Head of department {Dept} with Experince: {Expereice}");
            Console.WriteLine("\t Employees");
            foreach (var emp in subOrdinateList)
            {
                emp.DisplayDetails();
            }
            System.Console.WriteLine();
        }

        public List<IEmployee> subOrdinateList = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            subOrdinateList.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            subOrdinateList.Remove(employee);
        }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }
    }

}