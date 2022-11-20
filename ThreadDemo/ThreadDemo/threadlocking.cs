using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{
    internal class threadlocking
    {
        public void display()
        {
            lock (this) //remove this lock method then you'll see the difference 
            {
                Console.Write("C# is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Langauge");
            }
        }

        static void Main()
        {
            threadlocking obj=new threadlocking();//here we are creating an instance as we are calling non static method in static void main

            Thread t1 = new Thread(obj.display);//here loading memory in t1 for above created instance with non static method display
            Thread t2 = new Thread(obj.display);
            Thread t3=new Thread(obj.display);
            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}
