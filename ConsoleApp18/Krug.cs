using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Krug : IFigura<double>
    {
        public int a;
        public double radius;
        
        public Krug(int radius)
        {
            this.radius = radius;
        }
        public Krug()
        {
           
        }
        public Krug(int radius, int a)
        {
            this.radius = radius;
            this.a = a;
        }
        public double Ploshad()
        {
            return Math.PI * (radius * radius);
        }
    }
}
