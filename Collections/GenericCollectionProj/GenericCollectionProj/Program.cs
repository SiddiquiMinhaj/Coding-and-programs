using System;
using System.Collections.Generic;
namespace GenericCollectionProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> li=new List<int>();
            li.Add(10); li.Add(20); li.Add(30); li.Add(50);

            //for (int i = 0; i <= li.Count; i++)
            //    Console.Write(li[i]+" ");
            //Console.WriteLine();

            foreach (int i in li)
                Console.Write(i + " ");
                    Console.WriteLine();
            Console.ReadLine();

            li.Insert(3, 60);
            foreach(int i in li)
                Console.WriteLine(i + " ");
            Console.WriteLine();

            li.RemoveAt(0);
            foreach(int i in li)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }
    }
}