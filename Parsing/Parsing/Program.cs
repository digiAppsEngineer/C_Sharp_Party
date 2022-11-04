using System;

namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string myString2 = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(myString2);
            int resultInt = num1 + num2;
            string result = myString + myString2;


            // assignment
            string stringForFloat = "0.85";
            string stringForInt = "12345";
            
            // solution
            int i = Int32.Parse(stringForInt);
            float f = float.Parse(stringForFloat);

            System.Console.WriteLine("Int = {0}, Float = {1}", i, f);



            Console.WriteLine(result);
            Console.Read();
        }
    }
}
