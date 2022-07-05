﻿using System;
namespace NewLetsPet.Infrastructure
{
    /// <summary>
    /// Controls presentation engine.
    /// </summary>
	public static class ScreenPresenter
	{
        /// <summary>
        /// Show screen or message and return user input
        /// </summary>
        /// <param name="screen">screen to be presented</param>
        /// <param name="toUpper">if true, return string will be uppercase</param>
        /// <returns>User input</returns>
        public static string Show(string screen, string errorMessage = "", bool isSecret = false, bool toUpper = false)
        {
            var response = string.Empty;
            Console.Clear();
            Console.WriteLine(screen);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                Console.WriteLine();
                var defaultBackgroundColor = Console.BackgroundColor;
                var defaultForegroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(errorMessage);
                Console.BackgroundColor = defaultBackgroundColor;
                Console.ForegroundColor = defaultForegroundColor;
            }


            if (isSecret)
                response = GetPassword();
            else
                response = Console.ReadLine().Trim();

            if (toUpper)
                response = response.ToUpper();

            return response;
        }

        private static string GetPassword()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            return pass;
        }
    }
}
