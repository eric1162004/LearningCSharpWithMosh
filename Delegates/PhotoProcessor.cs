using System;

namespace Delegates
{

    public class PhotoProcessor
    {
        // public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {
            // Action<> -> points to a function return void
            // System.Action<> 
            // System.Func<> -> points to a funciton return a value
            
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}