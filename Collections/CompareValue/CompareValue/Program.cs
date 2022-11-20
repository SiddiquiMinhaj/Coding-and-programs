namespace CompareValue
{
    internal class Program
    {
        //here in below two different methods, Compare and Compare2 we're trying to compare two types on value int and float
        //int third method CompareObj we're trying to compare by object not by types
        public bool Compare(int a, int b)
        {
            if(a == b)
                return true;
            return false;
        }

        public bool Compare2(float c, float d)
        {
            if (c == d) 
            return true;
            return false ;
        }

        public bool CompareObj(object a, object b)
        {
            if(a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            bool result=obj.Compare(20,30);// here we can pass integer only
            Console.WriteLine("result for integer value: "+ result);
            

            bool result2=obj.Compare2(20.0f,30.30f);// here we can pass float only
            Console.WriteLine("result for float value: " + result2); 

            bool resultObj = obj.CompareObj(10, 20.23f);// here we able to pass any type of value, hence it's not type safe
            Console.WriteLine("result for object value: " + resultObj); 

            Console.ReadLine();
        }
    }
}