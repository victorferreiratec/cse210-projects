using System;
using System.Collections.Generic;

// As a way to exceed requirements I added more prompts and questions, plus I added a counter for each activity and at the end I show the user how many times each activity was performed and close with a nice farewell!

class Program
{
    static void Main(string[] args)
    {
        // Initializing counters to keep track of how many times each activity was performed
        int counterActv1 = 0;
        int counterActv2 = 0;
        int counterActv3 = 0;

        BreathingActivity activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Creating the lists used in activity 2
        List<string> promptsList2 = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Think of a time when you overcame a significant challenge.", "Recall a moment when you made someone smile unexpectedly.", "Think of a time when you learned an important life lesson.", "Remember a situation where you demonstrated true kindness.", "Reflect on an experience that changed your perspective on something.", "Think of a time when you stepped out of your comfort zone.", "Recall a situation where you had to make a tough decision.", "Think of a moment when you felt truly at peace.", "Remember a time when you helped someone without expecting anything in return.", "Think of an experience that taught you patience.", "Reflect on a time when you achieved something you thought was impossible.", "Think of a moment when you received unexpected kindness from someone.", "Remember a time when you forgave someone, even when it was difficult.", "Reflect on an experience that shaped your character in a positive way.", "Think of a time when you turned failure into a learning opportunity." };

        List<string> questionsList = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?", "What emotions did you feel during this experience?", "What would you do differently if faced with this situation again?", "How has this experience shaped your values?", "What strengths did you discover about yourself?", "How can you use this lesson to improve your future decisions?", "How did this experience change the way you see yourself?", "What did this experience teach you about others?", "What was the hardest part of this experience, and how did you overcome it?", "Did this experience change your future decisions in any way?", "How did your emotions shift throughout this experience?", "Who else was impacted by this event, and how?", "If you could relive this experience, what would you do differently?", "What advice would you give to someone going through something similar?", "What habits or mindsets did this experience help you develop?", "How can you apply what you learned from this experience to your daily life?" };

        ReflectingActivity activity2 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", promptsList2, questionsList);

        // Creating the list used in activity 3
        List<string> promptsList3 = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?", "List things that bring you peace and comfort.", "List challenges you have overcome in the past year.", "List people who have positively impacted your life.", "List achievements you are proud of, big or small.", "List moments that made you feel truly happy.", "List things that inspire you.", "List qualities you admire in others.", "List experiences that made you stronger.", "List songs or books that have influenced you.", "List things you are looking forward to.", "List goals you have achieved, big or small.", "List places you would love to visit one day.", "List things that always make you smile.", "List ways you have grown in the past year.", "List things you are grateful for right now." };

        ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", promptsList3);

        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                activity.StartActivity();
                counterActv1++;
            }

            else if (choice == "2")
            {
                activity2.StartActivity();
                counterActv2++;
            }
            else if (choice == "3")
            {
                activity3.StartActivity();
                counterActv3++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid answer, choose one option: 1, 2, 3 or 4");
            }
        }
        Console.WriteLine($"\nDuring this mindfulness session you did:\n");
        Console.WriteLine($"Breathing activity {counterActv1} times.");
        Console.WriteLine($"Reflection activity {counterActv1} times.");
        Console.WriteLine($"Listing activity {counterActv1} times.\n");
        Console.WriteLine($"Feel free to do another session whenever you need!\n:)\n");
    }
}