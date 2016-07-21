using System;
using System.Threading.Tasks;
using PokemonGo.RocketAPI.Exceptions;

namespace PokemonGo.RocketAPI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.SetLogger(new Logging.ConsoleLogger(LogLevel.Info));

            Task.Run(() =>
            {
                try
                {
                    new Logic.Logic(new Settings()).Execute();
                }
                catch (PtcOfflineException)
                {
                    Logger.Write("PTC Servers are probably down OR your credentials are wrong. Try google", ConsoleColor.White, LogLevel.Error);
                }
                catch (Exception ex)
                {
                    Logger.Write($"Unhandled exception: {ex}", ConsoleColor.White, LogLevel.Error);
                }
            });
             System.Console.ReadLine();
        }
    }
}