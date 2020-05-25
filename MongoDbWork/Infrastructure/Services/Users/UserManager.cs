using Core.Repositories.Mongo;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Users
{
    public class UserManager : MongoRepositoryBase<User>, IUserService
    {
        public UserManager(MongoHelper mongoHelper) : base(mongoHelper)
        {
        }
    }
}
