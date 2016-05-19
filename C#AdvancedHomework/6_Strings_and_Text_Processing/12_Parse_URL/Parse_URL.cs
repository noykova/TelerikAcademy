/*Description
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Input
•	On the only line you will receive an address
Output
•	Print the protocol, server and resource as shown below
*/

using System;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.GroupCollection;


    class Parse_URL
    {
        static void Main()
        {

            string address = Console.ReadLine();

            //pattern for searching the word in the text
            //(http[a-z]?) - ()=group[1], http + one more letter + ? meaning 0 or 1 times. 
            //:\/\/ = ://
            //([^\/:\n]+) - () = group[2]:^ - not /, : or /n = new line, but all other symbols, + - 0 or more times
            //[\/]? - symbol /, ? - 0 or 1 times
            //([^:]+\n)? - () - group[3], all symbols without (^) :, + - 0 or more times, ? - this group presents 0 or 1 times. 

            string pattern = @"(http[a-z]?):\/\/([^\/:\n]+)[\/]?([^:]+\n)?";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(address);

            foreach (var match in matches)
            {
                Console.WriteLine("[protocol] = {0}", match.Groups[1].Value);
                Console.WriteLine("[server] = {0}", match.Groups[2].Value);
                Console.WriteLine("[resource] = {0}", match.Groups[3].Value);

            }

        }
    }
