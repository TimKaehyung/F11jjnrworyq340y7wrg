using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace SleepyBot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
           

            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "MzUzNzE1NDc2MTQyMjI3NDYw.DI35mQ.ow84XktAOjnSrcPQfBNeEMgY4AI");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}
