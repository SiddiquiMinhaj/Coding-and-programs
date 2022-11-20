using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingProject
{
    internal class Parent
    {
        public virtual void test1() // overriding
        {
            Console.WriteLine("Method test1 from parent class");
        }
        public void test2()
        {
            Console.WriteLine("Method test2 from parent class");
        }

    }

    class child : Parent
    {
        public override void test1() //method overriding 
        {
            Console.WriteLine("Method test1 from child class");


        }

        public new void test2() // (method hiding)here i did the same like override but without Virtual method
        {
            Console.WriteLine("Method test2 from child class");

        }

        public void ParentTest1()
        {
            base.test1();//base keyword is use to call parent methods and base kr=eyword cant be used iwth static methods 
        }  // these both classes where we used base keyword will act as interface for calling parent class mrthods from child class
        public void ParentTest2()
        {
            base.test2();
        }
        static void Main()
        {
            child c = new child(); //c is instance of child class
            Parent p = c; // p is reference of parent class created by using child's instance
            p.test1(); //invokes child class method
            p.test2(); ////invokes parent class method
            
            //c.test1();
            //c.test2();
            //c.ParentTest1 ();
            //c.ParentTest2();
            Console.ReadLine();
        }
    }
}

