using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mai_website_backend.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace mai_website_backend.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserLoginLog> UserLoginLogs { get; set; }
    }
}