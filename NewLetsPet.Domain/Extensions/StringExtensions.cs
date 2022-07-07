using System;
using System.Globalization;

namespace NewLetsPet.Domain.Extensions
{
	public static class StringExtensions
	{
        public static string CapitalizeLettersAfterSpace(this string text)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(text);
        }
    }
}

