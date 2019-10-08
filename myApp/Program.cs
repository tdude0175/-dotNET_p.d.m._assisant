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
	        Console.WriteLine("Welcome to the calculator");
	        Console.WriteLine("Please Enter the problem");
	        Console.WriteLine("[ + for addition] [ - for subtraction] [ * for multiplication ] [ / for division ] ");
	        string calculation = Console.ReadLine();
	        Console.WriteLine(calculation);
	        var seperatingCharacters = calculation.Split();
	        for(int i = 0; i < seperatingCharacters.length(); i++)
	        {
	        Console.WriteLine();
	        }
	    }
	    public static int multiply(int firstNumber , int secondNumber)
	    {
	        return(firstNumber * secondNumber);
	    }
    }
}
