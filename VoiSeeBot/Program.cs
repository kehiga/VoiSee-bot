using System;
using Telegram.Bot;
using System.Threading;

namespace VoiSeeBot

{
    class Program
    {

        //token to access the HTTP API
        private static TelegramBotClient botClient = new TelegramBotClient("1520784924:AAErAfQP0f4NF5OPtE4Y8afzhOtq1OOhGm4");

        static void Main(string[] args)
        {

            botClient.OnMessage += BotClient_OnMessage;

            botClient.StartReceiving();

            Thread.Sleep(Timeout.Infinite);

            botClient.StopReceiving();

        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            Console.WriteLine(e.Message.Text);

            if(e.Message.Text.ToUpper() == "OLA" || e.Message.Text.ToUpper() == "OI")
            {
                botClient.SendTextMessageAsync(e.Message.Chat.Id, "Olá, seja bem-vindo a VoiSee - Acesse nosso site: www.voisee.io");
            }
        }
    }
}
