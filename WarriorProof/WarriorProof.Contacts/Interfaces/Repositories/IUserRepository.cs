using System;
using WarriorProof.Contracts.Models;

namespace WarriorProof.Contracts.Interfaces.Repositories
{
    public interface IUserRepository
    {
        WarriorUser GetUser(string userName, string password);
        WarriorUser CreateUser(WarriorUser warriorUser);
    }
}
