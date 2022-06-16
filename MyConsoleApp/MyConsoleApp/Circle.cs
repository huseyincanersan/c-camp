using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApp
{
    class Circle
    {
       public double radius=1;

        public Circle() { }

        public Circle(double r)
        {
            radius=r;
        }


        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public double getPerimeter()
        {
            return Math.PI * 2 * radius;
        }




       

    }
}
