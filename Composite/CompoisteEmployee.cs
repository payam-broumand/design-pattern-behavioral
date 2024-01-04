using System.Transactions;

namespace Composite
{
    public class CompoisteEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }

        List<IEmployee> subOrdinateList = new List<IEmployee>();

        public void DisplayDetail()
        {
            System.Console.WriteLine($"Employee {Name} Head Of Deprartment {Dept}");
            System.Console.WriteLine("--------------------------------------");
            foreach(var item in subOrdinateList){
                item.DisplayDetail();
            }
            System.Console.WriteLine();
        }

        public void AddEmployee(IEmployee employee){ 
            subOrdinateList.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee){
            subOrdinateList.Remove(employee);
        }
    }
}