using System;

namespace fancytime
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] fullHours = {"🕛", "🕐", "🕑", "🕒", "🕓", "🕔", "🕕", "🕖", "🕗", "🕘", "🕙", "🕚"};
			string[] halfHours = {"🕧","🕜","🕝","🕞","🕟","🕠","🕡","🕢","🕣","🕤","🕥","🕦"};

			var now = DateTime.Now;

			//because I want the 23:00:00 clock from 22:45:00 on, the 
			//17:30:00 clock from 17:15:00 on, etc. 
			//so we always show the closes half hour. 
			var nowClock = now.AddMinutes (15); 

			string[] arr = nowClock.Minute < 30 ? fullHours : halfHours;

			string clock = arr [nowClock.Hour % 12];

			Console.WriteLine ("{0} {1}:{2}:{3}", clock, now.Hour.ToString("00"), now.Minute.ToString("00"), now.Second.ToString("00"));
			Console.WriteLine ("{0} {1}:{2}:{3}", clock, now.Hour.ToString("00"), now.Minute.ToString("00"), now.Second.ToString("00"));
			Console.WriteLine ("#" +
				"ffffff", clock, now.Hour.ToString("00"), now.Minute.ToString("00"), now.Second.ToString("00"));
		}
	}
}
