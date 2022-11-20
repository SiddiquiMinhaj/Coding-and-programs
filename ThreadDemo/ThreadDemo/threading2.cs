using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{

    //threading with delegates 
    internal class threading2
    {
        static void test()
        {
            for(int i = 1; i < 10; i++)
                Console.WriteLine("test "+i);
      }

       
        static void Main()
        {
            // ThreadStart t1 = new ThreadStart(test); first way
            // ThreadStart obj = test; second way
            //ThreadStart obj = delegate { test(); }; third way
           
            Thread t = new Thread(test);
            t.Start();
            Console.ReadLine();
        }
    }
}
