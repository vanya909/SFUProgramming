using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthLab.Animal
{
    class Dog : Animal, ICanPutOnMask
    {
        private bool _isHaveMask;
        public bool IsHaveMask
        {
            get => _isHaveMask;
            set => _isHaveMask = value;
        }
    }
}
