using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProj
{
    public enum days2

    {
        Monday = 1, 
        Tuesday = 22,
        Wednesday=33,
        Thursday=44,
        Friday=55,
        
    }


    internal class Enum2
    {
        static void Main()
        {
            foreach (int i in Enum.GetValues(typeof(days2))) //this will return value
            Console.WriteLine(i+":"+(days2)i);
            
        foreach (string s in Enum.GetNames(typeof(days2))) //this will return names
                Console.WriteLine(s);
                
            Console.ReadLine();
        }
    }
}
