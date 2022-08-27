

namespace MerchantsGuideToGalaxy
{
    public class Product
    {

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public float Price { get; }
    }
}
