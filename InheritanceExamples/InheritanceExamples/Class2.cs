using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    class Class2:Class1 //inherited class1
    {
        public void test3()

        {
            Console.WriteLine("Method 3");
        }
        static void Main()  // in this method I called test1 and test2 method from class 1
        {
            Class2 c = new Class2();
            c.test1();
            c.test2();
            c.test3();
            Class1 p;
            p=c;// We can initialize a parent class variable by using child class instance to make is a reference
            p.class1();
            //below I'm calling  pre-defined classes of libraries, and parent class of onject is Sysytem 
            object obj=new object();
            Console.WriteLine(obj.GetType());
            Class1 a= new Class1();
            Console.WriteLine(a.GetType());
            Class2 x=new Class2();
            Console.WriteLine(x.GetType());
            Console.ReadLine();

            
        }
    }
}
