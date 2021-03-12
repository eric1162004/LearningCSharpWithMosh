using System;
using System.Threading;

namespace Delegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1 Define a delegate
        // 2 Defien an event based on that delegate
        // 3 Raise the event

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler
        // Event<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("encoding videos...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }
}
