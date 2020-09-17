using System;

namespace BKIT_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 7);
            Quadrate quad = new Quadrate(4);
            Circle circ = new Circle(3);

            rect.Print();
            quad.Print();
            circ.Print();

            Console.ReadKey();
        }
    }
}
