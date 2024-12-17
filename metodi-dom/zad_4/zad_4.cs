using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class zad_4
    {



        static void x()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int c = 1;
            while (n >= i)
            { 
            c = c * i;
                i++;
            }
              Console.WriteLine(i);
            }
            static void Main(string[] args)
            {
            Console.WriteLine("Въведи число: ");
                x();
            }
    }
}
