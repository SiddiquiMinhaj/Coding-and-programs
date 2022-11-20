using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgramConstructor
{
    internal class ParameterizedConDemo
    {
        int x;
        public ParameterizedConDemo(int i)
        {
            x= i;
            Console.WriteLine("parameterized constructor is called"+i);
        }

        public void Display()
        {
            Console.WriteLine("Value of X is"+x);
        }
        static void Main()
        {
            ParameterizedConDemo cd = new ParameterizedConDemo(10);
            ParameterizedConDemo cd1 = new ParameterizedConDemo(20);
            cd.Display();
            cd1.Display();
            Console.ReadLine(); 
            

        }
    }
}
