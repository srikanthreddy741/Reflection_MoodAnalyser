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
        /// TC-5.1  Given MoodAnalyser When Proper Return MoodAnalyser Object 
        /// • Use MoodAnalyser Factory to create a MoodAnalyser Object with Parameter constructor 
        /// • Use Equals method in MoodAnalyser to check if the two objects are equal
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturn_MoodAnalyserObject_UsingParametrizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_reflection_MoodAnalyser.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-5.2  Given Class Name When Improper Should Throw MoodAnalysisException
        /// To pass this test case pass wrong class name catch Exception and throw Exception
        /// indicating No Such Class Error
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_Improper_UsingParametrizedConstructor_ShouldThrow_Excpetion()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_reflection_MoodAnalyser.Mood", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-5.3  Given Class When Constructor Not Proper Should Throw MoodAnalysisException 
        /// To pass this Test Case pass wrong Constructor parameter, catch the Exception and 
        /// throw indicating No Such Method Error
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ConstructorIsImproper_UsingParametrizedConstructor_Should_ThrowExcpetion()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("Day20_reflection_MoodAnalyser.MoodAnalyser", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }

}