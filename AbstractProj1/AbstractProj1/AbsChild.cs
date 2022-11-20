using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProj1
{
    internal class AbsChild:AbsParent
    {
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Main()  // we cannot creat the instance of abstract class
        {
            AbsChild c = new AbsChild();
            c.Add(150, 45); c.Sub(78, 23);
            
            Console.ReadLine();
        }
    }
}
