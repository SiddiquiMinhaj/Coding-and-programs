using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandeling
{

    // in this program, we will perform an exception task for user defined exception
    //the condition is any number should not be divided by ODD number, as this is not a universal rule like devide by zero hence we have to create the own exception
    internal class UserdefinedException
    {
        static void Main(string[] args)
        {
            
                int x, y, result;
                Console.WriteLine("Enter the number1");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number2");
                y = Convert.ToInt32(Console.ReadLine());
            if (y % 2 > 0) // here I put condition so divisor/the second value should no be odd number
            {
                throw new ApplicationException();
                
            }
                result = x / y;
                Console.WriteLine("Sum of two numbers: " + result.ToString());
            

          

            Console.WriteLine("end of program");
            Console.ReadLine();

            //Console.WriteLine("{0}+{1}={2}",x,y,result);

            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey(); 
        }
    }
}
