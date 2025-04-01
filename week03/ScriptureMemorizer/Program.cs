using System;
using System.Collections.Generic;
//As a way to exceed requirements I added the option for the user to show some words that were hidden by typing show.

class Program
{
    static void Main(string[] args)
    {
        //Using the second constructor of the Reference class
        Reference reference = new Reference("Ether", 12, 27);
        Scripture scripture = new Scripture(reference, "\nAnd if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, type 'show' to reveal some hidden words, or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;
            }

            else if (input == "show")
            {
                scripture.ShowRandomWords(4); // Show 4 random hidden words
            }

            else
            {
                scripture.HideRandomWords(4);
                // Hides 4 random words whenever the user presses enter
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}