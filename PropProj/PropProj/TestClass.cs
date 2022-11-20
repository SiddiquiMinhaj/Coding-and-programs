using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropProj
{
    internal class TestClass
    {
        static void Main()
        { //Cust Id
            Customer c=new Customer(101, true, "Shah", 1000, "Ktraka", Cities.Banglore);
            Console.WriteLine("Customer Id: "+ c.CustId + "\n");
            //Status

            if (c.Status == true)
            {
                Console.WriteLine("Policy Status is Active \n");
            }
            else
            {
                Console.WriteLine("Policy Status is In-Active");
            }
            
            //Cname
            Console.WriteLine("CName: " + c.Cname + "\n");
            c.Cname = "Minhaj";

            if (c.Status == true)
            {
                Console.WriteLine("Updated name: " + c.Cname + "\n");
            }
            else
            {
                Console.WriteLine("User is inactive hence details connot be Altered, Last updated name: " + c.Cname + "\n");
            }

            //Balance

            
           if(c.Status == true)
            {
                Console.WriteLine("Balance: " + c.Balance + "\n");
            }
            else
            {
                Console.WriteLine("User is inactive hence details connot be retrived");

            }


            if (c.Status == true)
            {
                Console.WriteLine("State: " + c.State + "\n");
            }
            else
            {
                Console.WriteLine("User is inactive hence details connot be retrived");

            }

            if (c.Status == true)
            {
                Console.WriteLine("City: " + c.City+"\n");
            }
            else
            {
                Console.WriteLine("User is inactive hence details connot be retrived");

            }

            Console.ReadLine();
        }
    }
}
