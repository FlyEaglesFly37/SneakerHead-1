using System;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class UserContext : DbContext
    {
        public DbSet<Users> user { get; set; }

        public DbSet<Sneakers> sneaker { get; set; }
        
        public DbSet<Rates> rate { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
    }
}