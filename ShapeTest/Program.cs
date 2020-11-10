using System;
namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(24.00,34.00,56.00,34.00);
            Circle circle = new Circle(32.00,12.00,16.00);


            Console.WriteLine($"{circle.Area()}");
            Console.WriteLine($"{rectangle.Area()}");
        }
    }
}