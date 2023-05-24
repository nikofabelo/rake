using System;
using Gtk;

using Rake.GUI;

namespace Rake;

class Program
{
	[STAThread]
	public static void Main(string[] args)
	{
		Application.Init();

		Application app = new Application(
			"nikofabelo.Rake",
			GLib.ApplicationFlags.None);
		app.Register(GLib.Cancellable.Current);

		Wizard win = new Wizard();
		app.AddWindow(win);

		win.Show();
		Application.Run();

		Console.WriteLine("Running...\n");
	}
}