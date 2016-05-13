/*Description
Write program that calculates the surface of a triangle by given two sides and an angle between them.
Input
•	On the first line you will receive the length of the first side of the triangle
•	On the second line you will receive the length of the second side of the triangle
•	On the third line you will receive the angle between the given sides 
o	Angle is given in degrees
Output
•	Print the surface of the rectangle with two digits of precision
 * 
 * formula: http://www.web-formulas.com/Math_Formulas/Geometry_Area_of_Triangle.aspx

 BGCoder: 100/100
 */
using System;

    class Triangle_surface_by_two_sides_and_an_angle
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            //Math.Sin(angle), double angle should be in radians. 
            //angle in radians = (Math.PI / 180) * angle;
            double angleRad = (Math.PI/180)*angle;

            double s = (a * b*Math.Sin(angleRad))/2.0;
            Console.WriteLine("{0:F2}", s);

        }
    }
