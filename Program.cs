﻿using System.Security.Cryptography.X509Certificates;

namespace EventsDelegates
{
    internal class Program
    {

        
        static void Main(string[] args)
        {


            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService();//Subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
            


        }
    }
}
