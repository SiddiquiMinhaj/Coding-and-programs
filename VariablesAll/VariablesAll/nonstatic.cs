using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAll
{
    internal class nonstatic
    {
         int x;
        static int y = 100;
        static void Main(string[] args)
        {
            Console.WriteLine(y);
            nonstatic a= new nonstatic();

            Console.WriteLine("x=" + a.x);

        }
    }
}
