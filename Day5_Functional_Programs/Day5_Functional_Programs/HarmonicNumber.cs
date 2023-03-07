using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class HarmonicNumber
    {
        public void HN(int n)
        {
            double Num = 0,Res = 0,i;
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++)
            {
                Num += (1 / i);
                Res = Num;
            }
            Console.WriteLine("print value of Num = "+(1/i)+"Harmonic Number of " + n + " is " + Res);
        }
    }
}
