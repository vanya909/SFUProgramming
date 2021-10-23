using System;

namespace EighthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factory = new FactoryAF();
            factory.Customers.Add(new Customer { FIO = "Abc a. c." });
            factory.Customers.Add(new Customer { FIO = "Bbb s. d." });
            factory.Customers.Add(new Customer { FIO = "Asdb s. d." });

            foreach(Customer customer in factory.Customers)
            {
                Console.WriteLine(customer.FIO);
                Console.WriteLine(customer.Car is null ? false : customer.Car.Engine.Size);
            }

            factory.AddCar(12);
            factory.AddCar(20);
            factory.SaleCar();

            foreach (Customer customer in factory.Customers)
            {
                Console.WriteLine(customer.FIO);
                Console.WriteLine(customer.Car is null ? false : customer.Car.Engine.Size);
            }
        }
    }
}
