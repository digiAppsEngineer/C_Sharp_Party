using System;

namespace Conersions

{
    internal class Program
    {
        static void Main(string[] args)
        {

            // explicit conversion

            double myDouble = 13.37;
            int myInt;

            // cast double to int
            myInt = (int)myDouble;
            ;

            // implicit conversion

            int num = 123456789;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            // type conversion

            string myString = myDouble.ToString();
            // converts 13.372 to "13.72"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();


            Console.WriteLine(myInt);
            Console.WriteLine(myFloatString);
            Console.WriteLine(myBoolString);
            Console.Read();

        }
    }
}
