namespace gRPCTest.EF
{
    public static class DbActions
    {
        public static List<PhraseEF> GetAllPhrases()
        {
            using (AppContext db = new AppContext())
            {
                return db.Phrases.ToList();
            }
        }
        public static PhraseEF AddPhrase(PhraseEF p)
        {
            using (AppContext db = new AppContext())
            {
                db.Phrases.Add(p);
                db.SaveChanges();
            }
            return p;
        }
        public static PhraseEF GetSpecificPhrase(int id)
        {
            using (AppContext db = new AppContext())
            {
                foreach (var v in db.Phrases)
                {
                    if (id == v.Id)
                        return v;
                }
            }
            throw new HttpRequestException("ALE NE TU TAKOGO");
        }
    }
}
