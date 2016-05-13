/*Description
Write program that calculates the surface of a triangle by given its three sides.
Input
•	On the first line you will receive the length of the first side of the triangle
•	On the second line you will receive the length of the second side of the triangle
•	On the third line you will receive the length of the third side of the triangle
Output
•	Print the surface of the rectangle with two digits of precision
 * 
 * formula from the net: http://www.dummies.com/how-to/content/determining-a-triangles-area-from-its-three-sides.html
 * 
 * BGCoder: 100/100
*/
using System;

    class Triangle_surface_by_three_sides
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double perimeter = (a + b + c)/2;
            double s = Math.Sqrt(perimeter*(perimeter - a)*(perimeter - b)*(perimeter - c));
            Console.WriteLine("{0:F2}",s);


        }
    }

