using System;

namespace CSharpIntermediate.Models
{
    class Post
    {
        private int Votes = 0;
        private string Title;
        private string Description;
        private DateTime CreationTimestamp = DateTime.Now;

        public void Upvote()
        {
            Votes += 1;
        }

        public void Downvote()
        {
            Votes -= 1;
        }

        public int GetVotes()
        {
            return Votes;
        }
    }
}