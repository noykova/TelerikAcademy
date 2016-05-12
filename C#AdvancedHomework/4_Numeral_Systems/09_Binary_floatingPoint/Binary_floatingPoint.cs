/*Description
Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
Input
•	On the only line you will receive a decimal number - N
Output
•	Print the its binary representation on a single line 
o	There should not be leading zeros
 * 
*/

using System;


class Binary_floatingPoint
{
    static void Main()
    {
        float n = float.Parse(Console.ReadLine());
        //cast negative numbers to short in order to use the Convert.ToString(short, int) overload:. 
        byte[] hex = BitConverter.GetBytes(n);
        foreach (var element in hex)
        {
            Console.WriteLine(Convert.ToString(element,16));
        }

        string[] bits = new string[4];
        string str = "";
        for (int i = 3; i >= 0; i--)
        {
            bits[i] = Convert.ToString(hex[i], 2).PadRight(8, '0');
            Console.WriteLine(bits[i]);
            str += bits[i];
        }
        Console.WriteLine(str);
        char[] chars = str.ToCharArray();

        //sign
        char sign = str[0];
        Console.WriteLine(sign);

        //exponent
        string c = str.Substring(1, 8);
        Console.WriteLine(c);

        //mantissa
        string mantissa = str.Substring(9, 23);
        Console.WriteLine(mantissa);

    }
}


