using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingProject
{
    internal class LoadParent
    {
        public void Show()
        {
            Console.WriteLine(" Parent's show method is called");
        }

        public virtual void Test() // this method is overridable
        {
            Console.WriteLine(" Parent's test method is called");
        }
    }
    class Loadchild : LoadParent
    {
        public void Show(int i)
        {
            Console.WriteLine("child's show method is called");
        }

        public override void Test()
        {
            Console.WriteLine(" child's test method is called");
        }
        static void Main()
        {
            Loadchild c = new Loadchild();
            
            c.Show();//overloading
            c.Show(10);//overloading
            c.Test();//overriding
            
            Console.ReadLine();

        }
    }
}
































           





























































































































































































































































































































































































































































































