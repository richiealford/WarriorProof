using System;
using WarriorProof.Contracts.Models;

namespace WarriorProof.Contracts.Interfaces.Services
{
    public interface IUserService
    {
        bool IsAuthorized(string userName, string password);
        WarriorUser CreateUser(WarriorUser warriorUser);
    }
}
