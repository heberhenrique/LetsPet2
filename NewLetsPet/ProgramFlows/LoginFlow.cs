using System;
using System.Text;
using FluentValidation;
using NewLetsPet.Domain.Security;
using NewLetsPet.Domain.Security.Validators;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Login;

namespace NewLetsPet.ProgramFlows
{
	public static class LoginFlow
	{
        private static UserValidator _validator = new UserValidator();
        private static List<string> _errorMessages =  new List<string>();

        public static bool LogIn()
        {
            var response = false;
            User user = null;
            user = GetUser(user);
            user = GetPassword(user);

            return response;
        }

        private static User GetUser(User user)
        {
            bool validUser = false;
            do
            {
                var messages = string.Empty;

                if (user != null && _errorMessages.Count > 0)
                {
                    messages = _errorMessages.Aggregate((i, j) => $"{i}, {j}");
                }

                user = new(ScreenPresenter.Show(LoginScreen.UserScreen, messages));
                var results = _validator.Validate(user, options => options.IncludeRuleSets("User"));
                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        _errorMessages.Add(failure.ErrorMessage);
                    }
                }
                else
                {
                    _errorMessages.Clear();
                }
            }
            while (!validUser);

            return user;
        }

        private static User GetPassword(User user)
        {
            bool validPassword = false;
            do
            {
                var messages = string.Empty;

                if (user != null && _errorMessages.Count > 0)
                {
                    messages = _errorMessages.Aggregate((i, j) => $"{i}, {j}");
                }

                user.Password = ScreenPresenter.Show(LoginScreen.PasswordScreen, messages, true);

                var results = _validator.Validate(user, options => options.IncludeRuleSets("Password"));
                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        _errorMessages.Add(failure.ErrorMessage);
                    }
                }
                else
                {
                    _errorMessages.Clear();
                }
            }
            while (!validPassword);

            return user;
        }
    }
}

