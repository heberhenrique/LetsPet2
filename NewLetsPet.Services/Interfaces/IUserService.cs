using System;
using NewLetsPet.Domain.Security;

namespace NewLetsPet.Services.Interfaces
{
	public interface IUserService
	{
        public bool Login();
        public void RegisterUser(User user);
        public string Mensagem();
    }
}

