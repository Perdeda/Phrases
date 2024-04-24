using MongoDB.Bson;

namespace gRPCTest.Mongo
{
    public class PhraseDescription
    {
        public ObjectId Id { get; set; }
        public int PhraseId { get; set; }
        public string? Description { get; set; }
    }
}
