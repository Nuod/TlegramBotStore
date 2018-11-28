using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Net;

namespace TelegaBot
{
    class Program
    {
        static ITelegramBotClient botClient;

        static Master master = new Master();
        static void Main()
        {
            var httpProxy = new WebProxy(Host: "109.192.91.198", Port: 53701) { };
            botClient = new TelegramBotClient("713482448:AAHev0QaAKY47t5O3HTtNv0e636PcftYidE", httpProxy);

            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(
            $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            );

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);
        }

        static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            master.ProcessMessage()
        }
    }
}

