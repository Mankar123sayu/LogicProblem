using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblem
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int reverse = 0 ;
            int rem;

            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            while(x!= 0)
            {
                rem = x % 10;
                reverse = reverse * 10 + rem;
                x= x / 10;  
            }
            Console.WriteLine($"reverse number is {reverse}");
        }
    }
}
