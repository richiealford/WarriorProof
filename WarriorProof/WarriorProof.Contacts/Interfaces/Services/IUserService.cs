using System;
using WarriorProof.Contacts.Models;

namespace WarriorProof.Contacts.Interfaces.Services
{
    public interface IUserService
    {
        bool IsAuthorized(string userName, string password);
        WarriorUser CreateUser(WarriorUser warriorUser);
    }
}
