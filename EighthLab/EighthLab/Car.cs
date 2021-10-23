using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EighthLab
{
    class Car
    {
        public int Number { get; set; }
        public Engine Engine { get { return _engine; } }
        private Engine _engine;

        public Car(int pedalSize)
        {
            _engine = new Engine() { Size = pedalSize };
        }
    }
}
