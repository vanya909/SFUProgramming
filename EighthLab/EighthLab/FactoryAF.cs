using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EighthLab
{
    class FactoryAF
    {
        public List<Car> Cars { get; } = new List<Car>();
        public List<Customer> Customers { get; } = new List<Customer>();

        public void AddCar(int pedalSize) { Cars.Add(new Car(pedalSize) { Number = Cars.Count + 1 }); }
        public void SaleCar() 
        {
            foreach(Customer customer in Customers)
            {
                if (customer.Car is null)
                {
                    if (Cars.Any())
                    {
                        customer.Car = Cars[0];
                        Cars.Remove(Cars[0]);
                    }
                }
            }

            if (Cars.Any())
            {
                Cars.Clear();
            }
        }
    }
}
