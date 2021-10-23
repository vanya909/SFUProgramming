using System;

namespace SixthLab
{
    abstract class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfEmployment { get; set; }


        public string Say()
        {
            return Name;
        }

        public virtual int WorkTime()
        {
            return 0;
        }

        public abstract string WhatYouDo();
    }
}
