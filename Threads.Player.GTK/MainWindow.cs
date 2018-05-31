using Gtk;

namespace Threads.Player.GTK {
    public class MainWindow : Window {
        public MainWindow() : base(WindowType.Toplevel) {
            DefaultSize = new Gdk.Size(640, 480);
            
            var scrollWindow = new ScrolledWindow { Halign = Align.Fill, Valign = Align.Fill };
            var grid = new Grid { Halign = Align.Fill, Valign = Align.Fill };
            var gridViewport = new Viewport { Child = grid, Halign = Align.Fill, Valign = Align.Fill };
            
            scrollWindow.Child = gridViewport;
            Child = scrollWindow;
            
            var lorem1 = new Label {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean ultrices a erat id lacinia. Quisque fringilla, elit at ullamcorper pulvinar, eros lectus convallis risus, et auctor ligula arcu eget augue. Suspendisse potenti. Donec faucibus blandit justo, nec imperdiet velit lobortis quis. Integer finibus sem dui, vitae maximus risus pharetra quis. Quisque venenatis dolor odio, sit amet tempus magna malesuada ac. Integer rhoncus nisi sed rhoncus fermentum. Morbi nulla sem, vulputate et purus eu, gravida feugiat dui. Duis vulputate viverra turpis, id rhoncus purus facilisis at. Donec egestas lacus in semper finibus. Mauris eget rutrum urna. Vestibulum mollis sit amet felis sit amet suscipit.",
                Wrap = true,
                Halign = Align.Start,
                MarginBottom = 12
            };
            
            var lorem2 = new Label {
                Text = "Aliquam rhoncus interdum nunc. Quisque hendrerit condimentum magna id viverra. In ac est sed enim imperdiet volutpat non et ante. Vivamus aliquam lacinia lobortis. Maecenas aliquet eleifend eros quis tempus. Mauris at nulla pretium, congue nibh at, lobortis orci. Proin volutpat, quam sagittis laoreet mattis, libero neque interdum odio, sit amet feugiat metus augue vitae turpis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque nec tincidunt tellus, a imperdiet magna. Morbi sit amet purus vel mi venenatis finibus quis et lacus. Quisque aliquam blandit justo et accumsan. Nulla facilisi. Aliquam ac vulputate odio. Donec elit justo, maximus ac purus vehicula, dapibus ultrices quam.",
                Wrap = true,
                Halign = Align.Start,
                MarginBottom = 12
            };
            
            var lorem3 = new Label {
                Text = "Aliquam sit amet elit mauris. Nulla rutrum, neque ac pretium convallis, erat massa mattis lacus, vel tempus nibh sem eu nulla. Donec vitae ligula convallis, vulputate leo dignissim, pretium eros. Duis eget scelerisque felis. Fusce non leo condimentum, gravida nisi sed, consequat mi. Morbi feugiat nisi id ex pretium accumsan. Vestibulum sollicitudin tortor sed orci porttitor, placerat rutrum leo porttitor. Vivamus rutrum sodales pretium. Donec in nibh id felis finibus feugiat non in est. Nulla ornare sit amet libero ac euismod. Integer eget massa rhoncus, iaculis risus in, malesuada nibh.",
                Wrap = true,
                Halign = Align.Start,
                MarginBottom = 12
            };
            
            var lorem4 = new Label {
                Text = "Ut rutrum dolor ac iaculis hendrerit. Sed ornare eget tellus ut pellentesque. Aliquam laoreet tempus augue eget varius. Curabitur ac nisl quis orci porttitor pulvinar. Aliquam vel massa sed risus vehicula scelerisque sed id sapien. Phasellus egestas aliquam turpis, ut tempor lacus consectetur vel. Proin id aliquet elit, eget lobortis enim. Maecenas non felis vel nisl sollicitudin bibendum. Aliquam dictum erat non velit egestas aliquet. Cras neque arcu, gravida sit amet leo quis, tempus pretium ex. Mauris rhoncus dapibus laoreet. Integer sollicitudin orci dui, sit amet sollicitudin magna ornare ut.",
                Wrap = true,
                Halign = Align.Start,
                MarginBottom = 12
            };
            
            var lorem5 = new Label {
                Text = "Nam posuere turpis vitae tortor auctor, et cursus tellus gravida. Praesent congue tristique libero, quis condimentum ligula pharetra eget. Duis maximus eget ligula ac vulputate. Vivamus aliquam ornare volutpat. Donec aliquet semper eros in fermentum. In vel tempor nisi. Nam consequat enim at venenatis tincidunt. Nullam interdum, mauris eu posuere accumsan, mauris leo ornare urna, quis luctus massa metus vel augue. Ut vel sodales quam, vel sagittis erat.",
                Wrap = true,
                Halign = Align.Center,
                MarginBottom = 12
            };
            
            grid.Attach(lorem1, 0, 0, 1, 1);
            grid.Attach(lorem2, 0, 1, 1, 1);
            grid.Attach(lorem3, 0, 2, 1, 1);
            grid.Attach(lorem4, 0, 3, 1, 1);
            grid.Attach(lorem5, 0, 4, 1, 1);
        }
    }
}
