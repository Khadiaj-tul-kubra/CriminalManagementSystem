using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CriminalManagementSystem.Models
{
    public class Criminal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public string CNIC { get; set; } = string.Empty;

        public string CrimeHistory { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}