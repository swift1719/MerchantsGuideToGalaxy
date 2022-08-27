using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class NumberConversionReply:IReply
    {
        public NumberConversionReply(string galacticNumber, decimal decimalValue)
        {
            GalacticNumber = galacticNumber;
            DecimalValue = decimalValue;
        }

        public string GalacticNumber { get; }
        public decimal DecimalValue { get; }

        public string Text => $"{GalacticNumber} is {DecimalValue}.";
    }
}
