using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareValue
{
    internal class GenericType
    {

      public bool CompareT<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            GenericType CompT=new GenericType();
            bool result = CompT.CompareT<float>(12.3f, 12.3f);
                      
            Console.WriteLine("result for object value: " + result);

            Console.ReadLine();
        }
    }
}

