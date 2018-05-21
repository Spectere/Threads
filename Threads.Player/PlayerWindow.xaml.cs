using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Threads.Player {
    public class PlayerWindow : Window {
        public PlayerWindow() {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
