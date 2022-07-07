using System;
using NewLetsPet.Domain.Security;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Repositories.Interfaces.Base;

namespace NewLetsPet.Repositories
{
	public class UserRepository : IUserRepository
    {
		private readonly IBaseRepository<User> _database;
        public List<User> Users { get; }

        public UserRepository(IBaseRepository<User> database)
		{
			_database = database;

            var values = _database.Get();
            if (values != null)
                Users = values.ToList();
            else
                Users = new();
        }

		public User GetUser(string email)
		{
			return Users.FirstOrDefault(user => user.Email == email);
        }

        public void CreateUser(User user)
        {
            var exists = GetUser(user.Email);
            if (exists == null)
            {
                Users.Add(user);
                _database.Save(Users);
            }
        }
    }
}

