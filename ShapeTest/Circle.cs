using System;
namespace ShapeTest
{
    public class Circle:Shapes
    {
        protected double Radius{get;set;}

         public Circle(double radius ,  double X, double Y):base(X,Y)
        {

        Radius = radius;
        }

        public override double  Area()
        {
           double result = 22/7;
           return result * Radius * Radius;
        }

        public  string Tostring()
    {
        return $"the area of the triangle is {Area()} ";
    }


    }
}