using System;
namespace TestBattle.Utility
{
    public class ConsoleLogging : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
