using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using NewLetsPet.Domain.Base;
using NewLetsPet.Domain.Security.Validators;

namespace NewLetsPet.Domain.Security
{
    /// <summary>
    /// Represents user information for access application
    /// </summary>
	public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class
        /// </summary>
        /// <param name="email">user email</param>
        public User(string email)
        {
            Email = email;
        }
    }
}

