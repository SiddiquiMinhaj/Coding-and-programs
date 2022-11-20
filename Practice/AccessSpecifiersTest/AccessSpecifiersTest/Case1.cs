namespace AccessSpecifiersTest
{
    public class Case1

    {
        private void pvt()
        {
            Console.WriteLine("Private");
        }

        internal void intrnl()
        {
            Console.WriteLine("Internal");
        }

        protected void prot()
        {
            Console.WriteLine("Protected");
        }

        protected internal void prtint()
        {
            Console.WriteLine("Protected Internal");
        }

        public void pblc()
        {
            Console.WriteLine("Public");
        }


        static void Main(string[] args)
        {
            Case1 c1=new Case1();
            c1.pvt(); c1.intrnl(); c1.prot(); c1.prtint(); c1.pblc();
            Console.ReadLine();
        }
    }
}