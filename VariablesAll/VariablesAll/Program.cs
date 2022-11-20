namespace VariablesAll
{
    internal class Program

    {
        int x=100;  // non static variable (its default declared by system implicitly)
        static int y=200;  // this is static as is declared as static
        const float pi = 3.14f;
         
        
        static void Main(string[] args)
        {
            // this is static as is declared under static block
            Program obj = new Program();//here I have created instance to print the value of the X
            Program obj2 = new Program();
            int x = 314;
            Console.WriteLine("x="+x);
            x = 315;
            Console.WriteLine("x="+x);
            const float pi = 3.15f;


            Console.WriteLine("pi="+pi);
            //pi = 3.16f;
            Console.WriteLine("pi=" + pi);
            
           // Console.WriteLine(obj.x);// here X cannot print the value as its non static variable, to print the value of x need to create instance
           // Console.WriteLine(obj2.x);
            Console.WriteLine(y); // here Y is static variable hence no need to have object(instance)
            Console.WriteLine(obj.x+"  "+obj2.x); // here i'm initalizing value of X n number of time, whereas value of Y will initialize only once 
            Console.ReadLine();
        }
    }
}