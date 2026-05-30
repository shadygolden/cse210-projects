using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C#", "John Smith", 600);

        video1.AddComment(new Comment("Mary", "Great explanation!"));
        video1.AddComment(new Comment("James", "Very helpful video."));
        video1.AddComment(new Comment("Sarah", "I learned a lot from this."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Object-Oriented Programming", "Alice Brown", 850);

        video2.AddComment(new Comment("Michael", "Excellent content."));
        video2.AddComment(new Comment("Daniel", "Can you make more tutorials?"));
        video2.AddComment(new Comment("Grace", "This helped my assignment."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Programming Basics", "David Wilson", 420);

        video3.AddComment(new Comment("Emma", "Very beginner friendly."));
        video3.AddComment(new Comment("Sophia", "Nice examples."));
        video3.AddComment(new Comment("Lucas", "Thanks for sharing."));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Advanced C# Concepts", "Chris Johnson", 1200);

        video4.AddComment(new Comment("Olivia", "Fantastic teaching style."));
        video4.AddComment(new Comment("Noah", "I understand abstraction better now."));
        video4.AddComment(new Comment("Liam", "Please upload more advanced topics."));

        videos.Add(video4);

        // Display Videos
        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}