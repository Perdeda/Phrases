using Grpc.Net.Client;
using gRPCGreet;

namespace WebApplicationEmpty
{
    public class GrpcClient
    {
        static GrpcClient instance;
        PhraseService.PhraseServiceClient client;
        GrpcClient() 
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5062");
            client = new PhraseService.PhraseServiceClient(channel);
            Console.WriteLine(channel.State);
            Console.WriteLine(client.ToString());
        }
        public static GrpcClient Instance()
        {
            if(instance == null)
                instance = new GrpcClient();
            return instance;
        }
        public List<gRPCGreet.Phrase> GetPhrases()
        {
            Console.WriteLine("asdsadasd");
            Console.WriteLine(client.ToString());
            var call = client.GetPhrases(new PhrasesRequest());

            var response = call.Phrases;
            List<gRPCGreet.Phrase> result = new List<gRPCGreet.Phrase>();
            foreach (var i in response)
            {
                result.Add(i);
            }
            return result;
        }
        public gRPCGreet.Phrase GetPhrase(int id)
        {
            PhraseRequest request = new PhraseRequest();
            request.Id = id;
            gRPCGreet.Phrase call = client.GetSpecificPhrase(request);
            return call;
        }
        public void AddPhrase(Phrase phrase)
        {
            client.AddPhrase(phrase.ToGrpc());
        }
    }
}
