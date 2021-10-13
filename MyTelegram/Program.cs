using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace MyTelegram
{
    class Program
    {
        private static string token = "1958199656:AAFfytSiyClCoeyH-PGVIh77XSU_GetvSGg";
        private static TelegramBotClient client;
        private static int counter;
        [Obsolete]
        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }

        [Obsolete]
        private static void OnMessageHandler(object sender, MessageEventArgs e)
        {
            if (e.Message != null && e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && !string.IsNullOrEmpty(e.Message.Text))
            {
                string st = e.Message.Text;
                string subString = "#резюме";
                int indexOfSubstring = st.IndexOf(subString);
                Console.WriteLine(st);
                if(indexOfSubstring == 0)
                {
                    counter++;
                }
                Console.WriteLine(counter);
            }
            if (e.Message.Text.ToLower().Contains("сколько резюме?"))
            {
                OnMessageHandler1(e.Message.Chat.Id, counter);
            }
        }

        [Obsolete]
        private static async void OnMessageHandler1(long chatId,int counter)
        {
            {
                

                    string QuantityAnswer = counter.ToString();
                    var conclusion = await client.SendTextMessageAsync(chatId, QuantityAnswer);
            }
        }
    }
}
