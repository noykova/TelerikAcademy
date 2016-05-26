/*Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
•	If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 0 < a1 < ... < a10 < 100
Input
•	You will receive 10 lines of input, each consisted of an integer number 
o	a1
o	a2
o	...
o	a10
Output
•	Print 0 < a1 < ... < a10 < 100 
o	Or Exception if the above inequality is not true
 * 
 * BGCoder - 80/100
*/

using System;

public class Enter_numbers
{
    //fields
    private static int number; //return value of the method ReadNumber(int start, int end) 

    //constructors -define which properties are mandatory and which - optional
    public Enter_numbers()
    {
    }

    //methods
    public static int ReadNumber(int start, int end)

    {
            try
            {
                //Console.Write("Enter an integer number a = ");
                string str = Console.ReadLine();
                int a = int.Parse(str);
                if (a <= start || a >= end)
                {
                    throw new ArgumentOutOfRangeException("The number is not in range!");
                }
                number = a;
            }

            catch (FormatException fe)
            {
                Console.WriteLine("Exception"); //"Invalid number. " + fe.Message);
            }

            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine("Exception");
            } //"Invalid number out of range [" + start + "..." + end + "]. " + ae.Message); }

            catch (OverflowException oe)
            {
                Console.WriteLine("Exception");
                //"Invalid number!\nThe number is too big to fit in Int32! " + oe.Message);
            }
        return number;
    }



    public static void Main()
    {
        int start = 0;
        int end = 100;
        int indicator = 0; 
        int[] numbers = new int[10];
        numbers[0] = ReadNumber(start, end); 
        //numbers[11] = 100;


        for (int i = 1; i < numbers.Length; i++)
        {

            numbers[i] = ReadNumber(start, end);

            if (numbers[i-1]<numbers[i])
            {
            indicator++;                
            }

        }

        if (indicator == 9 && 1 < numbers[0])
        {
        Console.WriteLine("1 < "+string.Join(" < ", numbers)+" < 100");      
        }
        else if (indicator == 9 && 1 == numbers[0])
        {
            Console.WriteLine("0 < " + string.Join(" < ", numbers) + " < 100");     
        }
        else
        {
            Console.WriteLine("Exception");
        }
      
    }
}
