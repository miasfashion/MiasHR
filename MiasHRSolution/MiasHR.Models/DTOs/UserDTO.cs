﻿namespace MiasHR.Models.DTOs
{
    public class UserDTO
    {
        public required string Username { get; set; }

        public required string PasswordHash { get; set; }
    }
}
