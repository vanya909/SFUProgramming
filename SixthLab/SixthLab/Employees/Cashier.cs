using System;

namespace SixthLab
{
    class Cashier : Employee
    {
        public override int WorkTime()
        {
            return Convert.ToInt32((DateTime.Now - DateOfEmployment).TotalDays);
        }

        public override string WhatYouDo()
        {
            return "Пополняю транспортные карты";
        }
    }
}
