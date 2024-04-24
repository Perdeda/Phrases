using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp
{
    public class ViewModel
    {
        private PhrasePackage currPackage;
        public PhrasePackage CurrPackage { 
            get { CheckPackageForNull();  return currPackage; } 
            set
            {
                CheckPackageForNull();
                currPackage = value;
            }
        }
        private void CheckPackageForNull()
        {
            if (currPackage is null) currPackage = new PhrasePackage();
        }
        public ViewModel() 
        {
            CurrPackage = new PhrasePackage();
        }
    }
}
