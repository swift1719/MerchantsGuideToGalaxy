using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOG_Tests
{
    public class MerchantTests
    {
        [Fact]
        public void Merchants_Can_Gather_The_Aliases_Of_Number_System()
        {
            Merchant merchant = new Merchant();
            merchant.CollectInformation("pish is I");
            merchant.GalacticNumber.GetDecimalValue("pish").Should().Be(1);
        }

        [Fact]
        public void Merchants_Can_Gather_The_Price_Of_Items()
        {
            Merchant merchant = new Merchant();
            merchant.CollectInformation("pish is I");
            merchant.CollectInformation("pish pish Silver is 34 Credits");
            merchant.Prices.GetProductUnitPrice("Silver").Should().Be(17);
        }

        [Fact]
        public void Merchants_Should_Respond_To_Number_Conversion_Query()
        {
            Merchant merchant = new Merchant();
            merchant.CollectInformation("pish is I");
            merchant.CollectInformation("glob is V");

            IReply response = merchant.RespondToQuery("how much is pish glob ?");

            response.Text.Should().Be("pish glob is 4.");
        }

        [Fact]
        public void Merchants_Should_Respond_To_Product_Price_Query()
        {
            Merchant merchant = new Merchant();
            merchant.CollectInformation("pish is I");
            merchant.CollectInformation("pish pish Silver is 20 Credits");

            IReply response = merchant.RespondToQuery("how many Credits is pish pish pish Silver ?");
            response.Text.Should().Be("pish pish pish Silver is 30 Credits");
        }
    }
}
