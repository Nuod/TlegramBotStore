using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TelegaBot
{
    static class Master
    {

        public static void Process(Telegram.Bot.Types.Message message)
        {
            Parser.CommandParser(message.Text);
        }

        public static Message Show()
        {
            Message message = new Message();
            message.Text = "All the Goods";
            return message;
        }
    }

}
