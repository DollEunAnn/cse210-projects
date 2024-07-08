using System;
using System.IO;

class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public int CommentCount()
    {
        int count = _comments.Count();

        return count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"By: {_author} - Duration: {_length}");

    }
    
}