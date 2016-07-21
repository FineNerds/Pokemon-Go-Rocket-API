using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Helpers
{
    public class Utils
    {
        public static ulong FloatAsUlong(double value)
        {
            var bytes = BitConverter.GetBytes(value);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static void PrintConsole(string str)
        {
            System.Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss tt") + "] " + str);
        }

        public static void PrintConsole(string str, ConsoleColor color)
        {
            ConsoleColor origColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = color;
            System.Console.WriteLine("[" + DateTime.Now.ToString("h:mm:ss tt") + "] " + str);
            System.Console.ForegroundColor = origColor;
        }
    }
}
