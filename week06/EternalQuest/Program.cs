using System;
using System.Collections.Generic;
using System.IO;

//As a way to exceed requirements I added a function in the Goal Class named ShowCelebration using 
//some ASCII art, and added some phrases and a few Console.Clear() lines to make the transitions more readable throughout the program

class Program
{
    static void Main(string[] args)
    {
        // Creates a new "GoalManager" object to control everything
        GoalManager manager = new GoalManager();
        // Starts the main loop (menu and actions)
        manager.Start();
    }


}