using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");

            MoodAnalyser mood = new MoodAnalyser();
            string message = "I am in any Mood";
            Console.WriteLine(mood.AnalyseMood(message));
        }
    }
}
