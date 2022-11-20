using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiersTest
{
    internal class nonchild
    {
        public void Main()
        {
            Case1 obj=new Case1();
            obj.intrnl();obj.prtint();obj.pblc();
            Console.ReadLine();
            
        }
    }
}
