using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class Even_Odd
    {
        public void EO(int a)
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine(a + " is a even number");
            else
                Console.WriteLine(a + " is a odd number");
        }
    }
}
