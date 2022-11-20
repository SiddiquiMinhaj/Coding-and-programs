using System;
using System.Collections;
namespace HashTableProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("EId", 1010);
            ht.Add("Ename", "Minhaj");
            ht.Add("Job", "Manager");
            ht.Add("Salary",100000);
            ht.Add("MgrId", 002);
            ht.Add("Phone", "22558899");
            ht.Add("Email", "ssidn@gmail.com");
            ht.Add("Dname", "Sales" );
            ht.Add("Location","Mumbai");
            ht.Add("DId", 20);
                    
         // Console.WriteLine(ht["Email"]); //to display the value of email key


            foreach(object key in ht.Keys)
                Console.WriteLine(key+ ": " + ht[key]);

            Console.ReadLine();




        }
    }
}