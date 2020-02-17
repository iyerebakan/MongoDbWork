using Core.Repositories.Mongo;
using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Customers
{
    public class CustomerManager : MongoRepositoryBase<Customer>, ICustomerService
    {
        public CustomerManager(MongoHelper mongoHelper) : base(mongoHelper)
        {
        }
    }
}
