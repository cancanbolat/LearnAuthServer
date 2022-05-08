using AuthServer.Entities;
using Microsoft.AspNetCore.Identity;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> userManager;

        public UserRepository(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public Task<User> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByName(string username)
        {
            var user = await userManager.FindByNameAsync(username);

            if (user == null)
                throw new Exception("User not found");

            return user;
        }

        public async Task<User> GetUserById(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
                throw new Exception("User not found");

            return user;
        }

        public Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(UserRegisterDto userRegisterDto)
        {
            var user = new User()
            {
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                UserName = userRegisterDto.UserName,
                Email = userRegisterDto.Email,
                BirthDate = userRegisterDto.BirthDate,
                PhoneNumber = userRegisterDto.PhoneNumber
            };

            var result = await userManager.CreateAsync(user, userRegisterDto.Password);

            if (!result.Succeeded)
            {
                throw new Exception("Register error");
            }

            return $"{user.FirstName} {user.LastName}";
        }
    }
}
