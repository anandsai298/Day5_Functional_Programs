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
                Console.WriteLine("1.FILPCOIN \n2.LeapYear \n3.PowerOf2 \n4.HarmonicNumber \n5.PrimeFactorial \n6. EXit");
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
                        flag = false;
                        break;
                }

            }
        }
    }
}
