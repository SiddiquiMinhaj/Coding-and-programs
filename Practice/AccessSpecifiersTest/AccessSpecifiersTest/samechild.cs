using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiersTest
{
    internal class samechild : Case1
    {
        static void Main()
        {
            samechild obj=new samechild();
            obj.intrnl(); obj.prot(); obj.prtint(); obj.pblc(); 
            Console.ReadLine();
        }
    }
}
