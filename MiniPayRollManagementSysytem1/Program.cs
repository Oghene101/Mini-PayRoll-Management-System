using MiniPayRollManagementSysytem1.Modelling;
Manager manager = new Manager();

bool cond = true;
while (cond)
{
    Console.WriteLine("Enter employee details (or type 'exit' to finish):");
   
    Console.WriteLine("Name: ");
    string name = Console.ReadLine();
    if (name.ToLower() == "exit")
        break;
    
    Console.Write("Is Active (true/false): ");
    bool isActive = Convert.ToBoolean(Console.ReadLine());

    Console.Write("Start Date (yyyy-mm-dd): ");
    DateTime startDate = DateTime.Parse(Console.ReadLine());

    Console.Write("End Date (yyyy-mm-dd): ");
    DateTime endDate = DateTime.Parse(Console.ReadLine());

    Console.Write("Pay Date (yyyy-mm-dd): ");
    DateTime payDate = DateTime.Parse(Console.ReadLine());

    Console.Write("Regular Hours: ");
    double regularHours = Convert.ToDouble(Console.ReadLine());

    Console.Write("Overtime Hours: ");
    double overTimeHours = Convert.ToDouble(Console.ReadLine());


    Employee newEmployee = new Employee(1500, 200)
    {
        Name = name,
        IsActive = isActive,
        StartDate = startDate,
        EndDate = endDate,
        PayDate = payDate,
        RegularHours = regularHours,
        OvertimeHours = overTimeHours
    };

    manager.AddEmployee(newEmployee);

    Console.WriteLine("Would  you like to add another employee (Y / N)");
    string ans = Console.ReadLine().ToUpper();
    if (ans == "Y")
        cond = true;else cond = false;
}

manager.PrintEmployeeDetails();
