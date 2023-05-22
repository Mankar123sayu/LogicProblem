using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblem
{
    public class PrimeNumber
    {
     public void Prime()
        {
            //2,3,5,7,11
            int count = 0;
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= x; i++)
            {
                if(x % i == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                Console.WriteLine($"{x} is a prime number");
            }
            else
            {
                Console.WriteLine($"{x} is not a prime number");
            }
            
        }
    }
}
