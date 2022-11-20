namespace Methodoverload2
{
    internal class Program
    {
        public void test()
        {
            string str = "hello how are you";
            Console.WriteLine(str.Substring(10));
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.test();
            Console.ReadLine();
        }
    }
}