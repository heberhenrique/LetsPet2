using System;
using NewLetsPet.Domain.Security;

namespace NewLetsPet.Repositories.Interfaces
{
	public interface IUserRepository2 : IUserRepository
    {
        public User GetUserById(int id);
    }
}

