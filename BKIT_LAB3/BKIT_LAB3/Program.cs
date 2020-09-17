using System;
using System.Collections;
using System.Collections.Generic;

namespace BKIT_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 7);
            Quadrate quad = new Quadrate(8);
            Circle circ = new Circle(3);
            Console.WriteLine("Before sorting:\n\t" + rect + "\n\t" + quad + "\n\t" + circ);

            ArrayList figuresArrayList = new ArrayList();
            figuresArrayList.Add(rect);
            figuresArrayList.Add(quad);
            figuresArrayList.Add(circ);
            figuresArrayList.Sort();
            Console.WriteLine("\nArrayList sorting: ");
            foreach (object obj in figuresArrayList)
                Console.WriteLine("\t" + obj);

            List<Figure> figuresList = new List<Figure> { rect, quad, circ };
            figuresList.Sort();
            Console.WriteLine("\nList sorting: ");
            foreach (Figure figure in figuresList)
                Console.WriteLine("\t" + figure);

            Console.Write("\nMatrix: ");
            Matrix<Figure> figuresMatrix = new Matrix<Figure>(4, 3, 2, new NullFigure());
            figuresMatrix[0, 1, 1] = rect;
            figuresMatrix[2, 2, 0] = quad;
            figuresMatrix[1, 2, 1] = circ;
            Console.Write("\n" + figuresMatrix);

            Console.WriteLine("\nElements in stack: ");
            SimpleStack<Figure> figuresStack = new SimpleStack<Figure>();
            figuresStack.Push(rect);
            figuresStack.Push(circ);
            figuresStack.Push(quad);
            while (figuresStack.Count != 0)
                Console.WriteLine("\t" + figuresStack.Pop());

            Console.ReadKey();
        }
    }
}
