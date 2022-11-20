using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareValue
{
    internal class Customer //Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }


    }

    class testCustomer

    {
        static void Main()
        {
            List<Customer> Customer=new List<Customer>();
            Customer c1 = new Customer { CustId = 101, Name = "Shah", City = "Pune", Balance = 2500.02 };
           
            Customer c2 = new Customer { CustId = 102, Name = "Minhaj", City = "Mumbai", Balance = 2500.03 };

            Customer c3 = new Customer { CustId = 103, Name = "Mariyam", City = "Banglore", Balance = 2500.04 };

            Customer c4 = new Customer { CustId = 104, Name = "Daniyal", City = "Hydrabad", Balance = 2500.05 };

            Customer.Add(c1);
            Customer.Add(c2);
            Customer.Add(c3);
            Customer.Add(c4);

            foreach(Customer obj in Customer)
            {
                Console.WriteLine(obj.CustId+" "+obj.Name+" "+obj.City+" "+obj.Balance+" ");
            }

            Console.ReadLine();
        }
    }
}
