using System;

namespace myApp
{
    class Program
    {
        public static bool greetRun = true;
        public static string user = "";

	    static void Main(string[] args)
	    {
	        //WorkingWithIntegers();
	        while(isRunning)
            {
                Console.WriteLine("Welcome what would you like to do? 1.say hello 2.Exit");
                string isTheUserStaying = Console.ReadLine();
                if(isTheUserStaying == "2" || isTheUserStaying == "exit")
                {
                    Console.WriteLine("GoodBye");
                    isRunning = false;
                }
                if(isTheUserStaying == "1")
                {
                    Console.WriteLine("What is your name?");
                    string user =  Console.ReadLine();
                    Console.WriteLine($"Hello {user}");
                    Console.WriteLine();
                    greetRun = false;
                }
            }
	    }
        static void
    }
}
