using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class zad_5
    {
        static void ogledalno()
        { 
        int a = int.Parse(Console.ReadLine());
            int b = a;
            double i = 0;
            double s = 0;
            while (b > 0)
            {
                b = b / 10;
                i++;
            }
            i = i - 1;
            while (a > 0)
            {
                int r = a / 10;
                a = a / 10;
                s = s + Math.Pow(10, i) * r;
                i--;
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число: ");
            ogledalno();
        }
    }
}
