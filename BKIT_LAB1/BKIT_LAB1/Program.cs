using System;
using System.Collections.Generic;
using System.Linq;

namespace BKIT_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Student: Babin Artem\tGroup: IU5-32B\n");

            double a, b, c;
            bool isCoeffsGiven = (args.Count() == 3) ? true : false;

            if (isCoeffsGiven)
            {
                if (!Double.TryParse(args[0], out a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Coefficient A value is incorrect!");
                    return;
                }
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Coefficient A can't be zero!");
                    return;
                }
                if (!Double.TryParse(args[1], out b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Coefficient B value is incorrect!");
                    return;
                }
                if (!Double.TryParse(args[2], out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Coefficient C value is incorrect!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Enter coefficients of biquadratic equation Ax^4+Bx^2+C=0");
                a = InputCoeff('A');
                while (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Coefficient A can't be zero!");
                    a = InputCoeff('A');
                }
                b = InputCoeff('B');
                c = InputCoeff('C');
            }

            PrintEqiation(a, b, c);
            PrintResult(GetRoots(a, b, c));

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            return;
        }

        static double InputCoeff(char coeffName)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(coeffName + ": ");
            double value;
            while (Double.TryParse(System.Console.ReadLine(), out value) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: This value is incorrect!");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(coeffName + ": ");
            }
            return value;
        }

        static void PrintResult(List<double> roots)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            if (roots.Count() > 0)
            {
                Console.WriteLine("Roots: ");
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (double root in roots)
                    Console.WriteLine(root);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Equation doesn't have real roots!");
            }
        }

        static void PrintEqiation(double a, double b, double c)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            string equation = a + "x^4";
            if (b > 0)
                equation += "+";
            if (b != 0)
                equation += b + "x^2";
            if (c > 0)
                equation += "+";
            if (c != 0)
                equation += c;
            equation += "=0";
            Console.WriteLine("\nEquation: " + equation);
        }

        static List<double> GetRoots(double a, double b, double c)
        {
            List<double> roots = new List<double>();

            double discrim = b * b - 4 * a * c;
            double squaredX;
            if (discrim > 0)
            {
                squaredX = (-b + Math.Sqrt(discrim)) / (2 * a);
                FindRootsFromSquare(squaredX, roots);

                squaredX = (-b - Math.Sqrt(discrim)) / (2 * a);
                FindRootsFromSquare(squaredX, roots);
            }
            else if (discrim == 0)
            {
                squaredX = (-b) / (2 * a);
                FindRootsFromSquare(squaredX, roots);
            }
            return roots;
        }

        static void FindRootsFromSquare(double squaredX, List<double> roots)
        {
            if (squaredX >= 0)
            {
                double absX = Math.Sqrt(squaredX);
                roots.Add(absX);
                if (absX != 0) roots.Add(-absX);
            }
        }
    }
}
