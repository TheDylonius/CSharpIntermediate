using CSharpIntermediate.Models;
using System;

namespace CSharpIntermediate
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Exercise3();
        }

        static void Exercise1()
        {
            // Create an instance of the stopwatch object.
            var stopwatch = new Stopwatch();

            // Start the stopwatch.
            stopwatch.Start();

            // Stop the stopwatch.
            stopwatch.Stop();

            // Display the time taken in the console.
            Console.WriteLine($"Total Duration: {stopwatch.GetDuration()}");
        }

        static void Exercise2()
        {
            // Create an instance of the post object.
            var post = new Post();

            // Upvote & Downvote the post a couple times.
            post.Upvote();
            post.Upvote();
            post.Downvote();
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Downvote();

            // Display the total votes in the console.
            Console.WriteLine($"Total Votes: {post.GetVotes()}");
        }

        static void Exercise3()
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        static void Exercise4()
        {

        }
    }
}