using System;
using System.Collections.Generic;

namespace SeventhLab
{
    class Commander
    {
        public List<Employee> Employees { get; } = new List<Employee>();
        public List<Employee> Team { get; } = new List<Employee>();


        public void PrintBadge(Cashier cashier)
        {
            Console.WriteLine(cashier.GetFullName());
        }

        public void PrintBadgeForAllCashiers()
        {
            foreach (Employee employee in Employees)
            {
                if (employee is Cashier cashier)
                    PrintBadge(cashier);
            }
        }

        public void PrintTeam()
        {
            foreach(Employee employee in Team)
            {
                if (employee.GetType().IsInstanceOfType(typeof(Cashier)))
                {
                    PrintBadge((Cashier)employee);
                }
                else
                {
                    Console.WriteLine(employee.GetFullName());
                }
            }
        }
    }
}
