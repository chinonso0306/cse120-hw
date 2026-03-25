using System;
using System.Collections.Generic;

// Class to represent a YouTube Video
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Return number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Display all comments for this video
    public void DisplayComments()
    {
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Author}: {comment.Text}");
        }
    }
}