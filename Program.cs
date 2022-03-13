using CSharpIntermediate.Models;
using System;

namespace CSharpIntermediate
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Exercise4And5();
        }

        static void Exercise1()
        {
            // Create an instance of the stopwatch object.
            var stopwatch = new Stopwatch();

            // Pre-define the input variable.
            var input = "";

            Console.WriteLine("Please type 'start' to begin the stopwatch.");

            while (input.ToLower() != "start")
                // Get input from the user.
                input = Console.ReadLine();

            // Start the stopwatch.
            stopwatch.Start();

            Console.WriteLine("Please type 'stop' to end the stopwatch.");

            while (input.ToLower() != "stop")
                input = Console.ReadLine();

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

        static void Exercise4And5()
        {
            var dbCommand = new DbCommand(new OracleConnection("ORACLE"), "SELECT * FROM dbo.CustomerAddress");

            dbCommand.Execute();
        }
    }
}