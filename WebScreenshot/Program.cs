using System;
using System.Linq;
using System.Windows.Forms;

namespace WebScreenshot
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length != 0)
			{
				//url
				//filename
				//time between loading the page (load complete)
				//size of webbrowser
				//show bottom panel
				//image counter
				if (args.Contains("/?"))
				{
					//ignore rest parameters and show messagebox
					ShowHelpBox();
				}
				else
				{
					#region Getting Console arguments

					//url
					var tempUrl = args.GetParameter("/u");
					Uri url;
					if (!Uri.TryCreate(tempUrl, UriKind.RelativeOrAbsolute, out url))
					{
						url = null;
					}

					//filename
					var filenamePath = args.GetParameter("/f");

					//time
					var timeInSec = args.GetIntParameter("/t");
					if (timeInSec <= 0)
					{
						timeInSec = -1;
					}

					//form
					var formWidth = args.GetIntParameter("/w");
					if (formWidth <= 0)
					{
						formWidth = -1;
					}

					var formHeight = args.GetIntParameter("/h");
					if (formHeight <= 0)
					{
						formHeight = -1;
					}

					//show bottom panel
					var showBottomPanel = args.GetBoolParameter("/s");

					#endregion

					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new MainForm(url, filenamePath, timeInSec, formWidth, formHeight, showBottomPanel));
				}
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}

		public static void ShowHelpBox()
		{
			const string message = "Command line options:\r\n" +
			                       "/u url - must be with http:// [default: http://google.pl]\r\n" +
			                       "/f path\\filename.png - absolute/relative path, image filename must be end with .png [default: result.png]\r\n" +
			                       "/t time - time in seconds [default: 10]\r\n" +
			                       "/w width - window width [default and minimal: 700 ]\r\n" +
			                       "/h height - window height [default and minimal: 500]\r\n" +
			                       "/s true/fals - show bottom panel [default: true]\r\n" +
			                       "/? - this help box";

			MessageBox.Show(message, @"Help box", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
