using System;
using System.Collections.Generic;

namespace WebAPIProj.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public int? UserRole { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
