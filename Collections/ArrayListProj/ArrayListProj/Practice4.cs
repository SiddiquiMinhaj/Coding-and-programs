using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListProj
{
    internal class Practice4
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200); al.Add(300); al.Add(400); al.Add(500);
            Console.WriteLine(al.Capacity);

            foreach(object o in al)
                Console.WriteLine(o+" ");
            Console.WriteLine("\n");

            al.Insert(2,600);
            foreach(object o in al)
                Console.WriteLine(o + " ");
            Console.WriteLine("\n");

            al.Remove(600);
            foreach(object o in al)
                Console.WriteLine(o + " ");
            Console.WriteLine("\n");

            al.RemoveAt(2);
            foreach(Object o in al)
            Console.WriteLine(o + " ");
            Console.WriteLine("\n");

            Console.ReadLine();



        }
    }
}
