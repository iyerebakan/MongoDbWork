using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Core.Domains.Mongo
{
    public abstract class MongoEntity<T> :IMongoEntity<T>
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public T _id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
