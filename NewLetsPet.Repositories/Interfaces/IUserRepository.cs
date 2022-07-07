using System;
using NewLetsPet.Domain.Security;

namespace NewLetsPet.Repositories.Interfaces
{
	public interface IUserRepository
	{
        public User GetUser(string email);
        public void CreateUser(User user);
    }
}

