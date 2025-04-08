using System;
using System.Collections.Generic;
using System.Transactions;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos and a list to store them
        Video video1 = new Video("Python Basics", "Code Academy", 120);
        Video video2 = new Video("Understanding HTML & CSS", "Code Bro", 60);
        Video video3 = new Video("Flask Web Development", "Microsoft Academy", 260);
        Video video4 = new Video("Full C# course", "freeCodeCamp", 3600);
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Creating the comments while adding them to the videos
        video1.AddComment(new Comment("Bob", "Very helpful, thanks guysss!"));
        video1.AddComment(new Comment("Charlie", "Can you cover more examples next time??"));
        video1.AddComment(new Comment("David", "This was amazing! I never thought I'd be able to learn to code"));

        video2.AddComment(new Comment("Ivy", "Finally, I understand CSS!"));
        video2.AddComment(new Comment("Jack", "Best tutorial ever!"));
        video2.AddComment(new Comment("Kevin", "Can you do a flexbox deep dive?"));
        video2.AddComment(new Comment("Lily", "I didn't know animations in CSS would be nice!"));

        video3.AddComment(new Comment("Eve", "I absolutely loved the Flask tutorial! It made the whole concept of building web apps so much easier to understand. Looking forward to more!"));
        video3.AddComment(new Comment("Frank", "Very informative tutorial! You explained the steps clearly and provided great examples. It was easy to follow and learn."));
        video3.AddComment(new Comment("Grace", "Thanks for making Flask so simple! I feel much more confident using Flask for my projects now. The breakdown of the code was super helpful."));
        video3.AddComment(new Comment("Hank", "Flask finally makes sense to me after watching this tutorial. The project-based approach helped me learn by doing, and I can't wait to apply what I learned."));

        video4.AddComment(new Comment("Dana", "I’ve tried learning C# from other sources, but this is by far the best tutorial I've come across. Everything is so well-organized and easy to follow. Keep it up!"));
        video4.AddComment(new Comment("Eli", "This course is a game-changer! The projects you include really helped me understand how to apply C# in real-world scenarios. I can’t wait to dive into more advanced topics."));
        video4.AddComment(new Comment("Fiona", "Excellent course! You break down complex concepts so clearly, making it easy to grasp even the more difficult topics. I'm definitely using C# in my next project."));
        video4.AddComment(new Comment("George", "I’ve learned so much from this course. The way each section builds upon the previous one makes it easy to follow. The C# fundamentals are finally making sense to me!"));


        //Iterate through the list of videos and Display their information
        Console.WriteLine("\n" + new string('-', 180) + "\n");
        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}