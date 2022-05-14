using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class ploshad
    {
        public ploshad(int a, int b, Kvadrat figura)
        {
            Kvadrat k = new Kvadrat(a, b);
            Console.WriteLine(k.Ploshad());

        }
        public ploshad(int radius, Krug figura)
        {
            Krug k = new Krug(radius);
            Console.WriteLine(k.Ploshad());

        } 
        public ploshad(int radius)
        {
            Krug k = new Krug(radius);
            Console.WriteLine(k.Ploshad());

        }
        public ploshad(int a, int b)
        {
            int[] g = new int[2] { a, b };
            int max = g.Max();
            int min = g.Min();
            int r = max - min;
            if(r >= 1)
            {
                rectangulartr rect = new rectangulartr(a, b);
                Console.WriteLine(rect.Ploshad());
            }
            else
            {
                Kvadrat k = new Kvadrat(a, b);
                Console.WriteLine(k.Ploshad());
            }
        }
        public ploshad(int a, int b, int c, treygolnik figura)
        {
            treygolnik k = new treygolnik(a, b, c);
            Console.WriteLine(k.Ploshad());

        }
        public ploshad(int a, int b, int c)
        {
            treygolnik k = new treygolnik(a, b, c);
            Console.WriteLine(k.Ploshad());


        }
    }
}
