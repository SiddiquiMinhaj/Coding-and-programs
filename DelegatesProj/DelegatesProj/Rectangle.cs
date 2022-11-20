using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// multicast gelegate
namespace DelegatesProj
{
    internal class Rectangle
    {
        public delegate void RectDelegate(double Width, double Height);
        public void GetArea(double Height, double Width)
        {
            Console.WriteLine("Area of rectangel: "+Width*Height);
        }

        public void GetParimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter on the Area: "+ 2*(Width+Height));
        }
         
        static void Main()
        {
            Rectangle rect = new Rectangle();
            RectDelegate obj = rect.GetArea; // Instantiating getarea delegate
            obj += rect.GetParimeter; // here i'm calling getparimeter with single delegate called above
            obj.Invoke(33.22, 44.55); // here I put same value for both delegates and it will apply to both gelegates

           
            
          
            Console.ReadLine();
        }
    }
}
