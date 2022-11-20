namespace PropertiesPractice
{   
    public class Program
    {
        double radius = 12.34;
        public double radiusProperty { get { return radius; } set { radius = value; } }
        static void Main(string[] args)
        {
            Program p=new Program();    
            p.radius=p.radiusProperty;
            p.radiusProperty = 33.50;
            Console.WriteLine(p.radius);
            Console.ReadLine();
        
        }
    }
}