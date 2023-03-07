using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class Swap_2_Nums
    {
        public void Swap(int x,int y)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping of two number" + x +"and" + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("after swapping of two number" + x +"and" + y);
        }
    }
}
