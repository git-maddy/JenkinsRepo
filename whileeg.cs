using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionaleg
{
    class @whileeg
    {
        static void Main()

        {
            int endvalue, initialvalue = 1;

            Console.WriteLine("Enter the number");

            endvalue = Convert.ToInt32(Console.ReadLine());

            while (initialvalue <= endvalue)

                //console.WriteLine("initialvalue: {0}", initialvalue);

                initialvalue++;

            if (initialvalue % 2 == 0)

            {
                Console.WriteLine("{0}is even", initialvalue);
            }
           
            Console.Read();

        }

    }
}
