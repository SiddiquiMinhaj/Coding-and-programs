namespace AccessDemo1
{
    // case 1: here we're consuming members of a class from same class
    public class Program
    {
            private void test1()
            {
                Console.WriteLine("Private method");
            }
        internal void test2()
        {
            Console.WriteLine("Internal method");
        }

        protected void test3()
        {
            Console.WriteLine("protected method");
        }

        protected internal void test4()
        {
            Console.WriteLine("protected  internal  method");
        }

        public void test5()
        {
            Console.WriteLine("public Method");
        }




        static void Main(string[] args)
        {
            Program p = new Program();
            p.test1();p.test2();p.test3();p.test4(); p.test5();
        }
    }
}