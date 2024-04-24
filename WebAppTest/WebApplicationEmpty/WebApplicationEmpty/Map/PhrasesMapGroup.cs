
using gRPCGreet;

namespace WebApplicationEmpty.Map
{
    public static class PhrasesMapGroup
    {
        public static RouteGroupBuilder MapPhrasesGroup(this RouteGroupBuilder group)
        {
            group.MapGet("/", MapPhrases);
            group.MapGet("/{id}", MapSpecificPhrase);

            return group;
        }
        static string MapPhrases()
        {
            string printString = "";
            List<gRPCGreet.Phrase> phrases = DbActions.GetAllPhrases();
            if (phrases.Count == 0)
            {
                InitPhrases();
                phrases = DbActions.GetAllPhrases();
            }
            printString = CreateFullPrintStirng(phrases);
            return printString;
        }
        static string MapSpecificPhrase(int id)
        {
            gRPCGreet.Phrase phrase = DbActions.GetSpecificPhrase(id);
            string str = phrase.Id + ". " + phrase.StrPhrase;
            if(phrase.HasDescription)
                str += " - " + phrase.Description;
            str += "\n";
            return str;
        }
        static string CreateFullPrintStirng(List<gRPCGreet.Phrase> phrases)
        {
            string printString = "";
            foreach (var i in phrases)
            {
                printString += i.Id + ". " + i.StrPhrase;
                if (i.HasDescription)
                    printString += " - " + i.Description;
                printString += "\n";
                Console.WriteLine(printString + i.HasDescription);
            }
            return printString;
        }
        static List<Phrase> InitPhrases()
        {
            List<Phrase> phrases = new List<Phrase>();
            Phrase p = new Phrase();
            p.StrPhrase = "TISHE CH";
            DbActions.AddPhrase(p);
            p = new Phrase();
            p.StrPhrase = "YAITSO";
            DbActions.AddPhrase(p);
            return phrases;
        }
    }
}
