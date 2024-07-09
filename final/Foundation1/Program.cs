using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        List<string> peopleComments = new List<string>
        {
            "Wow, Amazing!",
            "Awesome, fishes.",
            "Kawaii",
            "I love fish.",
            "Your videos are great",
            "Keep making this videos",
            "Content that I love",
            "How did I get here?",
            "New subscriber!!",
            "I wish I am a fish",
            "You should make video about cats",
            "Please feature some sharks too",
            "Is there a dog fish too?",
            "I don't like fish.",
            "Let's gooooo",
            "Content I sign up for.",
            "So how many series? YES."
        };


        for (int j = 1; j <= 4; j++)
        {
            Video v1 = new Video($"Fish Series - Part {j}", $"CherryRoseLoveFish", 10);          

            for (int i = 1; i <= 3; i++)
            {
                // get random comment
                Random r2 = new Random();
                int index = r2.Next(peopleComments.Count);

                Comment newComment = new Comment();
                
                newComment._name = $"Person-{i}";
                newComment._comment = $"{peopleComments[index]}";

                v1.AddComment(newComment);

            }

            // display the title, author, lenght, and number of comments
            Console.WriteLine();
            v1.DisplayVideoDetails();
            Console.WriteLine();

            // list out all of the comments of the video
            Console.WriteLine("Comments:");            
            foreach (var comment in v1._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._comment}");
            }

            Console.WriteLine();
            Console.WriteLine("=====================================");
        }

    }
}