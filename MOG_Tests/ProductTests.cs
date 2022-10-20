
namespace MOG_Tests
{
    public class ProductTests
    {
        [Fact]
        public void Every_Product_Should_Have_A_Name_And_Price()
        {
            string productName = "Test Product";
            float price = 300;
            Product product = new(productName, price);
            product.Name.Should().Be(productName);
            product.Price.Should().Be(price);
        }
    }
}