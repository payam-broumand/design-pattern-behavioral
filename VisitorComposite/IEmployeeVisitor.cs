namespace VisitorComposite
{
    public interface IEmployeeVisitor
    {
        void VisitEmployee(Employee employee);

        void VisitEmployee(CompositeEmployee employee);
    }

    public class EligibleForPromotion : IEmployeeVisitor
    {
        string eligibleForPromotion = string.Empty;

        public void VisitEmployee(Employee employee)
        {
            eligibleForPromotion = employee.Expereice >= 5 ? "Yes" : "No";
            System.Console.WriteLine($"{employee.Name} from dept {employee.Dept} is eligible for promotion? {eligibleForPromotion}");
        }

        public void VisitEmployee(CompositeEmployee employee)
        {
            eligibleForPromotion = employee.Expereice >= 7 ? "Yes" : "No";
            System.Console.WriteLine($"{employee.Name} from dept {employee.Dept} is eligible for promotion? {eligibleForPromotion}");
        }
    }

}