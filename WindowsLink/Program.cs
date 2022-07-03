using System;
using System.Windows.Forms;

namespace SymbolicLink
{
	internal static class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			if (Environment.OSVersion.Version.Major < 6 ||
			    Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				MessageBox.Show("This program requires windows vista or up to work!");
				Application.Exit();
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(args));
		}
	}
}
