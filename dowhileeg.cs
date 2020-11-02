using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionaleg
{
    class dowhileeg
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
            Console.WriteLine("enter the number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while (initialvalue > endvalue)
            {
                Console.WriteLine("inside while");
            }
            Console.WriteLine("------------------");
            do
            {
                Console.WriteLine("Inside Do While");
                Console.WriteLine("initialvalue: {0}", initialvalue);
                initialvalue++;

            } while (initialvalue > endvalue);
            Console.Read();
        }
    }
}
