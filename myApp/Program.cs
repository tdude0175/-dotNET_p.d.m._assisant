using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace myApp
{
    class Program
    {
        public static bool greetRun = true;                    // variable used to make sure the program is running
        public static string user = "";                        // who is logged in. Going to be replaced when adding login to use
	    static void Main(string[] args)                        // main running function
	    {
	        while(greetRun)                                    // a while loop to keep prompting the user while that are working inside the program
            {
                if(user == "")                                 // run for the first time they log in otherwise it will ignore this
                {
                    Console.WriteLine("What is your name?");   // ask them for a name to refer to themselves as
                    user =  Console.ReadLine();                // save their input to the static string variable so it can be used later
                }
                Console.WriteLine($"Welcome {user} what would you like to do?");  // Ask the user what to do
                Console.WriteLine("1.Exit 2.Calculator 3.Send a message"); // Give them options on what to do
                string isTheUserStaying = Console.ReadLine();  // Get their input

                if(isTheUserStaying == "1" || isTheUserStaying == "exit") // if their input is equal to 1 will add options in case someone types exit
                {
                    Console.WriteLine("GoodBye");              // be polite
                    greetRun = false;                          // change the variable to exit out of runtime
                }
                if(isTheUserStaying == "2")                    // if their input is equal to 2 will add options if someone types calculator
                {
                    Console.WriteLine("Going To Calculator");  // Let them konw where they are going
                    Calculator();                              // Run the class method so that if they exit calculator it will return to this loop
                }
            }
	    }
	    public static void Calculator()
	    {
	        bool calculating = true;                            // A run time variable so they can constantly stay in if they have multiple equations
	       while(calculating)                                   // A while loop to promote continual running
	       {
	            Console.WriteLine();                            // Space from last line to make sure it is a bit more legible
                Console.WriteLine("Welcome to the calculator"); // Greet them
                Console.WriteLine("Please Enter the problem or type exit to return"); // Let them know what input is taken
                Console.WriteLine("[ + for addition] [ - for subtraction] [ * for multiplication ] [ / for division ] "); // let them know which operands to use
                string calculation = Console.ReadLine();        // Listen to their input to calculate
                var seperatingCharacters = calculation.Split(); // split the input into an array to calculate in proper order
                var orderOfExecution = new List<string>();      // create an empty list to help commit to the order of operations
                if(calculation == "exit")                       // listen for if they want to leave
                {
                    Console.WriteLine("returning home");        // let them know where they are going
                    Console.WriteLine();    //
                    calculating = false;
                    break;
                }
                for(int i = 0; i < seperatingCharacters.Length; i++)
                {
                    if(seperatingCharacters[i] == "*")
                    {
                        orderOfExecution.Add(seperatingCharacters[i]);
                    }
                    if(seperatingCharacters[i] == "/")
                    {
                        orderOfExecution.Add(seperatingCharacters[i]);
                    }
                    if(seperatingCharacters[i] == "+")
                    {
                        orderOfExecution.Add(seperatingCharacters[i]);
                    }
                    if(seperatingCharacters[i] == "-")
                    {
                        orderOfExecution.Add(seperatingCharacters[i]);
                    }
                }
            }
	    }
	    public static int multiply(int firstNumber , int secondNumber)
	    {
	        int result = firstNumber * secondNumber;
	        return(result);
	    }
	    public static int divide(int firstNumber , int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return(result);
        }
        public static int subtract(int firstNumber , int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return(result);
        }
        public static int add(int firstNumber , int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return(result);
        }
    }
}
