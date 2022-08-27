using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public interface IQuery:ISentence
    {
        IReply Response(Merchant merchant);
    }
}
