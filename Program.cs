using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");

            string message = null;
            MoodAnalyser mood = new MoodAnalyser(message);
            Console.WriteLine(mood.AnalyseMood());
        }
    }
}
