using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Circle c1 = new Circle();
            Circle c2 = new Circle(5.0);


            Console.WriteLine("c1 alan degeri: {0}",c1.getArea());
            Console.WriteLine("c1 cevre degeri: {0}",c1.getPerimeter());
            Console.WriteLine("c2 cevre degeri: {0}",c2.getPerimeter());
            Console.WriteLine("c2 alan degeri: {0}",c2.getArea());

          

            
           

            



            
            
        }
    }
}
