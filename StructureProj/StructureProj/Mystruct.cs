using System;
namespace StructureProj
{
struct Mystruct
{
        int i; // this is feild
    public void Display()
    {
        Console.WriteLine("Method in structure: "+i);
    }
    static void Main()
    {

            Mystruct m1; // here new keyword is not mandatory, its optional to create instance in Structur
           // m1 = new Mystruct(); called by default constructor.
            m1.i = 10;// if there is a feild then we have to explicitly initialize the value, becuase it's not initialized by the defualt constructor
            m1.Display();
        Console.ReadLine();
    }
}

}