using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CriminalManagementSystem.Models
{
    public class FIR
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string FIRNumber { get; set; } = string.Empty;

        public string ComplainantName { get; set; } = string.Empty;

        public string CrimeType { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime DateFiled { get; set; }
    }
}