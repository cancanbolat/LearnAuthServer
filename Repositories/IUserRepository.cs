using AuthServer.Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Repositories
{
    public interface IUserRepository
    {
        public Task<User> GetUserByName(string username);
        public Task<User> GetUserById(string id);
        public Task<List<User>> GetUsers();
        public Task<User> CreateUser(User user);
        public Task<User> UpdateUser(User user);
        public Task<bool> DeleteUser(Guid Id);
        public Task<string> Register(UserRegisterDto userRegisterDto);
    }
}
