using MoodAnalyserProblem;

namespace MoodAnalyserProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyser = new MoodAnalyser();

        //-------------TC 1.1---------------
        [TestMethod]
        public void GivenSadMoodShouldGiveSAD()
        {
            //Arrange
            string expected = "SAD";

            //Act
            string actual = moodAnalyser.AnalyseMood("I am in Sad Mood");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //-------------TC 1.2---------------

        [TestMethod]
        public void GivenAnyMoodHAPPY()
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood("I am in Any Mood");

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
