using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy.Grammar
{
    public class ProductPriceQuery_Grammar:IGrammar
    {
        public bool TryParse(string text , out ISentence query)
        {
            query = null;
            if(text.StartsWith("how many Credits is ", StringComparison.Ordinal) == false)
            {
                return false;
            }
            if (text.EndsWith("?", StringComparison.Ordinal) == false)
            {
                return false;
            }

            var tokens = text.Replace("how many Credits is ", string.Empty).Replace(" ?", string.Empty).Split(' ');
            var productName = tokens.Last();
            var quantity = string.Join(" ", tokens.Take(tokens.Length - 1));
            query = new ProductPriceQuery(quantity, productName);
            return true;
        }
    }
}
