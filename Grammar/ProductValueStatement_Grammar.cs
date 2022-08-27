using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy.Grammar
{
    public class ProductValueStatement_Grammar:IGrammar
    {
        public bool TryParse(string text, out ISentence statement)
        {
            statement = null;
            if (text.EndsWith("Credits", StringComparison.Ordinal) == false)
            {
                return false;
            }

            var tokens = text.Split(' ');

            if(tokens.Length < 5)
            {
                return false;
            }

            var creditString = tokens[tokens.Length - 2];

            if(int.TryParse(creditString,out int valueInCredits) == false)
            {
                return false;
            }

            if (tokens[tokens.Length - 3] != "is")
            {
                return false;
            }

            var productName = tokens[tokens.Length - 4];

            var quantity = string.Join(" ", tokens.Take(tokens.Length - 4));
            statement = new ProductValueStatement(quantity, productName, valueInCredits);

            return true;
        }
    }
}
