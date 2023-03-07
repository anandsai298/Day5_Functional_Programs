using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Functional_Programs
{
    public class vowel_Constant1
    {
        public void Alphabet()
        {
            Char z;
            z = Char.ToLower(Convert.ToChar(Console.ReadLine()));
            switch(z)
            {
                case 'a':
                    Console.WriteLine("The alphabet is a VOWEL");
                    break;
                case 'e':
                    Console.WriteLine("The alphabet is a VOWEL");
                    break;
                case 'i':
                    Console.WriteLine("The alphabet is a VOWEL");
                    break;
                case 'o':
                    Console.WriteLine("The alphabet is a VOWEL");
                    break;
                case 'u':
                    Console.WriteLine("The alphabet is a VOWEL");
                    break;
                default:
                    Console.WriteLine("The alphabet is a CONSTANT");
                    break;
            }
        }
    }
}
