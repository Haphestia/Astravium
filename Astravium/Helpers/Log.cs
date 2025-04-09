using StardewModdingAPI;

namespace Astravium.Helpers
{
    internal static class Log
    {
        private static IMonitor? _monitor;
        public static void Configure(IMonitor monitor)
        {
            _monitor = monitor;
        }
        public static void Info(string message)
        {
            _monitor?.Log(message, LogLevel.Info);
        }
    }
}
