using Core.Repositories.Mongo;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Customers
{
    public interface ICustomerService: IMongoRepository<Customer>
    {
    }
}
