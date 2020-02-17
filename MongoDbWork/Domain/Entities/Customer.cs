using Core.Domains.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Customer: MongoEntity<string>
    {
        public string Name { get; set; }
        public string Title { get; set; }  
    }
}
