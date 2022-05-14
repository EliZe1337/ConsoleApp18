using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class treygolnik : IFigura<int>
    {
        int a;
        int b;
        int c;
        public treygolnik(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int Ploshad()
        {
            return (a + b + c) / 2;
        }
    }
}
