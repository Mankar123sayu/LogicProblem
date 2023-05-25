using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblem
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            int a = 0;
            int b = 1;
            int c;
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //0 1 1 2 3 5 8
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i = 2; i < x; i++) // where 2 represent index 2nd 
            {
                c = a + b;
                Console.WriteLine(c);

                a = b; // 0 = 1
                b = c; // 1 = 1 
                
               
            }
        }
    }
}
