using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface ItestInterface
    {
        // int x;  variables are not allowed in interface(remove comment for error details)
    
        void add(int a, int b);
        
    }

    interface Itestinterface2: ItestInterface //an interface can inherit from another interfacec 
    {
        void Sub(int a, int b);

    }

    class implementationClass:Itestinterface2// here we're implementing the interface
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }


        static void Main()
        {
            implementationClass p = new implementationClass();
            Itestinterface2 i = p; // way of implementation 
            i.add(1, 2);
            i.Sub(1, 2);
            
           // p.add(1, 2);  another way of implementation
           // p.Sub(3, 2);
            Console.ReadLine();
        }
    }
    
}
