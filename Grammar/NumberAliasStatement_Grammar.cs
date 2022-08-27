using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy.Grammar
{
    public class NumberAliasStatement_Grammar:IGrammar
    {
        public bool TryParse(string text, out ISentence statement)
        {
            statement = null;

            var tokens = text.Split(' ');

            if (tokens.Length != 3)
            {
                return false;
            }
            if (Enum.TryParse<RomanDigit>(tokens[2],out RomanDigit digit) == false)
            {
                return false;
            }

            statement = new NumberAliasStatement(digit, tokens[0]);

            return true;
        }
    }
}
