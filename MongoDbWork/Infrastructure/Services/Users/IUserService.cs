using Core.Repositories.Mongo;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Users
{
    public interface IUserService : IMongoRepository<User>
    {
    }
}
