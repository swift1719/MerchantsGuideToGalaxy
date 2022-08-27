using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class InvalidQueryReply:IReply
    {
        public string Text => $"Sorry i have no idea what you are talking about.";
    }
}
