using System;
using NewLetsPet.Domain.Security;
using NewLetsPet.Repositories;
using NewLetsPet.Repositories.Base;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Services.Interfaces;

namespace NewLetsPet.Services
{
	public class UserService : IUserService
    {
		private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
        }

		public bool Login()
		{
			var response = false;

			return response;
		}

        public void RegisterUser(User user)
        {
            _userRepository.CreateUser(user);
        }

		public string Mensagem()
		{
			return "Boa noite, vizinhança!";
		}
    }
}

