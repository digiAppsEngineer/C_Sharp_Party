using System;
using System.Security.Cryptography.X509Certificates;

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



            //

            // define few variables
            int age = 39;
            string name = "Pamela";
            string sport = "football";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            // 2. string formatting
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old.  I love watching {2}.", name, age, sport);

            // 3. string interpolation
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.");

            // 4. verbatim strings
            // verbatim strings start with @ and tells the compiler to thake the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");

            // \n doesn't work with the @ symbol in verbatim strings
            Console.WriteLine(@"super long text to give an example of what this string will produce with verbatim.  blah blah blah blah blah my kids are super smart and \n they are great helpers.super compasionate and empathetic, and they love to cook.  they love to be outside and playing with their rc cars and monster trucks");
            Console.WriteLine(@"Muahaha \n you have no powers here!");
            
            
            // \n works without using the @ symbol
            Console.WriteLine("super long text to give an example of what this string will produce with verbatim.  blah blah blah blah blah my kids are super smart and \n they are great helpers.super compasionate and empathetic, and they love to cook.  they love to be outside and playing with their rc cars and monster trucks");
            Console.WriteLine("Muahaha \n you have powers here!");


            // exercise 1

            /*string noString = "tutorials.eu";
            string yesString = "Please enter your name and press enter";

            Console.WriteLine(yesString.ToUpper());
            Console.WriteLine(yesString.ToLower());
            Console.WriteLine(@"noString");
            Console.WriteLine(noString.Trim());



            // Console.WriteLine(result);
            Console.Read();

            // answer to exercise 1

            string myName;
            Console.Write("Please enter your name and press enter : ");
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case : {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
            string myNameSubString = String.Format("Substring value : {0}", myName.Substring(0, 5));
            
            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);

            Console.ReadKey(); */


            // exercise 2
            /*
            Console.Write("Please enter a string here: ");
            // read input string first
            string input = Console.ReadLine();

            Console.Write("Enter a character search: ");
            // read the character input
            char searchInput = Console.ReadLine()[0];
            // get indes of character from string
            int searchIndex = input.IndexOf(searchInput);
            // print index as a search result
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);*/



            
            Console.Write("Please enter your first name here: ");
            // reads first name
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name here: ");
            // reads last name
            string lasstName = Console.ReadLine();
            // concatinate first name and last name using variable
            string fullName = string.Concat(firstName, "", lasstName);
            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadKey();

        }
    }
}
