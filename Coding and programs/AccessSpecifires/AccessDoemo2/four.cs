namespace AccessDoemo2
{
    internal class four:AccessDemo1.Program
    {
        //case4: consuming members of a class from non-child class of different project
        static void Main(string[] args)
        {
            four f=new four();
            f.test3();  f.test4();f.test5();
            Console.ReadLine();
        }
    }
}