using gRPCGreet;

namespace WebApplicationEmpty
{
    public class Phrase
    {
        private string? strPhrase;
        public string StrPhrase { 
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
        public gRPCGreet.Phrase ToGrpc()
        {
            gRPCGreet.Phrase phrase = new gRPCGreet.Phrase();
            phrase.StrPhrase = strPhrase;
            phrase.Id = (int)Id;
            return phrase;
        }
        public static Phrase FromGrpc(gRPCGreet.Phrase p)
        {
            Phrase phrase = new Phrase();
            phrase.strPhrase = p.StrPhrase;
            phrase.id = p.Id;
            return phrase;
        }
    }
}
