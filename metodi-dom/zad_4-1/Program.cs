using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4_1
{
    internal class Program
    {
        static void x()
        {
        int n = int.Parse(Console.ReadLine());
        int i = int.Parse(Console.ReadLine());
            i = n % 10;
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            x();
        }
    }
}
