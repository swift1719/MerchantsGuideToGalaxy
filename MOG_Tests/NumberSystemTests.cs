using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOG_Tests
{
    public class NumberSystemTests
    {
        [Fact]
        public void Number_System_Should_Set_Aliases()
        {
            string alias = "glob";
            GalacticNumberSystem numberSystem = new GalacticNumberSystem();
            numberSystem.SetAlias(alias, RomanDigit.I);

            numberSystem.GetAlias(alias).Should().Be(RomanDigit.I);
        }

        [Fact]
        public void Number_System_Should_Provide_Decimal_Value()
        {
            string alias = "pish";
            string number = "pish pish";
            GalacticNumberSystem galacticNumberSystem = new GalacticNumberSystem();
            galacticNumberSystem.SetAlias(alias, RomanDigit.I);
            galacticNumberSystem.GetDecimalValue(number).Should().Be(2);
        }
    }
}
