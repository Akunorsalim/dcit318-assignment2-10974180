using System;

namespace InterfacesExample
{
    // Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // Implement the IMovable interface in the Car class
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implement the IMovable interface in the Bicycle class
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call the Move method on each instance
            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving
        }
    }
}
