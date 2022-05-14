using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class rectangulartr : IFigura<int>
    {
        int a;
        int b;

        public rectangulartr(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Ploshad()
        {
            return (a * b) / 2;
        }
    }
}
