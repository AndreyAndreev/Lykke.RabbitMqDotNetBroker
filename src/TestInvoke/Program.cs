﻿using System;
using Lykke.RabbitMqBroker.Subscriber;
using TestInvoke.SubscribeExample;

namespace TestInvoke
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var rabbitMqSettings = new RabbitMqSubscriberSettings
            {
                QueueName = Environment.GetEnvironmentVariable("RabbitMqQueue"),
                ConnectionString = Environment.GetEnvironmentVariable("RabbitMqConnectionString")
            };

            HowToSubscribe.Example(rabbitMqSettings);

            Console.WriteLine("Working... Press Enter to stop");
            Console.ReadLine();

            Console.WriteLine("Stopping....");
            HowToSubscribe.Stop();
            Console.WriteLine("Stopped");
            Console.ReadLine();
        }


    }
}
