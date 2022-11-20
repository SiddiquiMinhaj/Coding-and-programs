using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyProj
{
     internal class Testclasst
    {
        static void Main()
        { 
            //for CustId
            Customer obj = new Customer(101,true,"Shahnawaz",1000, Cities.Banglore, "Karnataka");
            Console.WriteLine("CustId: "+ obj.Custid +"\n");             //sec Obj
                                                                   //obj.Custid = 102;// cant be assignend valve as the property is read only, as you see we've set the get method in CustId class, not set method

            //for Status
            //  Console.WriteLine("Current status of the customer: " + obj.Status); // here it will provide the value False, but we want to show active and inactive hance I ran below if query
            if (obj.Status == true)
            {
                Console.WriteLine("Current status of the customer : Active\n");
            }
            else
            {
                Console.WriteLine("Current status of the customer: Inactive\n");
            }
            //  obj.Status=true;
            // Console.WriteLine("Updated Status of the Customer: " + obj.Status);

            //for Cname
            Console.WriteLine("Customer Name: " + obj.Cname + "\n");
            if (obj.Status == true)
            {
                obj.Cname = "Humaza\n";
                Console.WriteLine("Updated name of the Customer: " + obj.Cname + "\n");
            }
            else 
            {
                Console.WriteLine("Name updation: Cant make changes as account is inactive \n");
            }

            //for Balance
            
                Console.WriteLine("Customer Balance: " + obj.Balance);
                obj.Balance -=500;
                Console.WriteLine("Updated Balance: " + obj.Balance + "\n");

                obj.Balance -= 100; // condition fails
                Console.WriteLine(" Balance when assignement fails, the old balance is: " + obj.Balance + "\n");


            // obj.Balance = obj.Balance + 500;
            //Console.WriteLine(" Updated Balance: " + obj.Balance + "\n");

            //Console.WriteLine("Balance when assignement if failed: " + obj.Balance + "\n");

            //for City
            //I need only few selected cities as a branch, hence I have created Enum(Cities.cs) and defined datatypes(cities name) 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Current City: " + obj.City+"\n");
            obj.City = Cities.Delhi; // when I need to change it i will get only listed cities which I defined in enum list
            Console.WriteLine("Modified City: "+obj.City+"\n");
            
            //for State
            Console.WriteLine("Current State:" + obj.State);
            obj.State = "Maharashtra";
            Console.WriteLine("Modified State:" + obj.State);

            Console.ReadLine();
           
        }
    } 
}
