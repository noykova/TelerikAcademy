/*Description
Write program that calculates the surface of a triangle by given a side and an altitude to it.
Input
•	On the first line you will receive the length of a side of the triangle
•	On the second line you will receive the altitude to that side
Output
•	Print the surface of the rectangle with two digits of precision

 BGCoder: 100/100
 */
using System;

    class Triangle_surface_by_side_and_altitude
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double surface = length*altitude/2;
            Console.WriteLine("{0:F2}",surface);

        }
    }
