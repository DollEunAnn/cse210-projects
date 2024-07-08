using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        for (int j = 1; j <= 4; j++)
        {
            Video v1 = new Video($"Fish-{j}", $"Cherry Rose-{j}", 10);          

            for (int i = 1; i <= 3; i++)
            {
                Comment newComment = new Comment();
                {
                    newComment._name = $"Person-{i}";
                    newComment._comment = $"America-ya-{i}";
                }

                v1.AddComment(newComment);

            }

            int count = v1.CommentCount();

            v1.DisplayVideo();
            Console.WriteLine($"Comments: {count}");

            foreach (var comment in v1._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._comment}");
            }
        }

    }
}