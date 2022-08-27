using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class NumberAliasStatement:IStatement
    {
        public NumberAliasStatement(RomanDigit digit, string alias)
        {
            Digit = digit;
            Alias = alias;
        }

        public RomanDigit Digit { get; }
        public string Alias { get; }

        public void Train(Merchant merchant)
        {
            merchant.GalacticNumber.SetAlias(Alias, Digit);
        }
    }
}
