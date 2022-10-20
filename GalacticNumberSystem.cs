using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class GalacticNumberSystem
    {
        private readonly Dictionary<string, RomanDigit> _aliases = new Dictionary<string, RomanDigit>();

        public void SetAlias(string alias, RomanDigit digit)
        {
            _aliases[alias] = digit;
        }

        public RomanDigit GetAlias(string alias)
        {
            return _aliases[alias];
        }

        public int GetDecimalValue(string number)
        {
            int result = 0;

            var digits = number.Split(' ').Select(GetAlias).ToArray();

            if (digits.Length == 1)
            {
                return (int)digits.Single();
            }

            var index = 0;
            var sum = 0;


            while (index < digits.Length)
            {
                sum = 0;
                var current = (int)digits[index];
                var next = index < digits.Length - 1 ? (int)digits[index + 1] : 0;

                if(next > current)
                {
                    sum = next - current;
                    index += 2;
                }
                else
                {
                    sum = current;
                    index++;
                }
                result += sum;
            }

            return result;
        }
    }
}
