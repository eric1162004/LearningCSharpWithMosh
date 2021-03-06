/* 
 *  Delegates: an object that knows how to call a method (or a group of methods)
 *  Delegate: a refernece to a function
 *  
 *  When to use interface or delgegate?
 *  Use delegate when:
 *  i. an eventing design pattern is used
 *  ii. the caller doesnt need to access other properties or methods on the object implementing the method
 */

/* 
 * Events
 * - A mechanism for communication between objects
 * - Used in building loosing coupled application
 * - Helps extending application
 * 
 * Delegate
 * - Agreement/ Contract between Publisher and Subscriber
 * - Determines the signature of the event handler method in subscriber
 */

using System;

namespace Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: sending a mesaage..." + args.Video.Title);
        }
    }
}
