﻿namespace UserManagementAPI.Models.Dtos
{
    public class AddUserDto
    {
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
