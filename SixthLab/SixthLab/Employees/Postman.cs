using System;

namespace SixthLab
{
    class Postman : Employee
    {
        public override int WorkTime()
        {
            return DateTime.Now.Year - DateOfEmployment.Year;
        }

        public override string WhatYouDo()
        {
            return "Разношу почту, не мешайте";
        }
    }
}
