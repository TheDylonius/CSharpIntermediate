using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Models
{
    class UploadVideo : IActivity
    {
        private string _videoBase64;

        public UploadVideo(string source)
        {
            _videoBase64 = source;
        }

        public void Run()
        {
            if (_videoBase64 == null)
                throw new Exception("Please select a video before attempting upload...");

            Console.WriteLine($"Uploading video with ID: '{_videoBase64}' to Cloudflare...");
        }
    }
}