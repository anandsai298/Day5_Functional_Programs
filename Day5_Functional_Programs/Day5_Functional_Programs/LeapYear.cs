using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class LeapYear
    {
        public void LY()
        {
            Console.WriteLine("enter year to check it is a LeapYear are not ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0) && (Year % 100 != 0) || (Year % 400 == 0))
                Console.WriteLine(Year + " is a LeapYear ");
            else
                Console.WriteLine(Year + " is not a LeapYear ");
        }
    }
}
