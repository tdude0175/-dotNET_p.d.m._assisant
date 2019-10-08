using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace myApp
{
    class Program
    {
        public static bool greetRun = true;
        public static string user = "";
	    static void Main(string[] args)
	    {
	        //WorkingWithIntegers();
	        while(greetRun)
            {
                if(user == "")
                {
                    Console.WriteLine("What is your name?");
                    user =  Console.ReadLine();
                }
                Console.WriteLine($"Welcome {user} what would you like to do?");
                Console.WriteLine("1.Exit 2.Calculator 3.Send a message");
                string isTheUserStaying = Console.ReadLine();

                if(isTheUserStaying == "1" || isTheUserStaying == "exit")
                {
                    Console.WriteLine("GoodBye");
                    greetRun = false;
                }
                if(isTheUserStaying == "2")
                {
                    Console.WriteLine("Going To Calculator");
                    Calculator();
                }
            }
	    }
	    public static void Calculator()
	    {
	        bool calculating = true;
	       while(calculating)
	       {
	            Console.WriteLine();
                Console.WriteLine("Welcome to the calculator");
                Console.WriteLine("Please Enter the problem or type exit to return");
                Console.WriteLine("[ + for addition] [ - for subtraction] [ * for multiplication ] [ / for division ] ");
                string calculation = Console.ReadLine();
                var seperatingCharacters = calculation.Split();
                if(calculation == "exit")
                {
                    Console.WriteLine("returning home");
                    Console.WriteLine();
                    calculating = false;
                    break;
                }
                for(int i = 0; i < seperatingCharacters.Length; i++)
                {
                    if(seperatingCharacters[i] == "*")
                    {
                        Console.WriteLine(multiply(Int32.Parse(seperatingCharacters[i-1]), Int32.Parse(seperatingCharacters[i+1])));
                    }
                    if(seperatingCharacters[i] == "/")
                    {
                        Console.WriteLine(divide(Int32.Parse(seperatingCharacters[i-1]), Int32.Parse(seperatingCharacters[i+1])));
                    }
                    if(seperatingCharacters[i] == "+")
                    {
                        Console.WriteLine(add(Int32.Parse(seperatingCharacters[i-1]), Int32.Parse(seperatingCharacters[i+1])));
                    }
                    if(seperatingCharacters[i] == "-")
                    {
                        Console.WriteLine(subtract(Int32.Parse(seperatingCharacters[i-1]), Int32.Parse(seperatingCharacters[i+1])));
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
