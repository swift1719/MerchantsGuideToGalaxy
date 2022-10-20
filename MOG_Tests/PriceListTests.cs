
namespace MOG_Tests
{
    public class PriceListTests
    {
        [Fact]
        public void Product_Should_Be_Populated_In_PriceList()
        {
            string productName = "Test Product";
            float price = 300;
            Product product = new(productName, price);
            ProductPriceList productPriceList = new();
            productPriceList.AddProduct(product);

            productPriceList.GetProductUnitPrice(productName).Should().Be(price);


        }
    }
}
