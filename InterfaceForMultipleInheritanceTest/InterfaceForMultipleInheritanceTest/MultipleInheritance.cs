namespace InterfaceForMultipleInheritanceTest
{
    interface interface1
    {
        void test();
    }

    interface interface2
    {
        void test();

    }
    internal class MultipleInheritance : interface1, interface2 // here both interfaces 1 and 2 dont know about each other
                                                                // if they dont know about each other then, they'll go and check if their 
                                                                // method got implemented or not, if its implemented both are okay to execute the program
                                                                // they will not require 2 methods to impelement as they dont know about each other, hence wo wont get ambiguty problem

    {
        public void test()// here I'm implementing the method only once, 
                          // basically we should implement it twice as there are two interfaces
                          // the reason for implementing it once without error is, we're implementing the interface not consuming
                          // for consuming the method we require to implement it twice.
        {
            Console.WriteLine("interfaces method implemented in child class");
        }
        static void Main()
        {
            MultipleInheritance obj= new MultipleInheritance();
            obj.test();
            Console.ReadLine();
        }

       
    }
}