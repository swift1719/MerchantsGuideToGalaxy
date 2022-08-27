using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class ProductPriceQuery:IQuery
    {
        public ProductPriceQuery(string galacticQuantity, string productName)
        {
            GalacticQuantity = galacticQuantity;
            ProductName = productName;
        }
        public string GalacticQuantity { get; }
        public string ProductName { get; }
        public IReply Response(Merchant merchant)
        {
            var quantityInDecimal = merchant.GalacticNumber.GetDecimalValue(GalacticQuantity);
            var unitPrice = merchant.Prices.GetProductUnitPrice(ProductName);
            return new ProductPriceReply(GalacticQuantity, ProductName, unitPrice * quantityInDecimal);
        }

    }
}
