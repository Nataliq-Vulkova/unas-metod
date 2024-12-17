using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class zad_2
    {
        static void promenlivi(int x, int y, int z)
        {
            x += 5;
            y *= x;
            z = 10 * y;
            Console.WriteLine("x= " + x);
            Console.WriteLine("y= " + y);
            Console.WriteLine("z= " + z);
        }
        static void Main(string[] args)
        {
            promenlivi(8, 3, 4);
        }
    }
}
