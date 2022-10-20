using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOG_Tests
{
    public class ProcessingScriptTest
    {
        [Fact]
        public void Script_Should_Process_And_Respond_To_Queries()
        {
            var dialogues = new string[]
            {
                "glob is I",
                "prok is V",
                "pish is X",
                "tegj is L",
                "glob glob Silver is 34 Credits",
                "glob prok Gold is 57800 Credits",
                "pish pish Iron is 3910 Credits",
                "how much is pish tegj glob glob ?",
                "how many Credits is glob prok Silver ?",
                "how many Credits is glob prok Gold ?",
                "how many Credits is glob prok Iron ?",
                "how much wood could a woodchuck chuck if a woodchuck could chuck wood ?"
            };

            var expectedResponses = new string[]
            {
                "pish tegj glob glob is 42.",
                "glob prok Silver is 68 Credits",
                "glob prok Gold is 57800 Credits",
                "glob prok Iron is 782 Credits",
                "Sorry i have no idea what you are talking about."

            };

            ProcessingScript processingScript = new ProcessingScript();
            
            List<string> responses = processingScript.PlayScript(dialogues);
            responses.Should().ContainInOrder(expectedResponses);


        }
    }
}
