using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProj
{
    internal class LambdaExp
    {
       

        static void Main()
        {
            GreetingDelegate obj = delegate (string name)
            {
                return "Hello" + name + "A very GM";
            };
            string str = obj.Invoke("Raju");
            obj.Invoke(str);
            Console.ReadLine();
        }
    }
}
