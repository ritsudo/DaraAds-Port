﻿namespace DaraAds.Application.Services.User.Contracts
{
    public static class Register
    { 
        public sealed class Request
        {
            public string Name { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public string Password { get; set; }
        }
        
        public sealed class Response
        {
            public int UserId { get; set; }
                
        }
    }
}