using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProj
{
    internal class TestEmployee
    { 
        static void Main()
        {
            Employee Emp = new Employee(001,"Shah","Software","Engineer","Pune",100000);
            // below indexers are to capture the value not assigning 
            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Dnam: " + Emp[3]);
            Console.WriteLine("Location: " + Emp[4]);
            Console.WriteLine("Salary: " + Emp[5]);

            Emp[3] = "Manager";
            Emp[4] = "Solapur";
            Console.WriteLine("\n");

            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Dnam: " + Emp[3]);
            Console.WriteLine("Location: " + Emp[4]);
            Console.WriteLine("Salary: " + Emp[5]);


        }
    }
}
