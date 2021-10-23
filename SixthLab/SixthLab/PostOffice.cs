using System;
using System.Collections.Generic;

namespace SixthLab
{
    class PostOffice
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void Poll()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee.Say());
                Console.WriteLine(employee.WorkTime());
                Console.WriteLine(employee.WhatYouDo());
                Console.WriteLine();
            }
        }
    }
}
