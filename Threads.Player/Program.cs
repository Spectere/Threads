using Avalonia;

namespace Threads.Player {
    internal static class Program {
        private static void Main(string[] args) {
            AppBuilder.Configure<App>().UsePlatformDetect().Start<PlayerWindow>();
        }
    }
}
