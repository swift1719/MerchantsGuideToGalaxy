
namespace MerchantsGuideToGalaxy
{
    public class Merchant
    {
        public ProductPriceList Prices{get;} = new ProductPriceList();

        public GalacticNumberSystem GalacticNumber{get;} = new GalacticNumberSystem();

        public Language Language { get; } = new Language();

        public void CollectInformation(string text)
        {
            if(Language.TryParse(text,out ISentence sentence) == false)
            {
                return;
            }
            if(sentence is IStatement stmt)
            {
                stmt.Train(this);
            }
        }
        public IReply RespondToQuery(string query)
        {
            Language.TryParse(query, out ISentence sentence);
            if(sentence is IQuery question)
            {
                return question.Response(this);
            }
            return new InvalidQueryReply();
        }
    }
}
