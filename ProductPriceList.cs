using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class ProductPriceList
    {
        private Dictionary<string, Product> _products  = new Dictionary<string, Product>();

        public void AddProduct(Product product)
        {
            _products[product.Name] = product;
        }

        public float GetProductUnitPrice(string productName)
        {
            return _products[productName].Price;
        }
    }
}
