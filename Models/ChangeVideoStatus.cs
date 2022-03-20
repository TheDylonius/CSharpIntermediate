using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Models
{
    class ChangeVideoStatus : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Video status was successfully changed in the database.");
        }
    }
}