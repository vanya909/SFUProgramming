using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLabSecondSem
{
    internal class TopServices
    {
        
        public string Service { get; set; }
        public int Count { get; set; }

        public TopServices(string service, int count)
        {
            Service = service;
            Count = count;
        }

        public override string ToString()
        {
            return Service + ":" + Count;
        }
    }
}
