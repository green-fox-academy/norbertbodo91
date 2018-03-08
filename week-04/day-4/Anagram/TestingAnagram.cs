using NUnit.Framework;
using AnagramClass;

namespace AnagramTest
{
    [TestFixture]
    public class TestingAnagram
    {
        [Test]
        public void TestAnagram()
        {
            Anagram anagram = new Anagram();

            string wordFirst = "joseph";
            string wordSecond = "hespoj";

            Assert.AreEqual(true,anagram.IsAnagram(wordFirst,wordSecond));
        }
    }
}
