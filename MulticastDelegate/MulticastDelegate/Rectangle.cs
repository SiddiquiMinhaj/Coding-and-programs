namespace MulticastDelegate
{

    internal class Rectangle
    {
        public void GetArea(double Height, double Width)
        {
            Console.WriteLine(Width * Height);
        }

        public void GetParimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }

        public void Main()
        {
            Rectangle rect = new Rectangle();
            rect.GetArea(12.34, 11.4);
            rect.GetParimeter(12.44, 33.22);
            Console.ReadLine();
        }
    }

}