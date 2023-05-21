using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblem
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int a;
            int b;
            int c;

            Console.Write("Enter a numbar in Minimum range: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number in maximum range: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // a = 28
            // b = 1....28
            // c = 1+2+4+7...
            for(a = x; a <= y; a++)
            {
                b = 1;
                c = 0;
                while(b < a)
                {
                    if (a % b == 0)
                    {
                        c = c + b;
                    }
                    b++;
                }
                if (c == a)
                {
                    Console.WriteLine($"{a} Perfect number");
                }
               
            }
        }
            

    }
}

