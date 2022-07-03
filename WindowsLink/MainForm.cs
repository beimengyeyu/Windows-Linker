using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace SymbolicLink
{
	public partial class MainForm
	{
		public MainForm(string[] args)
		{
			InitializeComponent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
			_hasAdministrativeRight = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
			if (!_hasAdministrativeRight)
			{
				SendMessage(doCreateLink_.Handle, 5644U, 0U, 1U);
			}
			if (args.Length > 0)
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(args[0]));
				string[] array = @string.Split(new[] { "\r\n" }, StringSplitOptions.None);
				if (array.Length == 4)
				{
					bool flag;
					if (bool.TryParse(array[2], out flag))
					{
						linkType_File_.Checked = flag;
						linkType_Folder_.Checked = !flag;
					}
					if (bool.TryParse(array[3], out flag))
					{
						isHardLinkBox_.Checked = flag;
					}

					if (linkBox_ != null) linkBox_.Text = array[0];
					targetBox_.Text = array[1];
					MessageBox.Show(this, MakeLink() ? "OK" : "Failed");
				}
			}
		}

		[DllImport("user32")]
		private static extern uint SendMessage(IntPtr hWnd, uint msg, uint wParam, uint lParam);

		[DllImport("kernel32.dll")]
		private static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, int dwFlags);

		[DllImport("kernel32.dll")]
		private static extern bool CreateHardLink(string lpFileName, string lpExistingFileName, IntPtr lpSecurityAttributes);

		private void fileTargetPickButton__Click(object sender, EventArgs e)
		{
			if (linkType_File_.Checked)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = false;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					targetBox_.Text = openFileDialog.FileName;
				}
			}
			else
			{
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					targetBox_.Text = folderBrowserDialog.SelectedPath;
				}
			}
		}

		private void doCreateLink__Click(object sender, EventArgs e)
		{
			if (_hasAdministrativeRight)
			{
				MessageBox.Show(this, MakeLink() ? "OK" : "Failed");
				return;
			}
			string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", new object[]
			{
				linkBox_.Text,
				targetBox_.Text,
				linkType_File_.Checked,
				isHardLinkBox_.Checked
			})));
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Verb = "runas";
			processStartInfo.FileName = Application.ExecutablePath;
			processStartInfo.Arguments = text;
			try
			{
				Process.Start(processStartInfo);
				Application.Exit();
			}
			catch (Win32Exception)
			{
				MessageBox.Show("Failed");
			}
		}

		private bool MakeLink()
		{
			bool flag;
			if (linkType_File_.Checked)
			{
				flag = isHardLinkBox_.Checked ? CreateHardLink(linkBox_.Text, targetBox_.Text, IntPtr.Zero) : CreateSymbolicLink(linkBox_.Text, targetBox_.Text, 0);
			}
			else
			{
				flag = CreateSymbolicLink(linkBox_.Text, targetBox_.Text, 1);
			}
			return flag;
		}

		private void fileLinkPickButton__Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				linkBox_.Text = saveFileDialog.FileName;
			}
		}

		private void linkType__CheckedChanged(object sender, EventArgs e)
		{
			targetBox_.Text = (linkBox_.Text = "");
			if (linkType_File_.Checked)
			{
				isHardLinkBox_.Enabled = true;
				return;
			}
			isHardLinkBox_.Enabled = false;
			isHardLinkBox_.Checked = false;
		}
		
		private void targetBox__TextChanged(object sender, EventArgs e)
		{
			CheckDoCreateButton();
		}

		private void linkBox__TextChanged(object sender, EventArgs e)
		{
			CheckDoCreateButton();
		}
		
		private void CheckDoCreateButton()
		{
			bool flag;
			if (linkType_File_.Checked)
			{
				flag = File.Exists(targetBox_.Text) && !File.Exists(linkBox_.Text);
			}
			else
			{
				flag = Directory.Exists(targetBox_.Text) && !File.Exists(linkBox_.Text);
			}
			doCreateLink_.Enabled = flag;
		}

		private readonly bool _hasAdministrativeRight;
	}
}
