using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    class Circle
    {
        public double radius = 1; // instance variables

        public static int numberOfCircles = 0;

        public Circle()
        {
            numberOfCircles = numberOfCircles + 1;
        }

        public Circle(double r)
        {
            radius = r;
            numberOfCircles = numberOfCircles + 1;
        }


        public double getArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double getPerimeter()
        {
            return Math.PI * 2 * radius;
        }






    }
}
