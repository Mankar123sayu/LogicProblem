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
/*x = 1789 <----> 9871

while(x != 0)
{
	rem = x % 10
	reverse = reverse * 10 + rem
	x = x / 10
}

rem = 1789 % 10 ---> 9
(N)reverse = (0 * 10) + 9 = 9
(N)x = 1789 / 10 = 178

rem = 178 % 10 ----> 8
(N)reverse = (9 * 10) + 8 = 98
(N)x = 178 / 10 = 17

rem = 17 % 10 ----> 7
(N)reverse = (98 * 10) + 7 = 987
(N)x = 17 / 10 = 1

rem = 1 % 10 ----> 1
(N)revrse = (987 * 10) + 1 = 9871
(N)x = 1 / 10 = 0.1 = 0

(N)reverse = 9871
*/