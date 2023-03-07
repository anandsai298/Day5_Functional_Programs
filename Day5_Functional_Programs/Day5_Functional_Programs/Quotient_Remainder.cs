using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class Quotient_Remainder
    {
        public void QR(double Divident, double Divisor)
        {
            double Quotient = 0, Remainder = 0;
            Divident = Convert.ToInt32(Console.ReadLine());
            Divisor = Convert.ToInt32(Console.ReadLine());
            Quotient = (Divident / Divisor);
            Remainder = (Divident % Divisor);
            Console.WriteLine("Quotient" + Quotient + "\nRemainder" + Remainder);
        }
    }
}
