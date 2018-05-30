using System;
using Gtk;
using Pango;
using Window = Gtk.Window;
using WindowType = Gtk.WindowType;

namespace Threads.Player.GTK {
    public class MainWindow : Window {
        public MainWindow() : base(WindowType.Toplevel) {
            DefaultSize = new Gdk.Size(640, 480);
            
            var scrolledWindow = new ScrolledWindow();
            Child = scrolledWindow;

            var label = new Label {
                Markup = "<b><span fgcolor='#FF7F7F'>Threads?</span></b> <i><span fgcolor='#7F7FFF'>Threads!</span></i>"
            };

            scrolledWindow.Child = label;
        }
    }
}
