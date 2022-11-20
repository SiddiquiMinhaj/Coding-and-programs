using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace otherProject
{
    internal class OtherChild:AccessSpecifiersTest.Case1
    {
        public void Main()
        {
            OtherChild od=new OtherChild();
            od.prot();od.pblc();od.prtint();
            Console.ReadLine();
        }
    }
}
