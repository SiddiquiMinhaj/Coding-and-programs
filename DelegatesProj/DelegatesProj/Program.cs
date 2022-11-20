namespace DelegatesProj
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);     
    internal class Program
    {
        //Step 1: definig a delegate
        
        public void Addnums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello (string name)
            {
            return "Hello "+name;
            }
        static void Main(string[] args)
        {
            Program p = new Program();
            //Step 2: Instantiating  the delegate (while Instantiating the delegate you have to pass a method as parameter)
            AddDelegate ad = new AddDelegate(p.Addnums);// here we have created instance of delegate because as we delegate is reference type and while defining it in static method we have to create instance(as we have defined delegate above in non static method)
            //step3: calling delegate
            ad(100, 50);
           // ad.Invoke(10, 20); // other way of calling delegate
            SayDelegate sd = new SayDelegate(Program.SayHello);//static members can be directly accessed under other static block withing the class 
            string str = sd("Raju");

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}