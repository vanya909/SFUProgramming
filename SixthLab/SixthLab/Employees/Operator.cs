using System;

namespace SixthLab
{
    class Operator : Employee
    { 
        public override int WorkTime()
        {
            return (DateTime.Now.Year - DateOfEmployment.Year) * 12 + 
                    DateTime.Now.Month - DateOfEmployment.Month + 
                   (DateTime.Now.Day >= DateOfEmployment.Day ? 0 : -1);
        }

        public override string WhatYouDo()
        {
            return "Ищу посылку";
        }
    }
}
