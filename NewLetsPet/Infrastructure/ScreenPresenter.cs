using System;
using NewLetsPet.Domain.Extensions;

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

        public static int GetOption(
            string screen,
            int initialMenu,
            int endMenu,
            string customMessage = null)
        {
            int response;
            var messages = string.Empty;

            while (!int.TryParse(Show(screen, messages), out response) ||
                !(response >= initialMenu && response <= endMenu))
                messages = customMessage ?? "Opção Inválida";

            return response;
        }

        public static string GetInput(
            string screen,
            Predicate<string> predicate,
            string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            while(!predicate.Invoke(response = Show(screen, messages)))
                messages = customMessage ?? "Opção Inválida";

            return response;
        }

        public static string GetInputCamelCase<T>(
            string screen,
            Predicate<string> predicate,
            string customMessage = null)
        {
            return GetInput(screen, predicate, customMessage).CapitalizeLettersAfterSpace();
        }

        public static string GetCpf(
            string screen,
            Predicate<string> predicate,
            string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            while ((response = Show(screen, messages)).ValidateCpf() &&
                !predicate.Invoke(response))
                messages = customMessage ?? "CPF inválido.";

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

