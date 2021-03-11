using System;
using System.Threading;

namespace Delegates
{
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("encoding videos...");
            Thread.Sleep(3000);
        }
    }
}
