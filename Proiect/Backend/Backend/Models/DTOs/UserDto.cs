﻿using Backend.Models.Enums;

namespace Backend.Models.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = default!;

        public string Email { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
    }
}
