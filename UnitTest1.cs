using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerwithCore;

namespace MoodAnalyzerMsTestwithCore
{
    [TestClass]
    public class UnitTest1
    {
     //summary
     [TestMethod]
     public void GivenSadMoodshouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        //summary
        //Tc 1.2 & 2.1 Give ? I am in HappyMood? and null message Should Return HAPPY
        [TestMethod]
        //[DataRow (I am in Happy Mood)]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHAPPY()
        {   
            
            //arrange

            string expected = "HAPPY";
            string message = "I am In Happy Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }
        //summary
        //Tc 3.2 Given Empty Mood should throw MoodAnalysisException Including Empty Mood
        [TestMethod]
        public void Given_Empty_Mood_should_throw_MoodAnalysisException_Including_Empty_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
                string mood = moodAnalyse.AnalyseMood();

            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }

        //summary
        //Tc 3.1 Given Null Mood should throw MoodAnalysisException
        public void Given_NULL_MOOd_should_throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }

    }

}
