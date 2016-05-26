/*Write a program that reads an integer number and calculates and prints its square root.
•	If the number is invalid or negative, print Invalid number.
•	In all cases finally print Good bye. Use try-catch-finally block.
Input
•	On the only line you will receive a real number
Output
•	Print the square root of the number or Invalid number on the first line 
o	Use 3 digits of precision
•	Print Good bye on the second line
 * 
 * BGCoder - 100/100
 * 
*/

using System;

    class Square_root
    {
        static void Main()
        {
            try
            {
                //Console.Write("Enter an integer number a = ");
                string str = Console.ReadLine();
                double a = double.Parse(str);
                if (a < 0 || a > uint.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("a");
               }

                double result = Math.Sqrt(a);
                Console.WriteLine(String.Format("{0:F3}", Math.Round(result,3)));
            }

            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number"); //+ fe.Message);
            }

            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine("Invalid number");
            } //out of range [" + 0 + "..." + int.MaxValue + "]. " + ae.Message); }

                //catch (OverflowException oe)
                //{
                //    Console.WriteLine(
                //        "Invalid number!\nThe number is too big to fit in Int32! " + oe.Message);
                //}
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

    }

