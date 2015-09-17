using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WebScreenshot
{
	public partial class MainForm : Form
	{
		private Uri _url;
		private string _filenamePath;
		private readonly int _timeInSec;
		private readonly int _formWidth;
		private readonly int _formHeight;
		private readonly bool _showBottomPanel;

		private readonly bool _consoleRun;

		public MainForm(Uri url, string filenamePath, int timeInSec, int formWidth, int formHeight, bool showBottomPanel)
		{
			_url = url;
			_filenamePath = filenamePath;
			_timeInSec = timeInSec;
			_formWidth = formWidth;
			_formHeight = formHeight;
			_showBottomPanel = showBottomPanel;
			_consoleRun = true;

			InitializeComponent();
		}

		public MainForm()
		{
			_consoleRun = false;

			InitializeComponent();
		}

		private void buttonTakeScreenshot_Click(object sender, EventArgs e)
		{
			MakeScreenshot();
		}

		private void timerScreenshot_Tick(object sender, EventArgs e)
		{
			MakeScreenshot();

			timerScreenshot.Stop();
			timerScreenshot.Enabled = false;

			Close();
		}

		private void MakeScreenshot()
		{
			//Default save file location
			var capturedImage = Xfnd.Capture.Control(webBrowser);
			capturedImage.Save(_filenamePath, ImageFormat.Png);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (_url == null)
			{
				_url = new Uri("http://google.com");
			}
			webBrowser.Url = _url;

			_filenamePath = string.IsNullOrEmpty(_filenamePath) ? "result.png" : _filenamePath;

			if (_formWidth != -1)
			{
				Width = _formWidth > 700 ? _formWidth : 700;
			}

			if (_formHeight != -1)
			{
				Height = _formHeight > 500 ? _formHeight : 500;
			}

			CenterToScreen();

			if (_consoleRun)
			{
				panelBottom.Visible = _showBottomPanel;
				timerScreenshot.Interval = (_timeInSec == -1 ? 10 : _timeInSec) * 1000;
				timerScreenshot.Enabled = true;
				timerScreenshot.Start();
			}
			else
			{
				panelBottom.Visible = true;
				timerScreenshot.Stop();
				timerScreenshot.Enabled = false;
			}
		}

		private void buttonGo_Click(object sender, EventArgs e)
		{
			if (textBoxUrl.Text.Contains("http://"))
			{
				webBrowser.Url = new Uri(textBoxUrl.Text);
			}
			else
			{
				textBoxUrl.Text = @"http://" + textBoxUrl.Text;
				webBrowser.Url = new Uri("http://" + textBoxUrl.Text);
			}

			//webBrowser.Url = new Uri(textBoxUrl.Text);
		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			Program.ShowHelpBox();
		}
	}
}
