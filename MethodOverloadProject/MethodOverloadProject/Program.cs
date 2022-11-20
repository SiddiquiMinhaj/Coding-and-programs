namespace MethodOverloadProject
{
    internal class Program
    {
        public void test()
        {
            Console.WriteLine("Simple Method");
        }

        public void test(int i)
        {
            Console.WriteLine("Parameter method");
        }

        public void test(string s)
        {
            Console.WriteLine("differet type of parameter Method");
        }
        public void test(int i, string s)
        {
            Console.WriteLine("number of parametr Method");
        }

        public void test(string s, int i)
        {
            Console.WriteLine("different order of parameter Method");
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.test(); //here I'm passing some value and base on that value the method will be called
            p.test(10);
            p.test("Xyz");
            p.test(10, "Xyz");
            p.test("XYZ", 10);
            Console.ReadLine();
        }
    }
}