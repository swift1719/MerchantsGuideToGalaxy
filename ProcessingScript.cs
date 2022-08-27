using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantsGuideToGalaxy
{
    public class ProcessingScript
    {
        public List<string> PlayScript(string[] dialogues)
        {
            var merchant = new Merchant();
            var responses = new List<string>();
            foreach (var dialogue in dialogues)
            {
                var isQuestion = dialogue.EndsWith("?", StringComparison.Ordinal);
                if (isQuestion == true)
                    responses.Add(merchant.RespondToQuery(dialogue).Text);
                else
                    merchant.CollectInformation(dialogue);
            }
            return responses;
        }
    }
}
