using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
            string message;
            public MoodAnalyser(string message)
            {
                this.message = message;
            }

            public string AnalyseMood()
            {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {

                return "HAPPY";
            }

        }
    }
}
