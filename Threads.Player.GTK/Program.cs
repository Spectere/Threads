using System;
using GLib;
using Gtk;
using Application = Gtk.Application;

namespace Threads.Player.GTK {
    internal static class Program {
        private static Application _app;
        private static Window _wnd;
        
        internal static void Main(string[] args) {
            Application.Init();

            _app = new Application("net.spectere.Threads.Player", GLib.ApplicationFlags.HandlesCommandLine);
            _app.Register(Cancellable.Current);

            _wnd = new MainWindow();
            _app.AddWindow(_wnd);
            
            var quitAction = new SimpleAction("quit", null);
            quitAction.Activated += Application_OnQuit;
            _app.AddAction(quitAction);

            _wnd.Destroyed += Application_OnQuit;

            _wnd.ShowAll();
            Application.Run();
        }

        private static void Application_OnQuit(object sender, EventArgs e) {
            Application.Quit();
        }
    }
}
