using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Rake.GUI;

class Wizard : Window
{
	[UI] private Label _label1 = null;
	[UI] private Button _button1 = null;

	private int counter;

	public Wizard() : this(new Builder("Wizard.glade")) { }

	private Wizard(Builder builder) : base(builder.GetRawOwnedObject("Wizard"))
	{
		builder.Autoconnect(this);

		DeleteEvent += Window_DeleteEvent;
		_button1.Clicked += Button1_Clicked;
	}

	private void Window_DeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
	}

	private void Button1_Clicked(object sender, EventArgs a)
	{
		counter++;
		_label1.Text = "Hello World! This button has been clicked " + counter + " time(s).";
	}
}