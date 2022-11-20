using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{
    internal class JoinMethodThred
    {
        static void test1()
        {
            Console.WriteLine("thread 1 is Statrting");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test1: "+ i);
            
            Console.WriteLine("thread 1 is Exiting");
        }

        static void test2()
        {
            Console.WriteLine("thread 2 is Statrting");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test1: " + i);
            Console.WriteLine("thread 2 is Exiting");
        }

        static void test3()
        {
            Console.WriteLine("thread 3 is Statrting");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Test1: " + i);
            Console.WriteLine("thread 3 is Exiting");
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");
            Thread t1=new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join(); t2.Join(); t3.Join();// here I am calling joinso the main program will not exit from the program until child threads are finishing their job 
            Console.WriteLine("main thread Exiting: ");
            Console.ReadLine();
        }
    }
}
