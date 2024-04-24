using gRPCGreet;

namespace gRPCTest.EF
{
    public class PhraseEF
    {
        private string? strPhrase;
        public string StrPhrase
        {
            get
            {
                return strPhrase;
            }
            set
            {
                strPhrase = value;
            }
        }

        private long id;
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Phrase ToGrpc()
        {
            Phrase phrase = new Phrase();
            phrase.StrPhrase = strPhrase;
            phrase.Id = (int)Id;
            return phrase;
        }
        public static PhraseEF FromGrpc(Phrase p)
        {
            PhraseEF phrase = new PhraseEF();
            phrase.strPhrase = p.StrPhrase;
            phrase.id = p.Id;
            return phrase;
        }
    }
}
