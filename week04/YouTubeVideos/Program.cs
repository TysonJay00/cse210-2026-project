using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("New Batman Movie Anouncement!", "MovieWatcher", 10);
        video1.AddComment(new Comment("Joe Smith", "I'm so excited!!"));
        video1.AddComment(new Comment("Bob Gordan", "Really? Another batman movie?"));
        video1.AddComment(new Comment("Cynthia Beavis", "Great analysis. I can't wait to see it"));
        videos.Add(video1);

        Video video2 = new Video("How to boost a car", "Mechanic1", 3);
        video2.AddComment(new Comment("Jackson Johnson", "Thank you for teaching us!"));
        video2.AddComment(new Comment("Janet Jackson", "I was so lost, but your explanation helped me"));
        video2.AddComment(new Comment("River Pheonix", "Thanks for the video!"));
        videos.Add(video2);

        Video video3 = new Video("Signing Jingle bells", "awesomeChoir47", 4);
        video3.AddComment(new Comment("Jim Halpert", "Great singing!"));
        video3.AddComment(new Comment("Pam Beasly", "Yikes! get some singing lessons ASAP!"));
        video3.AddComment(new Comment("Oscar Martinez", "Sweet! I love your version!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} Minutes");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine($"Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();

        }
    } 
}