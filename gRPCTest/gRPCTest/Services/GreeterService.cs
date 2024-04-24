using Amazon.Runtime.Internal;
using Grpc.Core;
using gRPCGreet;
using gRPCTest.EF;
using gRPCTest.Mongo;

namespace gRPCTest.Services
{
    public class GreeterService : PhraseService.PhraseServiceBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        public async override Task<PhrasesResponce> GetPhrases(PhrasesRequest request, ServerCallContext context)
        {
            List<PhraseEF> phrases = DbActions.GetAllPhrases();
            PhrasesResponce responce = new PhrasesResponce();
            foreach (var i in phrases)
            {
                Phrase p = i.ToGrpc();
                
                PhraseDescription pd = await MongoActions.Instance().GetSpecificDesctiprionAsync((int)i.Id);
                try
                {
                    Console.WriteLine("Desc :" + pd.Description);
                }
                catch
                {
                    Console.WriteLine("No desc");
                }
                if (pd != null && pd.Description != null)
                { 
                    p.Description = pd.Description;
                }
                responce.Phrases.Add(p);
            }
            return await Task.FromResult(responce);
        }
        public async override Task<Phrase> GetSpecificPhrase(PhraseRequest request, ServerCallContext context)
        {
            PhraseEF p = DbActions.GetSpecificPhrase(request.Id);
            Phrase ph = p.ToGrpc();
            PhraseDescription pd = await MongoActions.Instance().GetSpecificDesctiprionAsync((int)ph.Id);
            if (pd != null && pd.Description != null)
            {
                ph.Description = pd.Description;
            }
            return await Task.FromResult(ph);
        }
        public override Task<Phrase> AddPhrase(Phrase request, ServerCallContext context)
        {
            PhraseEF p = DbActions.AddPhrase(PhraseEF.FromGrpc(request));
            Phrase fullPhrase = p.ToGrpc();
            if (request.HasDescription)
            {
                PhraseDescription pDescription = new PhraseDescription();
                pDescription.Description = request.Description;
                pDescription.PhraseId = (int)p.Id;
                MongoActions.Instance().AddPhrase(pDescription);
                fullPhrase.Description = pDescription.Description;
            }
            return Task.FromResult(p.ToGrpc());
        }
    }
}
