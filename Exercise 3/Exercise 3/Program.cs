using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // exercise 3 datatypes and variables


            byte myByte = 15;
            Console.WriteLine(myByte);

            sbyte mySByte = 30;
            Console.WriteLine(mySByte);

            int myInt = 12345;
            Console.WriteLine(myInt);

            uint myUInt = 67890;
            Console.WriteLine(myUInt);

            short myShort = 24680;
            Console.WriteLine(myShort);

            ushort myUShort = 13579;
            Console.WriteLine(myUShort);

            float myFloat = 2.4680f;
            Console.WriteLine(myFloat);

            double myDouble = 1.3579;
            Console.WriteLine(myDouble);

            char myCharacter = 'A';
            Console.WriteLine(myCharacter);

            bool myBoolean = true;
            Console.WriteLine(myBoolean);

            string myText = "I love pizza";
            Console.WriteLine(myText);

            string myNum = "15";

            int myNumFromText = int.Parse(myText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();





        }
    }
}
