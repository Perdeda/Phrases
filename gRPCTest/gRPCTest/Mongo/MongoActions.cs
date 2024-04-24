using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace gRPCTest.Mongo
{
    public class MongoActions
    {
        IMongoDatabase database;
        static MongoActions instance;
        MongoActions() 
        {
            Task t = MongoInit();
        }
        public static MongoActions Instance()
        {
            if (instance == null)
                instance = new MongoActions();
            return instance;
        }
        async Task MongoInit()
        {
            MongoClient client = new("mongodb://root:example@localhost:27017/");

            database = client.GetDatabase("test");
            await database.CreateCollectionAsync("PhraseDescriptions");
        }
        public void AddPhrase(PhraseDescription description)
        {
            Task t = AddPhraseAsync(description);
        }
        async Task AddPhraseAsync(PhraseDescription description)
        {
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("PhraseDescriptions");
            BsonDocument doc = description.ToBsonDocument();
            try
            {
                var options = new CreateIndexOptions() { Unique = true };
                var field = new StringFieldDefinition<BsonDocument>("PhraseId");
                var indexDefinition = new IndexKeysDefinitionBuilder<BsonDocument>().Ascending(field);
                var indexModel = new CreateIndexModel<BsonDocument>(indexDefinition, options);

                await collection.Indexes.CreateOneAsync(indexModel);
                await collection.InsertOneAsync(doc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public async Task<PhraseDescription> GetSpecificDesctiprionAsync(int id)
        {
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("PhraseDescriptions");
            List<BsonDocument> descriptions = await collection.Find(new BsonDocument("PhraseId", id)).ToListAsync();
            PhraseDescription desc = new PhraseDescription();
            if (descriptions.Count > 0)
                desc = BsonSerializer.Deserialize<PhraseDescription>(descriptions.FirstOrDefault());
            else
            {
                desc.PhraseId = -1;
            }
            return desc;
        }
    }
}
