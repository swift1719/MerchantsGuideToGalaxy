using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public interface IGrammar
    {
        bool TryParse(string text, out ISentence sentence);
    }
}
