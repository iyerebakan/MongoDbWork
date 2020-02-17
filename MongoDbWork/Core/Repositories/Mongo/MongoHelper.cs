using MongoDB.Driver;

namespace Core.Repositories.Mongo
{
    public abstract class MongoHelper
    {
        public IMongoDatabase Connection {get { return _connection; } }

        private readonly IMongoDatabase _connection;

        protected MongoHelper()
        {
            _connection = CreateConnection();
        }
        protected abstract IMongoDatabase CreateConnection();

    }
}
