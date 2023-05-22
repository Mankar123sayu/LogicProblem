using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblem
{
    public class CouponNumber
    {
        public  void Coupon(int num)
        {
            int[] ar = new int[num];
            Random random = new Random();
            ar[0] = random.Next(0, num);

            for (int i = 1; i < num; i++)
            {
                int coupon = random.Next(0, num);
                for (int j = 1; j < i; j++)
                {
                    if (ar[j] != coupon)
                    {
                        ar[i] = coupon;
                    }
                }
                Console.WriteLine("Coupon Numbers: " + ar[i]);
            }
        }
    }
}
    

