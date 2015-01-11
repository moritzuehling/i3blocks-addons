using System;
using System.IO;
using System.Net;
using RedditSharp;
using System.Reflection;

namespace mailstatus
{
	class Program
	{
		public static void Main (string[] args)
		{
			Directory.SetCurrentDirectory (Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

			var cookie = File.ReadAllLines ("cookie.txt");

			Reddit r = new Reddit ();
			var me = r.LogIn ("fs0i", cookie [0]);


			var m = 0;

			foreach (var messsage in me.UnreadMessages) {
				m++;
			}

			string result = "";

			if (m == 0)
				result += "✉ ";
			else
				result += "📩 ";

			if (m != 0)
				result += "(" + m + ")";

			Console.WriteLine (result);
			Console.WriteLine (result);

			if (m == 0)
				Console.WriteLine ("");
			else if (m < 4)
				Console.WriteLine ("00ff00");
			else 
				Console.WriteLine ("ff0000");
		}
	}
}

