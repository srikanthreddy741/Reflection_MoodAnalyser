using ReflectionMoodAnalyser;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyserFactory moodAnalyserfactory;
        [SetUp]
        public void Setup()
        {
            moodAnalyserfactory = new MoodAnalyserFactory();
        }

        /// <summary>
        /// TC-6.1  Given Happy Message Using Reflection When Proper Should Return HAPPY Mood
        /// To pass this TC use reflection to invoke analyseMood Method and show HAPPY mood
        [Test]
        public void GivenHppyMessge_Proper_ShouldReturnHppy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyserMood");
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// TC-6.2 Given Happy Message When Improper Method Should Throw MoodAnalysisException
        /// To pass this Test Case pass wrong Method Name,
        /// catch the Exception and throw indicating No Such Method Error
        /// </summary>
        [Test]
        public void GivenHppyMessge_WhenIMProperMethod_ShouldThrowException()
        {
            string expected = "Method not found";
            try
            {
                string mood = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "Analyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}