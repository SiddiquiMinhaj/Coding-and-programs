using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DelegatesProj
{
    public delegate string GreetingDelegate(string name); // define delegate
    internal class AnonymosDelegate 
    {
              
         
        static void Main()
        {
            GreetingDelegate obj = delegate (string Name) //instantiating 
            {
                return "Hello " + Name + "A very Good Morning";
            };
            string str = obj.Invoke("Scott "); //calling delegate
            Console.WriteLine(str);
        }


    }
}
