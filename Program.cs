// ------- using visitor
// using BehavioralPatterns.Visitor;
// using Visitor;

// NumbetCollection numberCollection = new();
// IVisitor visitor = new IncerementNumberVisitor();

// numberCollection.DisplayNumbers();
// System.Console.WriteLine();
// numberCollection.Accept(visitor);



// ----------- using visitor with compoiste pattern 


// using VisitorComposite;
// -------------- compsite Visitor
// Employee sale_emp1 = new Employee() { Name = "Sale_Emp_01", Dept = "Sale", Expereice = 4};
// Employee sale_emp2 = new Employee() { Name = "Sale_Emp_02", Dept = "Sale", Expereice = 7};
// Employee sale_emp3 = new Employee() { Name = "Sale_Emp_03", Dept = "Sale", Expereice = 5};
// CompositeEmployee sale_manager = new CompositeEmployee() { Name = "HOD_Sale", Dept = "Sale", Expereice = 6};
// sale_manager.AddEmployee(sale_emp1);
// sale_manager.AddEmployee(sale_emp2);
// sale_manager.AddEmployee(sale_emp3);


// Employee market_emp1 = new Employee() {Name = "Maert_Emp_01", Dept = "Markting", Expereice = 5};
// Employee market_emp2 = new Employee() {Name = "Maert_Emp_02", Dept = "Markting", Expereice = 3};
// CompositeEmployee marketing_manager = new CompositeEmployee() {Name = "HOD_Marketing", Dept = "Marketing", Expereice = 7};
// marketing_manager.AddEmployee(market_emp1);
// marketing_manager.AddEmployee(market_emp2);

// CompositeEmployee principal = new CompositeEmployee();
// principal.AddEmployee(sale_manager);
// principal.AddEmployee(marketing_manager);
// principal.DisplayDetails();

// System.Console.WriteLine();

// List<IEmployee> employeeList = new List<IEmployee>();
// foreach (var employee in principal.subOrdinateList)
// {
//     employeeList.Add(employee);
// }
// foreach (var employee in sale_manager.subOrdinateList)
// {
//     employeeList.Add(employee);
// }
// foreach (var employee in marketing_manager.subOrdinateList)
// {
//     employeeList.Add(employee);
// }

// IEmployeeVisitor employeeVisitor = new EligibleForPromotion();
// foreach (var employee in employeeList)
// {
//     employee.Accept(employeeVisitor);
// }


// ==================== observer pattern
// using Observer;

// ObserverType1 observer_type1_01 = new ObserverType1("Alireza Asadi");
// ObserverType1 observer_type1_02 = new ObserverType1("Payam Broumand");
// ObserverType1 observer_type1_03 = new ObserverType1("Behrouz Zammani");
// ObserverType2 observer_type2_01 = new ObserverType2("Babak Zarei");

// ICeleberity celeberity = new Celeberity("code2learn page");
// celeberity.Register(observer_type1_01);
// celeberity.Register(observer_type1_02);
// celeberity.Register(observer_type1_03);
// System.Console.WriteLine("Celeberity Register 3 observers");
// System.Console.WriteLine("Celeberity flag value changed to 5");
// System.Console.WriteLine("--------------------------------------");
// celeberity.Flag = 5;

// System.Console.WriteLine();
// System.Console.WriteLine("Celeberity UnRegister Behrouz Zammani");
// celeberity.UnRegister(observer_type1_03);
// System.Console.WriteLine("Celeberity flag value changed to 1");
// System.Console.WriteLine("--------------------------------------");
// celeberity.Flag = 1;

// System.Console.WriteLine();
// System.Console.WriteLine("Celeberity Register Behrouz Zammani");
// celeberity.Register(observer_type1_03);
// System.Console.WriteLine("Celeberity flag value returns to 5");
// System.Console.WriteLine("--------------------------------------");
// celeberity.Flag = 5;


// ----------------- Strategy Pattern
using Strategy;
 
Vehicle vehicle = new Vehicle("Vehicle_Name");
vehicle.AboutVehicle();

System.Console.WriteLine();
System.Console.WriteLine("change vehicle behavior for float");
vehicle.SerNewBehavioe(new FloatBehavior());
vehicle.AboutVehicle();

System.Console.WriteLine();
System.Console.WriteLine("change vehicle behavior for fly");
vehicle.SerNewBehavioe(new FlyBehavior());
vehicle.AboutVehicle();

Console.ReadKey();
