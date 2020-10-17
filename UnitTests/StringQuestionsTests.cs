using Microsoft.VisualStudio.TestTools.UnitTesting;

using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class StringQuestionsTests
    {
        [TestMethod]
        public void FirstUniqueChar_leetcode_Should_Return_0()
        {
            // Arrange

            // Act
            var result = StringQuestions.FirstUniqueChar("leetcode");

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FirstUniqueChar_loveleetcode_Should_Return_2()
        {
            // Arrange

            // Act
            var result = StringQuestions.FirstUniqueChar("loveleetcode");

            // Assert
            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void FirstUniqueChar_abcdabbdddd_Should_Return_2()
        {
            // Arrange

            // Act
            var result = StringQuestions.FirstUniqueChar("abcdabbdddd");

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
