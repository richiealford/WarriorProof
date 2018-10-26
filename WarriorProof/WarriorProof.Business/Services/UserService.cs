using System;
using Microsoft.EntityFrameworkCore;
using WarriorProof.Contacts.Interfaces.Repositories;
using WarriorProof.Contacts.Interfaces.Services;
using WarriorProof.Contacts.Models;

namespace WarriorProof.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsAuthorized(string userName, string password)
        {
            var user = _userRepository.GetUser(userName, password);
            return !(user == null);
        }

        public WarriorUser CreateUser(WarriorUser warriorUser)
        {
            return _userRepository.CreateUser(warriorUser);
        }
    }
}
