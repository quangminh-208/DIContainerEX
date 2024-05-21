using System;
using DIContainerEX.Interface;

namespace DIContainerEX.Implement
{
    public class LogTerminal : ILogTerminal
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Write Real Log: " + info);
        }
        public void LogError(string error)
        {
            Console.WriteLine("Write Real error");
        }
        public void LogWarning(string warning)
        {
            Console.WriteLine("Write Real warning");
        }
    }
}
