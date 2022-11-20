using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareValue
{
    internal class Generic2<T> //here I have applied type parameter directly to class hence i'm not required to apply for below methods under the same class
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a; // dynamic allowed you to declare variable using this keyword dynamic, this will identifiy the variable at run time
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }

        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }

    class testGenerics // henre I have created new class to overcome the error
    { 
        static void Main()
        {
            Generic2<int> a = new Generic2<int>();
            a.Add(10, 20); a.Sub(10, 20); a.Mul(10, 20); a.Div(20, 2);
            Console.ReadLine();
        }

    }
}
