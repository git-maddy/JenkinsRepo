using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionaleg
{

    /*switch(case)
        * {
        * case 1: statements; break;
        * case 2:set of statements;break;;
        * 
        * case n:set of statements;break;
        * default:set of statements;break;
        }
            */
    class switchcaseeg
    {
        static void Main()

        {

            int num;

            Console.WriteLine("Enter the number"); 
            
            num =  Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");

                        break;
                    }

                case 2:
                    
                    Console.WriteLine("Tuesday");

                    break;

                case 3:

                    Console.WriteLine("Wednesday");

                    break;

                case 4:
                    Console.WriteLine("Thursday");

                    break;

                case 5:

                    Console.WriteLine("Friday");

                    break;

                case 6:

                    Console.WriteLine("Saturday");

                    break;

                default:

                    Console.WriteLine(" Invalid number");

                    break;
            }

            Console.Read();
        }



                

               
    }

                
}
