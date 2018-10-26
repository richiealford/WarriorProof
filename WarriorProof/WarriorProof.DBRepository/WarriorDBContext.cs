using System;
using Microsoft.EntityFrameworkCore;
using WarriorProof.Contracts.Models;

namespace WarriorProof.DBRepository
{
    public class WarriorDBContext : DbContext
    {
        public WarriorDBContext(DbContextOptions<WarriorDBContext> options)
            : base(options)
        { }

        public DbSet<WarriorUser> WarriorUsers { get; set; }
       
    }
}
