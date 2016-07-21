using System;

namespace PokemonGo.RocketAPI.Logging
{
	/// <summary>
	/// The ConsoleLogger is a simple logger which writes all logs to the Console.
	/// </summary>
	public class ConsoleLogger : ILogger
	{
		private LogLevel maxLogLevel;
        private ConsoleColor def = ConsoleColor.Gray;

		/// <summary>
		/// To create a ConsoleLogger, we must define a maximum log level.
		/// All levels above won't be logged.
		/// </summary>
		/// <param name="maxLogLevel"></param>
		public ConsoleLogger(LogLevel maxLogLevel)
		{
			this.maxLogLevel = maxLogLevel;
		}

        /// <summary>
        /// Log a specific message by LogLevel. Won't log if the LogLevel is greater than the maxLogLevel set.
        /// </summary>
        /// <param name="message">The message to log. The current time will be prepended.</param>
        /// <param name="col">Sets the color of the text.</param>
        /// <param name="level">Optional. Default <see cref="LogLevel.Info"/>.</param>
        public void Write(string message, ConsoleColor col, LogLevel level = LogLevel.Info)
		{
            if (level > maxLogLevel)
                return;

            ConsoleColor origColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = col;
            Console.WriteLine($"[{ DateTime.Now.ToString("h:mm:ss tt")}] { message }");
            System.Console.ForegroundColor = origColor;
        }
    }
}