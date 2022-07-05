using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace NewLetsPet.Domain.Security.Validators
{
    /// <summary>
    /// Represents a class validator for <see cref="User"/> class
    /// </summary>
	public class UserValidator : AbstractValidator<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserValidator"/> class
        /// </summary>
		public UserValidator()
		{
            RuleSet("User", () =>
            {
                RuleFor(user => user.Email)
                .NotEmpty().WithMessage("E-mail não pode ser vazio")
                .Must(BeAValidEmail).WithMessage("E-mail inválido!");
            });

            RuleSet("Password", () =>
            {
                RuleFor(user => user.Password)
                .NotEmpty().WithMessage("Senha não pode ser vazia").When(user => !string.IsNullOrWhiteSpace(user.Email));
            });

            
        }

        /// <summary>
        /// Checks if email address is valid
        /// </summary>
        /// <param name="email">email address</param>
        /// <returns>true if is a valid email otherwise returns false</returns>
        private bool BeAValidEmail(string email)
        {
            var emailAddress = new EmailAddressAttribute();
            var isValid = emailAddress.IsValid(email);
            return isValid;
        }
    }
}

