/*
 Author:Sachiwa Irugalbandara
 Data: 9/20/2020
 Comments: C# Conditional statements assignment after getting information form users.
 
*/

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user for their input
            Console.WriteLine("What grade do you expect to get in ISM4300? (Please eneter an integer value!)");
            /*
             Using try catch block to validate user input.
             If the user enterd a bad input they will get a error message.
             */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /*
                 This variable will be used to store the grade in the syllabus
                */
                int value_of_input = int.Parse(input);
                /*
                 This will use IF/ELSE IF/ELSE statements to test the values of user input.
                 It depends on the value of the user input between 0 to 100.
                 */
                // If the value of user input is between 0 and 59 it will execute a conditional statement.
                if ((value_of_input > 0) && (value_of_input <= 59))
                {
                    // The user gets a F grade.
                    Console.WriteLine("Letter Grade= F");
                    Console.WriteLine("Try more and more!");
                    //This will exit from the window after the answer
                    Console.WriteLine("Press any key to exit the window..");
                    //pause the program and wait few seconds until user press any key to end the window.
                    Console.ReadKey(true);
                }
                // If the value of user input is between 60 to 69 it will execute a conditional statement. 
                if ((value_of_input > 59) && (value_of_input <= 69))
                {
                    // The user gets a D grade
                    Console.WriteLine("Letter Grade= D");
                    Console.WriteLine("Work harder!");
                    // This will exit from the window after the answer
                    Console.WriteLine("Press any key to exit the window..");
                    //Pause the program and wait few seconds until user press any key to end the window.
                    Console.ReadKey(true);
                }
                
                // If the value of user input is between 70 to 79 it will execute a conditional statement.
                if ((value_of_input > 69) && (value_of_input <= 79))
                {
                    // The user gets a C grade
                    Console.WriteLine("Letter Grade= C");
                    Console.WriteLine("Work Hard!");
                    // This will exit from the window after the answer
                    Console.WriteLine("Press any key to exit the window..");
                    // Pause the program and wait few seconds until user press any key to end the window.
                    Console.ReadKey(true);
                }
                // If the value of the user input is bewtwwen 80 to 89 it will execute a conditional statement.
                if ((value_of_input > 79) && (value_of_input <= 89))
                {
                    // The user gets a B grade
                    Console.WriteLine("Letter Grade= B");
                    Console.WriteLine("Great Work. Almost there!");
                    // This will exit from the window after the answer
                    Console.WriteLine("Press any key to exit the window..");
                    // Pause the program and wait few seconds until user press any key to end the window.
                    Console.ReadKey(true);
                }
                // If the value of the user input is between 90 to 100 it will execute a conditional statement.
                if ((value_of_input > 89) && (value_of_input <= 100))
                {
                    // The user gets a A grade
                    Console.WriteLine("Letter Grade= A");
                    Console.WriteLine("You have achived it. Excellent Work!");
                    // This will exit from the window after the answer
                    Console.WriteLine("Press any key to exit the window..");
                    // Pause the program and wait few seconds until user press any eo end the window.
                    Console.ReadKey(true);
                } 
                
            }// End of Entry 
            catch
            {
                Console.WriteLine("Please enter an integer value and try again..");
                Console.WriteLine("Press any key to exit the program..");
                Console.ReadKey(true);
            }// End of Catch
        }//End of Main
    }// End of class
}//End of namespace
