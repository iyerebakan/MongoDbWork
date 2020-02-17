using System;

namespace Core.Domains.Mongo
{
    public interface IMongoEntity
    {
       
    }
    public interface IMongoEntity<T> : IMongoEntity
    {
        DateTime CreateDate { get; set; }
        DateTime? ModifyDate { get; set; }

    }
  
}
