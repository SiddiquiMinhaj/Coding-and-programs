using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProj
{
    public delegate void add(int a, int b);
    public delegate string delname(string str); 
    internal class Practice
    {
        public void Addnums(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static string Say(string Name)
        {
            return "Hello" + Name;
        }

        static void Main()
        {
            Practice p=new Practice();
            add ad = new add(p.Addnums);
            ad.Invoke(10, 20);

            delname d = new delname(Practice.Say);
            string str = d("Sameer");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }

        
}
