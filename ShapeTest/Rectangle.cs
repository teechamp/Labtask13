using System;
namespace ShapeTest
{
    public class Rectangle:Shapes
    {
         protected double Side1 {get; set;}
         protected double Side2 {get;set;}

         public Rectangle(double side1 , double side2, double X, double Y):base(X,Y)
   {

        Side1 = side1;
        Side2 = side2;

   }

       public override double  Area()
    {
        return Side1 * Side2;
    }
 
    public string Tostring()
    {
        return $"the area of the triangle is {Area()} ";
        
    }


    }
}