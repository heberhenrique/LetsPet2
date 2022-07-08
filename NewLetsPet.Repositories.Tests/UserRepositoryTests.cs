using System;
using FluentAssertions;
using NewLetsPet.Domain.Security;
using NewLetsPet.Repositories;

namespace NewLetsPet.Repositories.Tests
{
	public class UserRepositoryTests
	{
        [Fact]
        public void CreateUser()
        {
            // arrange
            UserRepository repository = new UserRepository(new BaseRepository<User>());
            User user = new User();
            user.Email = "heberhenrique@gmail.com";
            user.Password = "123456";

            // act
            repository.CreateUser(user);
            var result = repository.GetUser(user.Email);

            // assert
            result.Should().NotBeNull();
        }
    }
}

