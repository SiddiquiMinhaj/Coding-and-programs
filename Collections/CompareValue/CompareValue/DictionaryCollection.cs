using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareValue
{
    internal class DictionaryCollection
    {
        static void Main()
        {
            Dictionary <string, object> dt = new Dictionary<string, object>();
            dt.Add("EId", 1010);
            dt.Add("Ename", "Minhaj");
            dt.Add("Job", "Manager");
            dt.Add("Salary", 100000);
            dt.Add("MgrId", 002);
            dt.Add("Phone", "22558899");
            dt.Add("Email", "ssidn@gmail.com");
            dt.Add("Dname", "Sales");
            dt.Add("Location", "Mumbai");
            dt.Add("DId", 20);

            foreach(string key in dt.Keys) // here string is key that represent key value and dt.key is value thet represent actual value  
                Console.WriteLine(key + ": " + dt[key]); // here, we're going to get the output in sequence as give unlike hashtable
            Console.ReadLine();
        }

    }
}
