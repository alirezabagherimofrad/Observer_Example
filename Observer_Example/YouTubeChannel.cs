using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public class YouTubeChannel
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void UploadVideo(string title)
        {
            Console.WriteLine($"New video uploaded : {title}");
            NotifySubscribers(title);
        }

        private void NotifySubscribers(string videoTitle)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(videoTitle);
            }
        }
    }
}
