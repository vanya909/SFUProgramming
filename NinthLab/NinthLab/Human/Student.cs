using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthLab.Human
{
    class Student : Human, ICanHaveQR, ICanDisenfectHand, ICanPutOnMask
    {
        private bool _isHaveQr;
        private bool _isHaveMask;
        public bool IsHaveQR 
        { 
            get => _isHaveQr; 
            set => _isHaveQr = value; 
        }
        public bool IsHaveMask
        {
            get => _isHaveMask;
            set => _isHaveMask = value;
        }
    }
}
