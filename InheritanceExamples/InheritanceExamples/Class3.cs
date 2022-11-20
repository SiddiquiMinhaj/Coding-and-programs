using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{ //	here We can initialize a parent class variable by using chil class instance to make is a reference.
    internal class Class3:Class2
    {
        public void class3()
        {
            Console.WriteLine("Class 3 called");
        }
        static void Main()
        {
            Class2 p;
            Class2 c=new Class2();//c is instance of class2
            p = c;// here p is a reference of parent class created by usin child class instance
           
        }
    }
}
