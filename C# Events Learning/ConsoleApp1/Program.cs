 namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Video youtube = new Video();
            youtube.Title = "Unreal Engine Combat System Tutorial";

            VideoEncoder youtubeEncoder = new VideoEncoder(); //publisher
            MailService mailService = new MailService();  //SubScriber

           youtubeEncoder.Encode(youtube);
        }

    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email....");
        }
    }

}