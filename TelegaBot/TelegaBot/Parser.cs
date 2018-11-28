using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Telegram.Bot.Types;


namespace TelegaBot
{
    public static class Parser
    {
        /*public static List<Comand> commands { get; } = new List<Comand>();
        public static void Init()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Commands");
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                commands.AddRange(CollectTypes<Comand, CommandAttribute>(asm));

            }
        }
        public static  List<T> CollectTypes<T,TA>(Assembly asm)
            where TA: Attribute
        {
            var res = new List<T>();

            foreach(var type in asm.GetTypes())
            {
                var attr = type.GetCustomAttribute<TA>();
                if (attr != null)
                {
                    res.Add((T)Activator.CreateInstance(type));
                }
            }
            return res;
            
            
        }*/

        public static Message CommandParser(string command)
        {
            switch (command)
            {
                case "Show":
                    {
                        return Master.Show();
                    }
                default:
                    {

                        Message message = new Message();
                        message.Text = "Command is not existent";
                        return message;
                    }
            }

        }


    }
}
