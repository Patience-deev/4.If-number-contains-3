using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.If_number_contains_3
{
    internal class Program
    {
        public static bool IfNumberContains3(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }

                number /= 10;
            }

            return false;

        }
        public static void Main()
        {
            Console.WriteLine(IfNumberContains3(7201432));   
            Console.WriteLine(IfNumberContains3(87501));

            Console.ReadLine();
        }
    }



}

