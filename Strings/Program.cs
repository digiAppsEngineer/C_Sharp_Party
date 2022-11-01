using System;
using System.Net.Http;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string myname = "Pamela";
        
            Console.WriteLine("My name is " + myname);



            // This reads the same

            // string message = "My name is " + myname;
            // Console.WriteLine(message);

            string message = "My name is " + myname;

            string capMessage = message.ToUpper();

            Console.WriteLine(capMessage);

            string message1 = "My name is " + myname;

            string capMessage1 = message.ToLower();

            Console.WriteLine(capMessage1);

            Console.Read();
        }
    }
}
