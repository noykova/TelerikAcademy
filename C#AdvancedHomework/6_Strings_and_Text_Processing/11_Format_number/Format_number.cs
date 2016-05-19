/*•	Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation.
•	Format the output aligned right in 15 symbols.
*/

using System;

    class Format_number
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string decFormat = String.Format("decimal representation: {0,15:D}",number);
            Console.WriteLine(decFormat);

            string hexadecFormat = String.Format("hexadecimal number: {0,15:X}", number);
            Console.WriteLine(hexadecFormat);

            string currency = String.Format("number as currency: {0,15:C}", number);
            Console.WriteLine(currency);

            string percentage = String.Format("number as percentage: {0,15:P}", number);
            Console.WriteLine(percentage);

            //scientific == exponential notation
            string sciNotation = String.Format("number in scientific notation: {0,15:E}", number);
            Console.WriteLine(sciNotation);

        }
    }

