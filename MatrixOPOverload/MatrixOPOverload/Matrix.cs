using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOPOverload
{
    internal class Matrix
    {
        int a, b, c, d, e, f;
        public Matrix(int a, int b, int c, int d, int e, int f)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e; 
            this.f = f;
        }

        public override string ToString()
        {
            return a+" "+b+" "+c+"\n"+d+" "+e+" "+f+" \n";
        }

        public static Matrix operator+(Matrix obj1, Matrix obj2)
        {
            Matrix obj= new Matrix(obj1.a+obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d, obj1.e + obj2.e, obj1.f + obj2.f);
            return obj;
        }

        public static Matrix operator *(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a * obj2.a, obj1.b * obj2.b, obj1.c * obj2.c, obj1.d * obj2.d, obj1.e * obj2.e, obj1.f * obj2.f);
            return obj;
        }


    }

    class testMatrix
    {
        public static void Main()
        {
            Matrix m1 = new Matrix(1,2,3,4,5,6);
            Matrix m2 = new Matrix(11,12,13,14,15,16);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 * m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.ReadLine();

        }
    }
}
