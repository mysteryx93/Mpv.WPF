﻿using System.Text;

namespace Mpv.WPF.YouTubeDl
{
	internal static class YouTubeDlHelper
	{
		public static string GetFormatStringForVideoQuality(YouTubeDlVideoQuality videoQuality)
		{
			var stringBuilder = new StringBuilder("bestvideo");

			if (videoQuality != YouTubeDlVideoQuality.Highest)
			{
				stringBuilder.Append("[height<=");
				stringBuilder.Append((int)videoQuality);
				stringBuilder.Append("]");
			}

			stringBuilder.Append("+bestaudio/best");

			return stringBuilder.ToString();
		}
	}
}