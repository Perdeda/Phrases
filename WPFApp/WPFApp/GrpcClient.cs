using Grpc.Net.Client;
using gRPCGreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
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
            if (instance == null)
                instance = new GrpcClient();
            return instance;
        }
        public void AddPhrase(PhrasePackage phrase)
        {
            client.AddPhrase(phrase.ToGrpc());
        }
    }
}
