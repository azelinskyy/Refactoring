using System;

namespace Refactoring.Loggers
{
    internal class ConsoleLogger : LoggerBase
    {
        public override void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}