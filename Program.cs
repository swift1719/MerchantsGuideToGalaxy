
namespace MerchantsGuideToGalaxy
{
    public class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter no of lines : ");
            int noOfInformationLines = int.Parse(Console.ReadLine());

            string[] informationLines = new string[noOfInformationLines];
            for (int i = 0; i < noOfInformationLines; i++)
            {
                informationLines[i] = Console.ReadLine();
            }
            ProcessingScript service = new ProcessingScript();
            
            foreach(var response in service.PlayScript(informationLines))
            {
                Console.WriteLine(response);
            }
        }
    }
}