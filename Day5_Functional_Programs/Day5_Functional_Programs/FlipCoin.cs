using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class FlipCoin
    {
        const double VALIDATION_CHECK = 0.5;
        public void Flip(int NoOfTimes)
        {
            int Head = 0, Tail = 0;
            Random random = new Random();
            for (int i=0;i< NoOfTimes;i++)//percentage of head and tail
            { 
                double Value = random.NextDouble();//default 0 to 1
                if (Value < VALIDATION_CHECK)
                    Tail++;
                else
                    Head++;
            }
            double Percentage_Head = (double)Head / NoOfTimes * 100;
            double Percentage_Tail = (double)Tail / NoOfTimes * 100;
            Console.WriteLine("Head percentage ----> " + Percentage_Head + "\n" +"count Head"+Head+ "\n" + "Tail percentage ----> " + Percentage_Tail+ "\n"+"count Tail"+Tail);
        }
    }
}
