using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //case 2: here we're consuming members of a class from child class ie. Program
    internal class two:Program    //this is inheritance 
    {
        static void Main()
        {
            two t=new two();
            t.test2(); t.test3(); t.test4(); t.test5();
            Console.ReadLine();
        }
    }
}
