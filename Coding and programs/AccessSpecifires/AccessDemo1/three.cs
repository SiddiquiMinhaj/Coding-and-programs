using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //case3: consuming members of a class from non-child class of same project
    internal class three
    {
        static void Main()
        {
            Program p = new Program();
            p.test2();p.test5();p.test4(); 
        }
    }
}
