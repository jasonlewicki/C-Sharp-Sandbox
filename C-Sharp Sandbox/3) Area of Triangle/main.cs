using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // The length of the base of the triangle.
            float b = 2;

            // The height of the triangle.
            float h = 5;

            // Do the math. Area of a triangle.
            float area = 0.5f * b * h;

            // Display the results.
            Console.WriteLine("Base: " + b);
            Console.WriteLine("Height: " + h);
            Console.WriteLine("Area of Triangle: " + area); 
        }
    }
}
