using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Program title with your name
        Console.WriteLine("=== Chinonso Echefu's YouTube Video Tracker ===\n");

        // Create videos
        Video video1 = new Video("C# Basics Tutorial", "Alice Johnson", 600);
        Video video2 = new Video("OOP Concepts Explained", "Bob Smith", 900);
        Video video3 = new Video("Understanding Abstraction", "Chinonso Echefu", 750);

        // Add comments for video1
        video1.AddComment(new Comment("Sam", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Lily", "Helped me a lot, thanks!"));
        video1.AddComment(new Comment("Mike", "Can you make a part 2?"));

        // Add comments for video2
        video2.AddComment(new Comment("Anna", "OOP finally makes sense!"));
        video2.AddComment(new Comment("John", "Good examples."));
        video2.AddComment(new Comment("Steve", "Loved the explanation on encapsulation."));

        // Add comments for video3
        video3.AddComment(new Comment("Tina", "Abstraction is tricky, but now I understand."));
        video3.AddComment(new Comment("Raj", "Excellent breakdown, Chinonso!"));
        video3.AddComment(new Comment("Maya", "This really helped me with my assignment."));

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display all videos and their comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}