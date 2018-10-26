using System;
using System.Linq;
using WarriorProof.Contracts.Interfaces.Repositories;
using WarriorProof.Contracts.Models;

namespace WarriorProof.DBRepository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WarriorDBContext _context;
        public UserRepository(WarriorDBContext context)
        {
            _context = context;
        }

        public WarriorUser GetUser(string userName, string password)
        {
            return _context.WarriorUsers
               .FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }

        public WarriorUser CreateUser(WarriorUser warriorUser)
        {
            _context.WarriorUsers.Add(warriorUser);
            _context.SaveChanges();
            return warriorUser;
        }
    }
}
