using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class ProductValueStatement:IStatement
    {
        public ProductValueStatement(string quantity, string productName , int credits)
        {
            QuantityInGalacticSystem = quantity;
            ProductName = productName;
            ValueInCredits = credits;
        }
        public string ProductName { get; }
        public string QuantityInGalacticSystem { get; }
        public int ValueInCredits { get; }
        public void Train(Merchant merchant)
        {
            var quantityInDecimal = merchant.GalacticNumber.GetDecimalValue(QuantityInGalacticSystem);
            float unitPrice = ValueInCredits/(float)quantityInDecimal;
            merchant.Prices.AddProduct(new Product(ProductName, unitPrice));
        }
    }
}
