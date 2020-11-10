using System;
namespace ShapeTest
{
    public class Shapes
    {
        public double X {get;set;}

        public double Y {get;set;}

        public Shapes(double x,double y)
        {
        
            X = x;
            Y = y;
            
        }


        
        public virtual double Area()
        {
            return X * Y;
        }


        
        public double perimeter()
        {
          return X + Y;
        }
        public override string ToString()
        {
         return $"the area is {Area()}";

        }
    }
}