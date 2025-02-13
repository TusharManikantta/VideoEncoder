namespace EventsDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text Message..." + args.Video.Title);
        }
    }
}
