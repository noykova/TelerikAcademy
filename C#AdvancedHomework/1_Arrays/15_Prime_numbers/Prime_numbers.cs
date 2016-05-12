/* 
Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.
Input
•	On the first line you will receive the number N
Output
•	Print the biggest prime number which is <= N
Constraints
•	2 <= N <= 10 000 000
•	Time limit: 0.3s
•	Memory limit: 64MB
 * 
 * Sieve of Eratosthenes algorithm: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
 * 
 * The code is taken from: http://stackoverflow.com/questions/25702173/c-sharp-sieve-of-eratosthenes 
*/

using System;
using System.Collections.Generic;

class Prime_numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        //HashSet to store all non- prime numbers. If we use List, the program becomes too slow. 
        HashSet<int> noPrime = new HashSet<int>();

        //add all non-primes, devisible by 2. 
        for (int x = 2; x <= n; x++)
        {
            for (int y = x*2; y <= n; y = y + x)
            {

                if (!noPrime.Contains(y))
                {
                    noPrime.Add(y);
                }

            }

        }

        int index = 0;
        int dim = 0;
        int [] primes = new int[n];

        for (int z = 2; z <= n; z++)
        {
            if (!noPrime.Contains(z))
            {
                index++;
                primes[index] = z;
                dim = index;

                //Console.WriteLine(z);
            }
        }

      Console.WriteLine(primes[dim]);


    }
}

