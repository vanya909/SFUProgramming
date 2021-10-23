using System;

namespace SixthLab
{
    class Program
    {
        static string[] namesList = new string[]
        {
            "Иван",
            "Пётр",
            "Александр",
            "Алексей",
            "Дмитрий",
            "Денис",
            "Митрофан",
            "Шамиль"
        };

        static void Main(string[] args)
        {
            PostOffice postOffice = new PostOffice();

            for (int i = 0; i < 8; i++)
            {
                Random random = new Random();
                DateTime dateOfEmployment = new DateTime(random.Next(1990, 2021), random.Next(1, 12), random.Next(1, 28));

                if (i % 3 == 0)
                {
                    postOffice.Employees.Add(new Cashier()
                    {
                        Name = namesList[i],
                        DateOfEmployment = dateOfEmployment
                    });
                } 
                else if (i % 3 == 1)
                {
                    postOffice.Employees.Add(new Operator()
                    {
                        Name = namesList[i],
                        DateOfEmployment = dateOfEmployment
                    });
                }
                else
                {
                    postOffice.Employees.Add(new Postman()
                    {
                        Name = namesList[i],
                        DateOfEmployment = dateOfEmployment
                    });
                }  
            }

            postOffice.Poll();
        }
    }
}
