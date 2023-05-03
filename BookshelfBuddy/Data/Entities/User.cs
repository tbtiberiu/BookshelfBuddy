﻿using BookshelfBuddy.Data.Enums;

namespace BookshelfBuddy.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Role? Role { get; set; } = null;
    }
}
