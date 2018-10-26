using System;
using WarriorProof.Contacts.Models;

namespace WarriorProof.Contacts.Interfaces.Repositories
{
    public interface IUserRepository
    {
        WarriorUser GetUser(string userName, string password);
        WarriorUser CreateUser(WarriorUser warriorUser);
    }
}
