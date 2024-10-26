using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mai_website_backend.Models.Users
{
    public class UserLoginLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public required User User { get; set; }
    }
}