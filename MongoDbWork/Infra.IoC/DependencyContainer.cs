using Core.Bus;
using Core.Infrastructure;
using Infrastructure.EventHandlers;
using Infrastructure.Events;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<UserEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<UserCreatedEvent>, UserEventHandler>();
        }
    }
}
