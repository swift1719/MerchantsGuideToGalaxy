using MerchantsGuideToGalaxy.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class Language
    {
        private readonly List<IGrammar> _grammers = new List<IGrammar>
        {
            new NumberAliasStatement_Grammar(),
            new NumberConversionQuery_Grammar(),
            new ProductValueStatement_Grammar(),
            new ProductPriceQuery_Grammar()
        };
        public bool TryParse(string text, out ISentence sentence)
        {
            sentence = null;

            foreach (var grammer in _grammers)
            {
                if(grammer.TryParse(text, out sentence) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

