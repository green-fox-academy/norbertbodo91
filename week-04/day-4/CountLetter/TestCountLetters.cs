using NUnit.Framework;
using Countletter;

namespace TestCountLetter
{
    [TestFixture]
    public class TestCountLetters
    {
        [Test]
        public void TestCountWord()
        {
            ClassCountLetter word = new ClassCountLetter();

            string input = "jjjozsi";

            Assert.AreEqual(2, word.CountMyLetter(input)['j']);
        }
    }
}
