using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using mai_website_backend.Models.Users;

namespace mai_website_backend.Models.Users
{
    public class User
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string EmailAddress { get; set; }
        public required string Password { get; set; }
        public required string Salt { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public required DateTime UpdatedAt { get; set; } = DateTime.Now;


        public ICollection<UserLoginLog>? UserLoginLogs { get; }
    }
}