using Autofac;
using Core.Repositories.Mongo;
using Infrastructure.DbHelper;
using Infrastructure.Services.Customers;
using Infrastructure.Services.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Modules
{
    public class RepositoryModules:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MongoDbHelper>().Named<MongoHelper>("MainDb").InstancePerLifetimeScope();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().WithParameter((pi, c) => pi.Name == "mongoHelper",
                                                                                       (pi, c) => c.ResolveNamed<MongoHelper>("MainDb"));

            builder.RegisterType<UserManager>().As<IUserService>().WithParameter((pi, c) => pi.Name == "mongoHelper",
                                                                                       (pi, c) => c.ResolveNamed<MongoHelper>("MainDb"));

        }
    }
}
