using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Krug c = new Krug(360);
            //    var r = c.Ploshad();
            //    Krug ll = new Krug(3, 5);   
            //    Console.WriteLine(r);
            //    Kvadrat k = new Kvadrat(4, 5);
            //    var p = k.Ploshad();
            //    Console.WriteLine(p);
            //    Console.ReadLine();
            ploshad p = new ploshad(4, 4, new Kvadrat());
            ploshad p1 = new ploshad(5, 8);
            ploshad p2 = new ploshad(5, 8, 5);
            Console.WriteLine(p);
            Console.WriteLine(p1);
            Console.ReadLine();
            
        }
    }
}
