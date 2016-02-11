using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBook.Examples.AreaOfATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // We could have chosen any of a number of types here. I avoided
            // the integral types because the math I'm doing will involve division,
            // which may mean we'll end up with fractional values, which can't be
            // stored in an integer type.
            // The double or decimal type provide a higher range and more accuracy,
            // at the expense of taking up more space. Between the three, in this
            // particular case, it probably doesn't matter what you choose.

            // The length of the base of the triangle.
            float b = 2;

            // The height of the triangle.
            float h = 4;

            // Do the math.
            float area = 0.5f * b * h;

            // Display the results.
            Console.WriteLine("Base: " + b);
            Console.WriteLine("Height: " + h);
            Console.WriteLine("Area: " + area);
        }
    }
}