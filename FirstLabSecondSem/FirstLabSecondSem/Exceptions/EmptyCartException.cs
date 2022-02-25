using System;

namespace FirstLabSecondSem
{
    class EmptyCartException : Exception
    {
        public EmptyCartException(string message) : base(message) { }
    }
}
