//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegatesProj
//{
//    public delegate double del1(int x, float y, double z);
//    public delegate void del2(int x, float y, float z);
//    public delegate bool del3(string str);
//    internal class genericDelegate
//    {
//        public static double addnums(int x, float y, double z)
//        {
//            return x + y + z;
//        }

//        public static void addnums2(int x, float y, double z)
//        {
//            Console.WriteLine(x+y+z);
//        }

//        public static bool checklength(string str)
//        {
//            if (str.Length > 5) ;
//            return true;
//        }

//        static void Main()
//        {
//            del1 obj = addnums;
//            double result = obj.Invoke(100, 34.5f, 193.65);
//            Console.WriteLine(result);

//            del2 obj2 = addnums2;
//            obj2.Invoke(100, 34.5f, 193.652);

//            del3 obj3 = checklength;
//            bool status = obj3.Invoke("Hello");

//            Console.ReadLine();

                 

//        }



//    }
//}
