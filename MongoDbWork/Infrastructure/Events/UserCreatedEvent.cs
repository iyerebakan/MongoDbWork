using Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Events
{
    public class UserCreatedEvent : Event
    {
        public string Username { get; private set; }
        public string Email { get; private set; }

        public UserCreatedEvent(string username, string email)
        {
            Username = username;
            Email = email;
        }
    }
}
