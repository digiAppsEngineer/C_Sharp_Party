using System;

namespace DoublesFloats.cs
{
    class Declare
    {
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 13;


            // declaring and initializing a variable in one go
            int num2 = 23;
            
            int sum = num1 + num2;


            // using concatination (adding things together)
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum );
            
            
            Console.WriteLine(num1);

            // declaring multiple variables at once: should use at the beginning
            int num3, num4, num5;




            // doubles
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);


            // floats - not as exact as doubles
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2" + fDiv);


            double dIDiv = d1 / num1; 
           
            Console.WriteLine("d1/d2" + dIDiv);


            Console.Read();

        }
    }
}
