/*Description
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Input
•	On the only line you will receive an address
Output
•	Print the protocol, server and resource as shown below
 * 
 * I am not able to use Regex because the property match.Groups[1].Value does not work.  
 * Therefore use IndexOf and Substring
 * 
 * BGCoder - 100/100
 * 
*/

using System;
//using System.Text.RegularExpressions;
//using System.Text.RegularExpressions.GroupCollection;



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

           // string pattern = @"(http[a-z]?):\/\/([^\/:\n]+)[\/]?([^:]+\n)?";
           // Regex regex = new Regex(pattern);

           // MatchCollection matches = regex.Matches(address);
            
           // foreach (var match in matches)
            //{
                
                //Console.WriteLine("[protocol] = ", match.Groups[1].Value);
             //   Console.WriteLine("[server] = ", match.Groups[2].Value);
             //   Console.WriteLine("[resource] = ", match.Groups[3].Value);

           // }

            //find start index of protocol = length of the protocol substring
            int lengthOfProtocol = address.IndexOf("://");
            // the substring from 0 with length=indexOfProtocol 
           // string string.Substring(int startIndex, int length); 
           string protocol = address.Substring(0, lengthOfProtocol);
           //the start index of the substring "/" starting from (indexOfProtocol + 3(://) 
           //in address by its first occurrences => int string.IndexOf(String value, int (lengthOfProtocol + 3)) =>
           //the index of first occurence of value after the index (lengthOfProtocol + 3);
           int indexOfServer = address.IndexOf("/", lengthOfProtocol + 3);

           // string string.Substring(int startIndex, int length);
           string server = address.Substring(lengthOfProtocol + 3, indexOfServer - lengthOfProtocol - 3);

           // string string.Substring(int startIndex);
           string resource = address.Substring(indexOfServer);

           Console.WriteLine("[protocol] = {0}", protocol);
           Console.WriteLine("[server] = {0}", server);
           Console.WriteLine("[resource] = {0}", resource);

        }
    }
