using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Kvadrat : IFigura<int>
    {
        public int a;
        public int b;
        public Kvadrat(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Kvadrat()
        {
            
        }
        public int Ploshad()
        {
            return a * b;
        }
    }
}
