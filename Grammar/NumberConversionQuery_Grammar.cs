using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class NumberConversionQuery_Grammar:IGrammar
    {

        public bool TryParse(string text, out ISentence query)
        {
            query = null;

            if(text.StartsWith("how much is ", StringComparison.Ordinal) == false)
            {
                return false;
            }
            if (text.EndsWith("?", StringComparison.Ordinal) == false)
            {
                return false;
            }

            var number = text.Replace("how much is ", string.Empty).Replace(" ?", string.Empty);
            query = new NumberConversionQuery(number);
            return true;
        }
    }
}
