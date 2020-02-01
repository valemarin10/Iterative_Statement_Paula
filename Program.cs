//
/* 
Author: Paula Marin
Date: 01/30/2020
Comments: This C# console application code demonstrates the use of
iteration statements 
*/




using System;

namespace Iterative_Statement_Paula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //create integer variable
            int integerIterator;

           Console.WriteLine("Input an integer between 1 and 100");

            try
            {
                string userInput = Console.ReadLine();
                integerIterator = int.Parse(userInput);

                //make sure the number is an integer between 1-100 display message error
                if (integerIterator >= 1 && integerIterator <= 100)
                    for (int i = 1; i <= integerIterator; i++)
                    {
                        Console.WriteLine("you have entered" + userInput + ". This is the current integer value in the loop: " + i.ToString() + ".");

                    }
                else
                    Console.WriteLine("Please enter an interger that's between 1-100 and try again...");

            }

            catch
            {
                Console.WriteLine("make sure you enter an integer from 1 to 100.");
                Console.WriteLine("Press any key to close the window.");
                Console.ReadKey(true);
            }
        }
    }
}
