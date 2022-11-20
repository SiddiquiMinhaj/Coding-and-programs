using System;
using System.Collections;

namespace ArrayListProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList(); //creating instance of the array list, as we know we already have class ArrayList under System.Collections namespace
            ArrayList al = new ArrayList(10);// in above instance was paramereless constructor but here I pass parameter with value 10, which is initial capacity. so
                                             // the capasity will get increased by 10
            Console.WriteLine(al.Capacity); //capacity is a property which tell the number of items that can be stored under a collection.
            al.Add(100); // array list has feature of Add(), this will add item in array list at the end of the Arraylist
            Console.WriteLine(al.Capacity);
            al.Add(200); al.Add(300); al.Add(400); al.Add(500);// here I'm keeps adding values to array the default capacity was 4 but I added 5 so it automatically doubled to 8
            Console.WriteLine(al.Capacity);

            foreach(object obj in al) // to print values on screen
                Console.WriteLine(obj+ " ");
            Console.WriteLine();

            al.Insert(3, 350); // to insert an item
            foreach(object obj in al)
                Console.WriteLine(obj+" ");

            al.Remove(200); // to remove item
            foreach(object obj in al)
                Console.WriteLine(obj+" ");

            al.RemoveAt(1); // to remove item through index number
            foreach(object obj in al)
                Console.WriteLine(obj+" ");

            Console.ReadLine();


        }
    }
}