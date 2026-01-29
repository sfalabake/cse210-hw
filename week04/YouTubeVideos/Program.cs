using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create video 1
        Video video1 = new Video("C# Basics", "Solomon Falabake", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));
        videos.Add(video1);

        // Create video 2
        Video video2 = new Video("Advanced C#", "John Doe", 900);
        video2.AddComment(new Comment("Dave", "This was a bit fast."));
        video2.AddComment(new Comment("Eve", "Excellent explanations."));
        video2.AddComment(new Comment("Frank", "Loved the examples."));
        videos.Add(video2);

        // Create video 3
        Video video3 = new Video("Object-Oriented Programming", "Jane Smith", 750);
        video3.AddComment(new Comment("Grace", "OOP makes sense now."));
        video3.AddComment(new Comment("Hank", "Well structured video."));
        video3.AddComment(new Comment("Ivy", "Clear and concise."));
        videos.Add(video3);

        // Display all videos with comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
