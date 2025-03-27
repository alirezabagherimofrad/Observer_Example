namespace Observer_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel channel = new YouTubeChannel();

            User user1 = new User("Alice");

            User user2 = new User("Bob");

          
            channel.Subscribe(user1);

            channel.Subscribe(user2);

          
            channel.UploadVideo("Observer Pattern Explained");

            channel.Unsubscribe(user2);

            channel.UploadVideo("Design Patterns in C#");
            
        }
    }
}
