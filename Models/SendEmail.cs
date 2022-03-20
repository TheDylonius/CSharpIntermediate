using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Models
{
    class SendEmail : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Email was sent successfully...");
        }
    }
}