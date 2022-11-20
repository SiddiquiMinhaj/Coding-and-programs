using System.Diagnostics;
namespace ThreadPerformance
    
{
    internal class Program
    {
        public static void IncreamentCount1()
        {
            long count = 0;
            for (long i = 0; i <= 100000000; i++) ;
            count++;
            Console.WriteLine("Increament Count1: "+count);
        }

        public static void IncreamentCount2()
        {
            long count = 0;
            for (long i = 0; i <= 100000000; i++) ;
            count++;
            Console.WriteLine("Increament Count2: " + count);
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(IncreamentCount1);
            Thread t2=new Thread(IncreamentCount2);

            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            s1.Start();
            IncreamentCount1();
            IncreamentCount2();
            s2.Stop();

            s1.Start();
            t1.Start();
            t2.Start();
            s1.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("Time taken to complete the count in single threaded model: "+  s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete the work in multi threaded model: " + s2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}