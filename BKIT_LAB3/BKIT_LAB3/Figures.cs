﻿using System;

namespace BKIT_LAB3
{
    interface IPrint
    {
        void Print();
    }

    public abstract class Figure : IComparable
    {
        public abstract double Square();

        public int CompareTo(object obj)
        {
            Figure comparedFigure = obj as Figure;
            if (comparedFigure != null)
                return Square().CompareTo(comparedFigure.Square());
            throw new Exception("Impossible to compare these objects!");
        }
    }

    class Rectangle : Figure, IPrint
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double _width, double _height)
        {
            Width = _width;
            Height = _height;
        }

        protected Rectangle(double _width)
        {
            Width = _width;
        }

        public override double Square()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle {width: " + Width + ", height: " + Height + ", square: " + Square() + "}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

    class Quadrate : Rectangle
    {
        public Quadrate(double _width) : base(_width) { }

        public override string ToString()
        {
            return "Quadrate {width: " + Width + ", square: " + Square() + "}";
        }

        public override double Square()
        {
            return Width * Width;
        }
    }

    class Circle : Figure, IPrint
    {
        public double Radius { get; set; }

        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle {radius: " + Radius + ", square: " + Square() + "}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

    class NullFigure : Figure, IPrint
    {
        public override double Square()
        {
            return 0;
        }

        public override string ToString()
        {
            return "None";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
