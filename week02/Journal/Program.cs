using System;
using System.Linq.Expressions;
using System.Collections.Generic;


//I added a function to save a password and a function to load the file just by entering the correct password.
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select of the follwing choices: \n");
        
        while (true)
        { 
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("\nWhat would you like to do? ");

            string option = Console.ReadLine();
    
            switch (option)
            {
                case "1":
                    string selectedPrompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(selectedPrompt);
                    string answer = Console.ReadLine();
                    Entry newEntry = new Entry (selectedPrompt,answer);
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Please select a valid option (1-5).");
                    break;
            }
        }
    }
}