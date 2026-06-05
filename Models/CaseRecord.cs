using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CriminalManagementSystem.Models
{
    public class CaseRecord
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string CaseNumber { get; set; } = string.Empty;

        public string FIRId { get; set; } = string.Empty;

        public string CriminalId { get; set; } = string.Empty;

        public string CaseStatus { get; set; } = string.Empty;

        public string InvestigationOfficer { get; set; } = string.Empty;
    }
}