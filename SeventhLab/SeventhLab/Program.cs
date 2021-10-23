using System;

namespace SeventhLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Commander commander = new Commander();
            string[] qualifications = { "Стажер", "Касир", "Старший кассир" };

            for (int i = 0; i < 10; i++)
            {
                Employee cashier = new Cashier()
                {
                    FirstName = "Иван" + i,
                    LastName = "Попов" + i,
                    Qualification = qualifications[i % 3]
                };

                commander.Employees.Add(cashier);

                if (i % 2 == 0)
                    commander.Team.Add(cashier);
                else
                    commander.Team.Add(new Loader()
                    {
                        FirstName = i + "",
                        LastName = (i + 1) + ""
                    });
            }

            commander.PrintTeam();
            Console.WriteLine();
            commander.PrintBadgeForAllCashiers();
            Console.WriteLine();
            commander.PrintBadge((Cashier)commander.Employees[0]);
        }
    }
}
