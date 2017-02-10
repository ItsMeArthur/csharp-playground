using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post();
            post1.Title = "halp with c#";
            post1.Description = "i cant c#";

            post1.Downvote();
            post1.Downvote();
            post1.Downvote();
            post1.Upvote();

            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Description);
            Console.WriteLine(post1.Score);

            Post post2 = new Post();

            post2.Title = "Havind trouble with defining constructor in C#";
            post2.Description = "bla bla bla";

            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Upvote();
            post2.Downvote();

            Console.WriteLine(post2.Title);
            Console.WriteLine(post2.Description);
            Console.WriteLine(post2.Score);
            
        }
    }
}
