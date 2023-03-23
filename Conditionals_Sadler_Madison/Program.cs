// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Conditionals_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
            // Asks the user to enter a whole number
            Console.WriteLine("User, please enter a whole number.");
            // Assigns the user input and converts user's input to an integer
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // Check if input is positive or negative
            if (myWholeNum >= 0)
            {
                // Prints out text saying myWholeNum is positive
                Console.WriteLine($"{myWholeNum} is a positive number.");
            }
            else
            {
                // Prints out text saying myWholeNum is negative
                Console.WriteLine($"{myWholeNum} is a negative number.");
            }

            //Checks if input is odd or even
            if (myWholeNum % 2 == 0)
            {
                // Prints out text saying myWholeNum is even
                Console.WriteLine($"{myWholeNum} is an even number.");
            }
            else
            {
                // Prints out text saying myWholeNum is odd
                Console.WriteLine($"{myWholeNum} is an odd number.");
            }

            // Assigns num1 the value 13
            int num1 = 13;
            // Assigns num2 the value 98
            int num2 = 98;

            // Determines whether myWholeNum or num1 is the larger value
            int firstMax = Math.Max(myWholeNum, num1);
            // Determines whether firstMax or num2 is the larger value
            int max = Math.Max(firstMax, num2);
            // Prints out text saying the largest value of myWholeNum, num1, and num2 is max
            Console.WriteLine($"The largest value of {myWholeNum}, {num1}, and {num2} is {max}.");

            // Asks user to input one of the valid grades
            Console.WriteLine("User, please enter one of these grades: A, B, C, D, or F.");
            // Assigns user input to input one of the valid grades
            char grade = Console.ReadKey().KeyChar;

            // Prints description based on grade value
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nUser, I'm afraid you did not enter a valid grade. Please restart the application and do it again. Be sure to carefully read the instructions.");
                    break;
            }
        }
    }
}
