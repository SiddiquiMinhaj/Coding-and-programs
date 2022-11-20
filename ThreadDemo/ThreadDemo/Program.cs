namespace ThreadDemo
    

{
    
    public class Program
    {
        
        static void test1()
        {
            for (int i =1 ; i < 100; i++) 
            Console.WriteLine("test 1: " + i);
        }

        static void test2()

         {
            
            for (int i =1 ; i< 100; i++) 
            Console.WriteLine("test 2: " + i);
           
                
        }

        static void test3()

        {
            for (int i = 1; i < 100; i++)
                Console.WriteLine("test 3: " + i);
        }
        static void Main(string[] args)

            // after running the program, you'll see the test1 will execute and after that test2 and so on... one after the other
            // so the drawback is, in the single threaded model the action will completed one after the other
        {

            test1();  
            test2();
            test3(); 


            //Thread t= Thread.CurrentThread; // here thread is a class under that there is a property called CurrentThreadt
            //t.Name = "main thread";
            //Console.WriteLine("Current executing thread is " + Thread.CurrentThread.Name);
        }
    }
}


