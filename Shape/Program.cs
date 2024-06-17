using System;

namespace AbstractClassesAndMethods
{
    // Abstract base class
    public abstract class Shape
    {
        // Abstract method to be implemented in derived classes
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        // Constructor to initialize radius
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementation of GetArea method
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        // Constructor to initialize width and height
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implementation of GetArea method
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Circle and Rectangle
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            // Displaying the areas of the shapes
            Console.WriteLine("The area of the circle is: " + circle.GetArea());
            Console.WriteLine("The area of the rectangle is: " + rectangle.GetArea());
        }
    }
}
