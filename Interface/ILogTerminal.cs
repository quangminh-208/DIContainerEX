namespace DIContainerEX.Interface
{
    public interface ILogTerminal
    {
        void LogInfo(string info);
        void LogWarning(string warning);
        void LogError(string error);
    }
}
