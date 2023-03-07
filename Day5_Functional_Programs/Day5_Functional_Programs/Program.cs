// See https://aka.ms/new-console-template for more information
using System;
namespace Day5_Functional_Programs
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the day_05 Functional Programs: ");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.FILPCOIN \n2.LeapYear \n3.PowerOf2 \n4.HarmonicNumber \n5.PrimeFactorial \n6.Quotient_Remainder\n7.Swap_2_Nums\n8.Even_Odd\n9. EXit");
                Console.WriteLine("enter your option to print output");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        FlipCoin fc = new FlipCoin();
                        Console.WriteLine("enter no of flips --> ");
                        int NoOfTimes = Convert.ToInt32(Console.ReadLine());
                        fc.Flip(NoOfTimes);
                        break;
                    case 2:
                        LeapYear Yr = new LeapYear();
                        Yr.LY();
                        break;
                    case 3:
                        Power_2 p = new Power_2();
                        p.Show(5);
                        break;
                    case 4:
                        HarmonicNumber hn = new HarmonicNumber();
                        Console.WriteLine("enter Harmonic number value");
                        hn.HN(5);
                        break;
                    case 5:
                        PrimeFactorial PM = new PrimeFactorial();
                        Console.WriteLine(" prime factors of 15 is :");
                        PM.Factors(15);
                        break;
                    case 6:
                        Quotient_Remainder qr = new Quotient_Remainder();
                        Console.WriteLine("Quotient and reaminder of divident=10 and divisor=5 is :");
                        qr.QR(10, 5);
                        break;
                    case 7:
                        Swap_2_Nums swap = new Swap_2_Nums();
                        Console.WriteLine("Swapping of two numbers");
                        swap.Swap(2, 3);
                        break;
                    case 8:
                        Even_Odd eo = new Even_Odd();
                        Console.WriteLine("even or odd of an number");
                        eo.EO(90);
                        break;
                    case 9:
                        flag = false;
                        break;
                }

            }
        }
    }
}
