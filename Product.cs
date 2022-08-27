

namespace MerchantsGuideToGalaxy
{
    public class Product
    {

        public Product(string name, string price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public string Price { get; }
    }
}
