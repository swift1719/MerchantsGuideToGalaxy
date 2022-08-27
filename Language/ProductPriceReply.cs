using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{ 
    public class ProductPriceReply:IReply
    {
        public ProductPriceReply(string galacticQuantity, string productName, float priceInCredits)
        {
            GalacticQuantity = galacticQuantity;
            ProductName = productName;
            ProductPriceInCredits= priceInCredits;
        }   
        public string GalacticQuantity { get; }
        public string ProductName { get; }
        public float ProductPriceInCredits { get; }

        public string Text => $"{GalacticQuantity} {ProductName} is {ProductPriceInCredits} Credits";
    }
}
