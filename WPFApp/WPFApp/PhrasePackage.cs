using gRPCGreet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
#nullable enable
    public class PhrasePackage : INotifyPropertyChanged
    {
        private string phrase = "";
        private string description = "";
        public string Phrase { 
            get { return phrase; }
            set
            {
                phrase = value;
                OnPropertyChanged("Phrase");
            }
        }
        public string Description { 
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            Type t = typeof(PhrasePackage);
            PropertyInfo? v = t.GetProperty(prop);
            
            Console.WriteLine(prop + " changed " + v.GetValue(this));
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Phrase ToGrpc()
        {
            Phrase phrase = new Phrase();
            phrase.StrPhrase = this.phrase;
            phrase.Description = description;
            return phrase;
        }
        public static PhrasePackage FromGrpc(Phrase p)
        {
            PhrasePackage phrase = new PhrasePackage();
            phrase.phrase = p.StrPhrase;
            phrase.description = p.Description;
            return phrase;
        }
    }
}
