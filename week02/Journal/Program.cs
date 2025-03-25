using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        { 
            Console.WriteLine("Please select of the follwing choices: \n");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("\nWhat would you like to do? ");

            string option = Console.ReadLine();
    
            switch (option)
            {
                case 1:
                    Journal writing = new Journal();
                    writing.AddEntry();
                    break;
                case 2:
                    Console.WriteLine("Displaying...");
                    break;
                case 3:
                    Console.WriteLine("Saving...");
                    break;
                case 4:
                    Console.WriteLine("Loading...");
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid option (1-5).");
                    break;
            }
        }
    }
}