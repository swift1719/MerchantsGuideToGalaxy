using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class NumberConversionQuery:IQuery
    {
        public NumberConversionQuery(string galacticNumber)
        {
            GalacticNumber = galacticNumber;
        }
        public string GalacticNumber { get; }
        public IReply Response(Merchant merchant)
        {
            var decimalValue = merchant.GalacticNumber.GetDecimalValue(GalacticNumber);
            return new NumberConversionReply(GalacticNumber,decimalValue);
        }
    }
}
