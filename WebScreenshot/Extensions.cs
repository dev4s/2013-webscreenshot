using System;
using System.Linq;

namespace WebScreenshot
{
	public static class ConsoleArgumentsExtensions
	{
		public static string GetParameter(this string[] listOfArgs, string arg)
		{
			if (listOfArgs.Contains(arg))
			{
				try
				{
					return listOfArgs[Array.IndexOf(listOfArgs, arg) + 1];
				}
				catch (Exception)
				{
					return string.Empty;
				}
			}
			return string.Empty;
		}

		public static int GetIntParameter(this string[] listOfArgs, string arg)
		{
			if (listOfArgs.Contains(arg))
			{
				try
				{
					return int.Parse(listOfArgs[Array.IndexOf(listOfArgs, arg) + 1]);
				}
				catch (Exception)
				{
					return -1;
				}
			}
			return -1;
		}

		public static bool GetBoolParameter(this string[] listOfArgs, string arg)
		{
			if (listOfArgs.Contains(arg))
			{
				try
				{
					return bool.Parse(listOfArgs[Array.IndexOf(listOfArgs, arg) + 1]);
				}
				catch (Exception)
				{
					return true;
				}
			}
			return true;
		}
	}
}