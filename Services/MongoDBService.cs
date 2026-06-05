using MongoDB.Driver;
using CriminalManagementSystem.Models;

namespace CriminalManagementSystem.Services
{
    public class MongoDBService
    {
        private readonly IMongoDatabase _database;

        public MongoDBService(IConfiguration configuration)
        {
            var client = new MongoClient(
                configuration["MongoDbSettings:ConnectionString"]);

            _database = client.GetDatabase(
                configuration["MongoDbSettings:DatabaseName"]);
        }

        public IMongoCollection<FIR> FIRs =>
            _database.GetCollection<FIR>("FIRs");

        public IMongoCollection<Criminal> Criminals =>
            _database.GetCollection<Criminal>("Criminals");

        public IMongoCollection<CaseRecord> Cases =>
            _database.GetCollection<CaseRecord>("Cases");
    }
}