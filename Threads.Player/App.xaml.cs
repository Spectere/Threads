using Avalonia;
using Avalonia.Markup.Xaml;

namespace Threads.Player {
    public class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
    }
}
