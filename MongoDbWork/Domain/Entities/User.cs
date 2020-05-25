using Core.Domains.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : MongoEntity<string>
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }

}
