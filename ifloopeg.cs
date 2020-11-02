using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionaleg
{
    class ifloopeg
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is the greatest");
                }
                else
                {
                    Console.WriteLine("num3 is the greatest");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("num2 is the greatest");
            else
                Console.WriteLine("num3 is the greatest");
            Console.Read();
        }
    }
}
