using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPayRollManagementSysytem1.Modelling
{
    public class Manager
    {
        private List<Employee> employees = new List<Employee> ();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> ListEmployees()
        {
            return employees;
        }
        public void PrintEmployeeDetails()
        {
            //List<Employee> employees = ListEmployees();

            Console.WriteLine("Employee Details");

            var newTable = new ConsoleTable("Name", "Active", "Start Date", "End Date", 
                "Pay Date", "Regular Hours", "Overtime Hours");
            var newTable1 = new ConsoleTable("Regular Rate", "OverTIme Rate", "Gross Pay", 
                "Net Pay", "Medicals", "Rent", "Food");

            foreach(var employee in employees)
            {
                employee.CalculatePayRoll();
                newTable.AddRow(employee.Name, employee.IsActive, employee.StartDate, 
                    employee.EndDate, employee.PayDate, employee.RegularHours, employee.OvertimeHours);
                newTable1.AddRow(employee.RegularRate, employee.OvertimeRate, employee.GrossPay, 
                    employee.NetPay, employee.Medicals, employee.Rent, employee.Food);
            }


            newTable.Options.EnableCount = false;
            newTable1.Options.EnableCount = false;
            newTable.Write();
            newTable1.Write();
        }
    }
}
