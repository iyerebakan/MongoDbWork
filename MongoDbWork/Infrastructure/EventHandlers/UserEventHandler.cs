using Core.Bus;
using Domain.Entities;
using Infrastructure.Events;
using Infrastructure.Services.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EventHandlers
{
    public class UserEventHandler : IEventHandler<UserCreatedEvent>
    {
        private readonly IUserService _transferRepository;

        public UserEventHandler(IUserService transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(UserCreatedEvent @event)
        {
            _transferRepository.AddAsync(new User()
            {
                Username = @event.Username,
                Email = @event.Email
            });

            return Task.CompletedTask;
        }
    }
}
