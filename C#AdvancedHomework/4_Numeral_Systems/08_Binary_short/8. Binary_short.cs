/*Description
Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).
Input
•	On the only line you will receive a decimal number - N
Output
•	Print the its binary representation on a single line 
o	There should be exactly 16 digits of output
*/

using System;

namespace _08_8.Binary_short
{
    class Binary_short
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            //cast negative numbers to short in order to use the Convert.ToString(short, int) overload:. 
        string binary = Convert.ToString((short)number, 2).PadLeft(16, '0');
            Console.WriteLine(binary);

        }
    }
}
