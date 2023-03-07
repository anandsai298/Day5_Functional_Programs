using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class PrimeFactorial
    {
        public void Factors(int num)
        {
            for (int i=2;i<num;i++)//to get exact number div by num
            {
                int count = 0;
                if(num%i==0)
                {
                    for (int j=1;j<=i;j++)//prime or not
                    {
                        if(i%j==0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                        Console.WriteLine("prime factor ==>" + i);
                }
            }
        }
    }
}
