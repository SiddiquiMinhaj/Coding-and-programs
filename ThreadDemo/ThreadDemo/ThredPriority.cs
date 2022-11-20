using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ThreadDemo
{
    internal class ThredPriority
    {
        static long count1, count2;
        public static void IncrementCount()
        {
            while (true)
                count1 += 1;
        }

        public static void IncrementCount2()
        {
            while (true)
                count1 += 1;
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCount);
            Thread t2= new Thread(IncrementCount2);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread going to sleep");
            Thread.Sleep(10000); // after starting the thread main method is going to sleep for 10  seconds 
            Console.WriteLine("Main thread woke up");
            t1.Abort(); // with the help of about function we can terminate the respective method little bit
            t2.Abort();
            
            t1.Join();
            t2.Join();

            Console.WriteLine("Count 1: "+count1);
            Console.WriteLine("Count 1: " + count2);

            Console.ReadLine();
        }

    }
}
