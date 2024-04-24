namespace WebApplicationEmpty
{
    public static class DbActions
    {
        public static gRPCGreet.Phrase GetSpecificPhrase(int id)
        {
            return GrpcClient.Instance().GetPhrase(id);
        }
        public static List<gRPCGreet.Phrase> GetAllPhrases()
        {
            return GrpcClient.Instance().GetPhrases();
        }
        public static void AddPhrase(Phrase p)
        {
            GrpcClient.Instance().AddPhrase(p);
        }
    }
}
