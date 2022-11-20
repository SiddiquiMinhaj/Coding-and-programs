using System.Diagnostics.CodeAnalysis;

namespace Exceptionhandeling
{
    public class Program
    {
        

        
        static void Main(string[] args)
        {
            try
            {
                int x, y, result;
                Console.WriteLine("Enter the number1");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number2");
                y = Convert.ToInt32(Console.ReadLine());
                if (y == 1) { return; }
                result = x / y;
                Console.WriteLine("Sum of two numbers: " + result.ToString());
            }

            catch (DivideByZeroException )    
            {
                Console.WriteLine("Devide by zero not allowed");
                
            }

            catch (FormatException )
            {
                Console.WriteLine("incorrect input");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            finally
            {
                Console.WriteLine("Finally block executed");
            }

            Console.WriteLine("end of program");
            Console.ReadLine();

            //Console.WriteLine("{0}+{1}={2}",x,y,result);

            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey(); 
        }
    }
}