using System;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); //publisher

            var mailService = new MailService(); //subscriber


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;



            videoEncoder.Encode(video);
            
        }
    }

    //Creating a subscriber
    public class MailService
    {
        //Define the method that conforms the signature of delegate defined inside VideoEncoder.cs  - that means must be void and two paramters
        
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mailservice sending an email.....");
        }

    }
}
