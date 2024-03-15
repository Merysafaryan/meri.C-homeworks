using System;
using System.Collections.Generic;

namespace homework_4.Entities
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
