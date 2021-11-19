using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthLab.Human
{
    class Human : IVisitor
    {
        private string _name;
        public string Name 
        { 
            get => _name; 
            init => _name = value; 
        }
    }
}
