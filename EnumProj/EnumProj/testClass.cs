namespace EnumProj
{
    internal class testClass
    {
        public enum Days//Enum is user defined type,hence it is always better to define an Enum directly under the namespace
        {
            Monday=1, // here i'm forcing the index to start from 1, by default it starts from 0.
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            
        }
        static void Main(string[] args)
        {
            Days d = (Days)3 ;// it comes under value type catagory, the index start from 0, here 3 is index location.
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}